using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCafe.Backend;
using System.Data.SqlClient;

namespace ProyectoCafe.Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario;
                string contraseña;

                SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                conect.Open();
                SqlCommand consulta = new SqlCommand("select id_usuario, contraseña from usuario where id_usuario = '" + txtusuario.Text + "' and contraseña = '" + txtcontraseña.Text + "'", conect);
                SqlDataReader datos = consulta.ExecuteReader();

                if (datos.Read())
                {
                    usuario = datos["id_usuario"].ToString();
                    contraseña = datos["contraseña"].ToString();

                    if (usuario.Equals(txtusuario.Text.ToUpper()) && contraseña.Equals(txtcontraseña.Text))
                    {
                        Inicio forminicio = new Inicio(txtusuario.Text.ToUpper());
                        forminicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre y/o contraseña no válidos");
                    }
                }
                else
                {
                    MessageBox.Show("Nombre y/o contraseña no válidos");
                }

                conect.Close();

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
