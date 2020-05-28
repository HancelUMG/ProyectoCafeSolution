using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Cliente
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Acumulado { get; set; }
        public string Comprado { get; set; }
        public string Pendiente { get; set; }

        public Cliente(string DPI, string Nombre)
        {
            this.DPI = DPI;
            this.Nombre = Nombre;
            this.Acumulado = "0";
            this.Comprado = "0";
            this.Pendiente = "0";
        }

        public Cliente()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into cliente (dpi, nombre_cliente, acumulado, comprado) values ('" + DPI + "','" + Nombre + "', '0', '0');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<Cliente> Ver()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente elemento = new Cliente();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from cliente;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();
            float acum;
            float comp;
            //float pend;

            while (registros.Read())
            {
                acum = float.Parse(registros["acumulado"].ToString()) / 100;
                comp = float.Parse(registros["comprado"].ToString()) / 100;
                //pend = float.Parse(registros["pendiente"].ToString()) / 100;

                elemento = new Cliente
                {
                    DPI = registros["dpi"].ToString(),
                    Nombre = registros["nombre_cliente"].ToString(),
                    Acumulado = acum.ToString(),
                    Comprado = comp.ToString(),
                    //Pendiente = pend.ToString()
                };

                clientes.Add(elemento);

            }

            conect.Close();

            return clientes;
        }

        public List<Cliente> Buscar(string pbuscar)
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente encontrado = new Cliente();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from cliente;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registro = comando.ExecuteReader();
            float acum;
            float comp;
            float pend;

            string cadena1;
            string cadena2;
            //este campo sirve por si se ingresa el dpi
            string DocPerId = pbuscar;

            while(DocPerId.Contains(" "))
            {
                DocPerId = DocPerId.Replace(" ", "");
            }

            while (registro.Read())
            {
                cadena1 = registro["dpi"].ToString();
                cadena2 = registro["nombre_cliente"].ToString();
                acum = float.Parse(registro["acumulado"].ToString()) / 100;
                comp = float.Parse(registro["comprado"].ToString()) / 100;
                //pend = float.Parse(registro["pendiente"].ToString()) / 100;

                if (cadena1.Equals(DocPerId) || cadena2.Contains(pbuscar))
                {
                    encontrado = new Cliente
                    {
                        DPI = registro["dpi"].ToString(),
                        Nombre = registro["nombre_cliente"].ToString(),
                        Acumulado = acum.ToString(),
                        Comprado = comp.ToString(),
                        //Pendiente = pend.ToString()
                    };

                    clientes.Add(encontrado);
                }

            }

            conect.Close();

            return clientes;
        }

        public string getNombre(string dpi)
        {
            string nombre = "";
            SqlConnection conectar = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conectar.Open();
            string select = "select * from cliente where dpi = '" + dpi + "';";
            SqlCommand comando = new SqlCommand(select, conectar);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                nombre = registros["nombre_cliente"].ToString();
            }

            conectar.Close();

            return nombre;
        }

        public string getDPI(string nombre)
        {
            string dpi = "";
            SqlConnection conectar = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conectar.Open();
            string select = "select * from cliente where nombre_cliente = '" + nombre + "';";
            SqlCommand comando = new SqlCommand(select, conectar);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                dpi = registros["dpi"].ToString();
            }

            conectar.Close();

            return nombre;
        }

        public string getAcumulado(string pDPI)
        {
            string acum="";
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select cliente.acumulado from cliente where dpi = '" + pDPI + "';";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                acum = registro["acumulado"].ToString();
            }

            conect.Close();
            return acum;
        }

        public void setAcumulado(string pNuevo, string pDPI)
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string update = "update cliente set acumulado = '" + pNuevo + "' where dpi = '" + pDPI + "';";
            SqlCommand comando = new SqlCommand(update, conect);
            comando.ExecuteReader();
        }

        public string getComprado(string pDPI)
        {
            string comp = "";
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select cliente.comprado from cliente where dpi = '" + pDPI + "';";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                comp = registro["comprado"].ToString();
            }

            conect.Close();
            return comp;
        }

        public void setComprado(string pNuevo, string pDPI)
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string update = "update cliente set comprado = '" + pNuevo + "' where dpi = '" + pDPI + "';";
            SqlCommand comando = new SqlCommand(update, conect);
            comando.ExecuteReader();
        }
    }
}
