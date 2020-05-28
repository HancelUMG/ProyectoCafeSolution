using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Ingresosp
    {
        public string NÚMERO { get; set; }
        public string DPI { get; set; }
        public string CLIENTE { get; set; }
        public string ID_LUGAR { get; set; }
        public string LUGAR { get; set; }
        public string ENTREGÓ { get; set; }
        public string PESO_BRUTO { get; set; }
        public string TARA { get; set; }
        public string PESO_NETO { get; set; }
        public string FECHA { get; set; }
        public string USUARIO { get; set; }


        public Ingresosp(string DPI, string ID_LUGAR, string ENTREGÓ, string PESO_BRUTO, string TARA, string PESO_NETO, string USUARIO)
        {
            this.DPI = DPI;
            this.ID_LUGAR = ID_LUGAR;
            this.ENTREGÓ = ENTREGÓ;
            this.PESO_BRUTO = PESO_BRUTO;
            this.TARA = TARA;
            this.PESO_NETO = PESO_NETO;
            FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            this.USUARIO = USUARIO;
        }

        public Ingresosp()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into ingresosp (id_clientesp, id_lugarsp, entregasp, peso_brutosp, tarasp, peso_netosp, fechasp, usuariosp) values ('" + DPI + "','" + ID_LUGAR + "','" + ENTREGÓ + "','" + PESO_BRUTO + "','" + TARA + "','" + PESO_NETO + "','" + FECHA + "','" + USUARIO + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<Ingresosp> Ver()
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresosp> ingresosps = new List<Ingresosp>();
            Ingresosp elemento = new Ingresosp();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresosp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresosp
                {
                    NÚMERO = registros["id_ingresosp"].ToString(),
                    DPI = registros["id_clientesp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientesp"].ToString()),
                    ID_LUGAR = registros["id_lugarsp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarsp"].ToString()),
                    ENTREGÓ = registros["entregasp"].ToString(),
                    PESO_BRUTO = registros["peso_brutosp"].ToString(),
                    TARA = registros["tarasp"].ToString(),
                    PESO_NETO = registros["peso_netosp"].ToString(),
                    FECHA = registros["fechasp"].ToString(),
                    USUARIO = registros["usuariosp"].ToString()
                };

                ingresosps.Add(elemento);

            }

            conect.Close();

            return ingresosps;

        }

        public List<Ingresosp> BuscarFec(DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresosp> ingresos = new List<Ingresosp>();
            Ingresosp elemento = new Ingresosp();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresosp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Ingresosp
                {
                    NÚMERO = registros["id_ingresosp"].ToString(),
                    DPI = registros["id_clientesp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientesp"].ToString()),
                    ID_LUGAR = registros["id_lugarsp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarsp"].ToString()),
                    ENTREGÓ = registros["entregasp"].ToString(),
                    PESO_BRUTO = registros["peso_brutosp"].ToString(),
                    TARA = registros["tarasp"].ToString(),
                    PESO_NETO = registros["peso_netosp"].ToString(),
                    FECHA = registros["fechasp"].ToString(),
                    USUARIO = registros["usuariosp"].ToString()
                };

                fecha = Convert.ToDateTime(elemento.FECHA);

                if (fecha.ToString("dd/MM/yyyy").Equals(De.ToString("dd/MM/yyyy")) && fecha.ToString("dd/MM/yyyy").Equals(A.ToString("dd/MM/yyyy")) || fecha >= De && fecha <= A)
                {
                    ingresos.Add(elemento);
                }

            }

            conect.Close();

            return ingresos;
        }

        public List<Ingresosp> BuscarNum(string pNumero)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresosp> ingresosps = new List<Ingresosp>();
            Ingresosp elemento = new Ingresosp();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresosp where id_ingresosp = '"+pNumero+"';";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {

                elemento = new Ingresosp
                {
                    NÚMERO = registros["id_ingresosp"].ToString(),
                    DPI = registros["id_clientesp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientesp"].ToString()),
                    ID_LUGAR = registros["id_lugarsp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarsp"].ToString()),
                    ENTREGÓ = registros["entregasp"].ToString(),
                    PESO_BRUTO = registros["peso_brutosp"].ToString(),
                    TARA = registros["tarasp"].ToString(),
                    PESO_NETO = registros["peso_netosp"].ToString(),
                    FECHA = registros["fechasp"].ToString(),
                    USUARIO = registros["usuariosp"].ToString()
                };

                ingresosps.Add(elemento);

            }

            conect.Close();

            return ingresosps;

        }

        public List<Ingresosp> BuscarDPIoNom(string dato, DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresosp> ingresosps = new List<Ingresosp>();
            Ingresosp elemento = new Ingresosp();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresosp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresosp
                {
                    NÚMERO = registros["id_ingresosp"].ToString(),
                    DPI = registros["id_clientesp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientesp"].ToString()),
                    ID_LUGAR = registros["id_lugarsp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarsp"].ToString()),
                    ENTREGÓ = registros["entregasp"].ToString(),
                    PESO_BRUTO = registros["peso_brutosp"].ToString(),
                    TARA = registros["tarasp"].ToString(),
                    PESO_NETO = registros["peso_netosp"].ToString(),
                    FECHA = registros["fechasp"].ToString(),
                    USUARIO = registros["usuariosp"].ToString()
                };

                if (elemento.CLIENTE.Contains(dato) || elemento.DPI.Equals(dato))
                {
                    fecha = Convert.ToDateTime(elemento.FECHA);

                    if(fecha.ToString("dd/MM/yyyy").Equals(De.ToString("dd/MM/yyyy")) && fecha.ToString("dd/MM/yyyy").Equals(A.ToString("dd/MM/yyyy")) || fecha >= De && fecha <= A)
                    {
                        ingresosps.Add(elemento);
                    }
                } 

            }

            conect.Close();

            return ingresosps;

        }

        public List<Ingresosp> BuscarPorLugar(string dato, DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresosp> ingresosps = new List<Ingresosp>();
            Ingresosp elemento = new Ingresosp();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresosp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresosp
                {
                    NÚMERO = registros["id_ingresosp"].ToString(),
                    DPI = registros["id_clientesp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientesp"].ToString()),
                    ID_LUGAR = registros["id_lugarsp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarsp"].ToString()),
                    ENTREGÓ = registros["entregasp"].ToString(),
                    PESO_BRUTO = registros["peso_brutosp"].ToString(),
                    TARA = registros["tarasp"].ToString(),
                    PESO_NETO = registros["peso_netosp"].ToString(),
                    FECHA = registros["fechasp"].ToString(),
                    USUARIO = registros["usuariosp"].ToString()
                };

                if (elemento.LUGAR.Equals(dato))
                {
                    fecha = Convert.ToDateTime(elemento.FECHA);

                    if (fecha.ToString("dd/MM/yyyy").Equals(De.ToString("dd/MM/yyyy")) && fecha.ToString("dd/MM/yyyy").Equals(A.ToString("dd/MM/yyyy")) || fecha >= De && fecha <= A)
                    {
                        ingresosps.Add(elemento);
                    }
                }

            }

            conect.Close();

            return ingresosps;

        }
    }
}
