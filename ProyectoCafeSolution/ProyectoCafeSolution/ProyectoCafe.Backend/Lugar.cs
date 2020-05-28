using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Lugar
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Lugar(string Nombre, string Tipo)
        {
            this.Nombre = Nombre;
            this.Tipo = Tipo;
        }

        public Lugar()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into lugar (nombre_lugar, tipo) values ('" + Nombre + "','" + Tipo + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<Lugar> Ver(string pTipo)
        {
            List<Lugar> lugares = new List<Lugar>();
            Lugar elemento = new Lugar();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from lugar where tipo = '"+pTipo+"';";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Lugar
                {
                    ID = registros["id_lugar"].ToString(),
                    Nombre = registros["nombre_lugar"].ToString(),
                    Tipo = registros["tipo"].ToString()
                };

                lugares.Add(elemento);
            }

            conect.Close();

            return lugares;
        }

        //para llenar el combobox de los ingresos
        public List<Lugar> Ver()
        {
            List<Lugar> lugares = new List<Lugar>();
            Lugar elemento = new Lugar();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from lugar;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Lugar
                {
                    ID = registros["id_lugar"].ToString(),
                    Nombre = registros["nombre_lugar"].ToString(),
                    Tipo = registros["tipo"].ToString()
                };

                lugares.Add(elemento);
            }

            conect.Close();

            return lugares;
        }

        public string getNombre(string idLug)
        {
            string nombre = "";
            SqlConnection conectar = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conectar.Open();
            string select = "select * from lugar where id_lugar = '" + idLug + "';";
            SqlCommand comando = new SqlCommand(select, conectar);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                nombre = registro["nombre_lugar"].ToString();
            }

            conectar.Close();

            return nombre;
        }
    }
}
