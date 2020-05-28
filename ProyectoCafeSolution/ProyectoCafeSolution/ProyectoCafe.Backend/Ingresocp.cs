using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Ingresocp
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
        public string PRECIO { get; set; }
        public string TOTAL { get; set; }
        public string ID_FORMAPAGO { get; set; }
        public string FORMA_PAGO { get; set; }
        public string CUENTA { get; set; }
        public string BANCO { get; set; }
        public string FECHA { get; set; }
        public string USUARIO { get; set; }

        public Ingresocp(string DPI, string ID_LUGAR, string ENTREGÓ, string PESO_BRUTO, string TARA, string PESO_NETO, string PRECIO, string ID_FORMAPAGO, string CUENTA, string USUARIO )
        {
            this.DPI = DPI;
            this.ID_LUGAR = ID_LUGAR;
            this.ENTREGÓ = ENTREGÓ;
            this.PESO_BRUTO = PESO_BRUTO;
            this.TARA = TARA;
            this.PESO_NETO = PESO_NETO;
            this.PRECIO = PRECIO;
            this.ID_FORMAPAGO = ID_FORMAPAGO;
            this.CUENTA = CUENTA;
            this.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            this.USUARIO = USUARIO;
        }

        public Ingresocp()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insert = "insert into ingresocp(id_clientecp, id_lugarcp, entregacp, peso_brutocp, taracp, peso_netocp, precio, id_formapagocp, cuentacp, fechacp, usuariocp) values ('" + DPI + "','" + ID_LUGAR + "','" + ENTREGÓ + "','" + PESO_BRUTO + "','" + TARA + "','" + PESO_NETO + "','" + PRECIO + "','" + ID_FORMAPAGO + "','" + CUENTA + "','" + FECHA + "','" + USUARIO + "');";
            SqlCommand comando = new SqlCommand(insert, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<Ingresocp> Ver()
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresocp> ingresocps = new List<Ingresocp>();
            Ingresocp elemento = new Ingresocp();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresocp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresocp
                {
                    NÚMERO = registros["id_ingresocp"].ToString(),
                    DPI = registros["id_clientecp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientecp"].ToString()),
                    ID_LUGAR = registros["id_lugarcp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarcp"].ToString()),
                    ENTREGÓ = registros["entregacp"].ToString(),
                    PESO_BRUTO = registros["peso_brutocp"].ToString(),
                    TARA = registros["taracp"].ToString(),
                    PESO_NETO = registros["peso_netocp"].ToString(),
                    PRECIO = "Q " + registros["precio"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["peso_netocp"].ToString()) * Convert.ToDecimal(registros["precio"].ToString())),
                    ID_FORMAPAGO = registros["id_formapagocp"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagocp"].ToString()),
                    CUENTA = registros["cuentacp"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentacp"].ToString()),
                    FECHA = registros["fechacp"].ToString(),
                    USUARIO = registros["usuariocp"].ToString()
                };

                ingresocps.Add(elemento);

            }

            conect.Close();

            return ingresocps;

        }

        public List<Ingresocp> BuscarFec(DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresocp> ingresos = new List<Ingresocp>();
            Ingresocp elemento = new Ingresocp();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresocp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Ingresocp
                {
                    NÚMERO = registros["id_ingresocp"].ToString(),
                    DPI = registros["id_clientecp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientecp"].ToString()),
                    ID_LUGAR = registros["id_lugarcp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarcp"].ToString()),
                    ENTREGÓ = registros["entregacp"].ToString(),
                    PESO_BRUTO = registros["peso_brutocp"].ToString(),
                    TARA = registros["taracp"].ToString(),
                    PESO_NETO = registros["peso_netocp"].ToString(),
                    PRECIO = registros["precio"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["peso_netocp"].ToString()) * Convert.ToDecimal(registros["precio"].ToString())),
                    ID_FORMAPAGO = registros["id_formapagocp"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagocp"].ToString()),
                    CUENTA = registros["cuentacp"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentacp"].ToString()),
                    FECHA = registros["fechacp"].ToString(),
                    USUARIO = registros["usuariocp"].ToString()
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

        public List<Ingresocp> BuscarNum(string pNumero)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresocp> ingresocps = new List<Ingresocp>();
            Ingresocp elemento = new Ingresocp();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresocp where id_ingresocp = '" + pNumero + "';";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {

                elemento = new Ingresocp
                {
                    NÚMERO = registros["id_ingresocp"].ToString(),
                    DPI = registros["id_clientecp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientecp"].ToString()),
                    ID_LUGAR = registros["id_lugarcp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarcp"].ToString()),
                    ENTREGÓ = registros["entregacp"].ToString(),
                    PESO_BRUTO = registros["peso_brutocp"].ToString(),
                    TARA = registros["taracp"].ToString(),
                    PESO_NETO = registros["peso_netocp"].ToString(),
                    PRECIO = registros["precio"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["peso_netocp"].ToString()) * Convert.ToDecimal(registros["precio"].ToString())),
                    ID_FORMAPAGO = registros["id_formapagocp"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagocp"].ToString()),
                    CUENTA = registros["cuentacp"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentacp"].ToString()),
                    FECHA = registros["fechacp"].ToString(),
                    USUARIO = registros["usuariocp"].ToString()
                };

                ingresocps.Add(elemento);

            }

            conect.Close();

            return ingresocps;

        }

        public List<Ingresocp> BuscarDPIoNom(string dato, DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresocp> ingresocps = new List<Ingresocp>();
            Ingresocp elemento = new Ingresocp();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresocp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresocp
                {
                    NÚMERO = registros["id_ingresocp"].ToString(),
                    DPI = registros["id_clientecp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientecp"].ToString()),
                    ID_LUGAR = registros["id_lugarcp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarcp"].ToString()),
                    ENTREGÓ = registros["entregacp"].ToString(),
                    PESO_BRUTO = registros["peso_brutocp"].ToString(),
                    TARA = registros["taracp"].ToString(),
                    PESO_NETO = registros["peso_netocp"].ToString(),
                    PRECIO = registros["precio"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["peso_netocp"].ToString()) * Convert.ToDecimal(registros["precio"].ToString())),
                    ID_FORMAPAGO = registros["id_formapagocp"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagocp"].ToString()),
                    CUENTA = registros["cuentacp"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentacp"].ToString()),
                    FECHA = registros["fechacp"].ToString(),
                    USUARIO = registros["usuariocp"].ToString()
                };

                if (elemento.CLIENTE.Contains(dato) || elemento.DPI.Equals(dato))
                {
                    fecha = Convert.ToDateTime(elemento.FECHA);

                    if (fecha.ToString("dd/MM/yyyy").Equals(De.ToString("dd/MM/yyyy")) && fecha.ToString("dd/MM/yyyy").Equals(A.ToString("dd/MM/yyyy")) || fecha >= De && fecha <= A)
                    {
                        ingresocps.Add(elemento);
                    }
                }

            }

            conect.Close();

            return ingresocps;

        }

        public List<Ingresocp> BuscarPorLugar(string dato, DateTime De, DateTime A)
        {
            Lugar objlugar = new Lugar();
            Cliente objcliente = new Cliente();
            List<Ingresocp> ingresocps = new List<Ingresocp>();
            Ingresocp elemento = new Ingresocp();
            FormaPago objformapago = new FormaPago();
            Banco objbanco = new Banco();
            DateTime fecha;
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from ingresocp;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {

                elemento = new Ingresocp
                {
                    NÚMERO = registros["id_ingresocp"].ToString(),
                    DPI = registros["id_clientecp"].ToString(),
                    CLIENTE = objcliente.getNombre(registros["id_clientecp"].ToString()),
                    ID_LUGAR = registros["id_lugarcp"].ToString(),
                    LUGAR = objlugar.getNombre(registros["id_lugarcp"].ToString()),
                    ENTREGÓ = registros["entregacp"].ToString(),
                    PESO_BRUTO = registros["peso_brutocp"].ToString(),
                    TARA = registros["taracp"].ToString(),
                    PESO_NETO = registros["peso_netocp"].ToString(),
                    PRECIO = registros["precio"].ToString(),
                    TOTAL = "Q " + Convert.ToString(Convert.ToDecimal(registros["peso_netocp"].ToString()) * Convert.ToDecimal(registros["precio"].ToString())),
                    ID_FORMAPAGO = registros["id_formapagocp"].ToString(),
                    FORMA_PAGO = objformapago.getDescripcion(registros["id_formapagocp"].ToString()),
                    CUENTA = registros["cuentacp"].ToString(),
                    BANCO = objbanco.getNombre(registros["cuentacp"].ToString()),
                    FECHA = registros["fechacp"].ToString(),
                    USUARIO = registros["usuariocp"].ToString()
                };

                if (elemento.LUGAR.Equals(dato))
                {
                    fecha = Convert.ToDateTime(elemento.FECHA);

                    if (fecha.ToString("dd/MM/yyyy").Equals(De.ToString("dd/MM/yyyy")) && fecha.ToString("dd/MM/yyyy").Equals(A.ToString("dd/MM/yyyy")) || fecha >= De && fecha <= A)
                    {
                        ingresocps.Add(elemento);
                    }
                }

            }

            conect.Close();

            return ingresocps;

        }
    }
}
