using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCafe.Backend
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string NomUsuario { get; set; }
        public string Contraseña { get; set; }



        public Usuario(string Nombre, string NomUsuario, string Contraseña)
        {
            this.Nombre = Nombre;
            this.NomUsuario = NomUsuario;
            this.Contraseña = Contraseña;
        }

        public Usuario()
        {

        }

        public void Agregar()
        {
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string insertar = "insert into usuario (nombre_usuario, id_usuario, contraseña) values ('" + Nombre + "','" + NomUsuario + "','" + Contraseña + "');";
            SqlCommand comando = new SqlCommand(insertar, conect);
            comando.ExecuteNonQuery();
            conect.Close();
        }



        public List<Usuario> Ver()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario elemento = new Usuario();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from usuario;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                elemento = new Usuario
                {
                    Nombre = registros["nombre_usuario"].ToString(),
                    NomUsuario = registros["id_usuario"].ToString()
                };

                usuarios.Add(elemento);
            }

            conect.Close();

            return usuarios;
        }

        public List<Usuario> Buscar(string pbuscar)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario encontrado = new Usuario();
            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
            conect.Open();
            string select = "select * from usuario;";
            SqlCommand comando = new SqlCommand(select, conect);
            SqlDataReader registro = comando.ExecuteReader();

            string cadena1;
            string cadena2;

            while (registro.Read())
            {
                cadena1 = registro["nombre_usuario"].ToString();
                cadena2 = registro["id_usuario"].ToString();

                if (cadena1.Contains(pbuscar) || cadena2.Equals(pbuscar))
                {
                    encontrado = new Usuario
                    {
                        Nombre = registro["nombre_usuario"].ToString(),
                        NomUsuario = registro["id_usuario"].ToString()
                    };

                    usuarios.Add(encontrado);
                }
            }

            conect.Close();

            return usuarios;
        }
    }
}
