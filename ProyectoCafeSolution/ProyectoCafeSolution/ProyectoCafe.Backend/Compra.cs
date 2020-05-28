using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Compra
    {
        public string NÚMERO { get; set; }
        public string DPI { get; set; }
        public string CLIENTE { get; set; }
        public string ID_FORMAPAGO { get; set; }
        public string FORMA_PAGO { get; set; }
        public string CUENTA { get; set; }
        public string BANCO { get; set; }
        public string ACUMULADO { get; set; }
        public string PESO { get; set; }
        public string PRECIO { get; set; }
        public string TOTAL { get; set; }
        public string PENDIENTE { get; set; }
        public string ID_LUGAR { get; set; }
        public string LUGAR { get; set; }
        public string FECHA { get; set; }
        public string USUARIO { get; set; }

        public Compra(string DPI, string ID_FORMAPAGO, string CUENTA, string ACUMULADO, string PESO, string PRECIO, string PENDIENTE, string ID_LUGAR, string USUARIO)
        {
            this.DPI = DPI;
            this.ID_FORMAPAGO = ID_FORMAPAGO;
            this.CUENTA = CUENTA;
            this.ACUMULADO = ACUMULADO;
            this.PESO = PESO;
            this.PRECIO = PRECIO;
            this.PENDIENTE = PENDIENTE;
            this.ID_LUGAR = ID_LUGAR;
            FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            this.USUARIO = USUARIO;
        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into compra (id_clientec, id_formapagoc, cuentac, actual, pesoc, precioc, nuevo, id_lugarc, fechac, usuarioc) values ('" + DPI + "','" + ID_FORMAPAGO + "','" + CUENTA + "','" + ACUMULADO + "','" + PESO + "','" + PRECIO + "','" + PENDIENTE + "','" + ID_LUGAR + "','" + FECHA + "','" + USUARIO + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public Compra()
        {

        }

        public List<Compra> Ver()
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Compra> ingresocps = new List<Compra>();
            Compra elemento = new Compra();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from compra;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Compra()
                {
                    NÚMERO = registros["id_compra"].ToString(),
                    DPI = registros["id_clientec"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientec"].ToString()),
                    ID_FORMAPAGO = registros["id_formapagoc"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagoc"].ToString()),
                    CUENTA = registros["cuentac"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentac"].ToString()),
                    ACUMULADO = registros["actual"].ToString(),
                    PESO = registros["pesoc"].ToString(),
                    PRECIO = "Q " + registros["precioc"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["pesoc"].ToString()) * Convert.ToDecimal(registros["precioc"].ToString())),
                    PENDIENTE = registros["nuevo"].ToString(),
                    ID_LUGAR = registros["id_lugarc"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarc"].ToString()),
                    FECHA = registros["fechac"].ToString(),
                    USUARIO = registros["usuarioc"].ToString()
                };

                ingresocps.Add(elemento);

            }

            conect.Close();

            return ingresocps;

        }
    }
}
