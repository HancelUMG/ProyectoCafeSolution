using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Banco
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Cuenta { get; set; }

        public Banco(string Nombre, string Cuenta)
        {
            this.Nombre = Nombre;
            this.Cuenta = Cuenta;
        }

        public Banco()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true;");
            conect.Open();
            string insertar = "insert into banco (nombre, cuenta) values ('" + Nombre + "','" + Cuenta + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<Banco> ver()
        {
            List<Banco> bancos = new List<Banco>();
            Banco elemento = new Banco();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true;");
            conect.Open();
            string select = "select * from banco;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Banco
                {
                    ID = registros["id_banco"].ToString(),
                    Nombre = registros["nombre"].ToString(),
                    Cuenta = registros["cuenta"].ToString()
                };

                bancos.Add(elemento);

            }

            conect.Close();

            return bancos;
        }

        public string getNombre(string cuenta)
        {
            string nombre = "";
            SqlConnection conectar = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conectar.Open();
            string select = "select * from banco where cuenta = '" + cuenta + "';";
            SqlCommand comando = new SqlCommand(select, conectar);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                nombre = registros["nombre"].ToString();
            }

            conectar.Close();

            return nombre;
        }
    }
}
