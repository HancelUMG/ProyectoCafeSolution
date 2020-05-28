using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class FormaPago
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }

        public FormaPago(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }

        public FormaPago()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into formapago (descripcion) values ('" + Descripcion + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public List<FormaPago> Ver()
        {
            List<FormaPago> formas = new List<FormaPago>();
            FormaPago elemento = new FormaPago();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from formapago;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new FormaPago
                {
                    ID = registros["id_formapago"].ToString(),
                    Descripcion = registros["descripcion"].ToString()
                };

                formas.Add(elemento);
            }

            conect.Close();

            return formas;
        }

        public string getDescripcion(string id)
        {
            string descripcion = "";
            SqlConnection conectar = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conectar.Open();
            string select = "select * from formapago where id_formapago = '" + id + "';";
            SqlCommand comando = new SqlCommand(select, conectar);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                descripcion = registros["descripcion"].ToString();
            }

            conectar.Close();

            return descripcion;
        }
    }
}
