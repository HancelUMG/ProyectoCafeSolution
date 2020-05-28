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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo NOMBRE.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo USUARIO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        MessageBox.Show("Es obligatorio llenar el campo CONTRASEÑA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                            conect.Open();
                            string cadena = "select * from usuario where id_usuario = '" + txtUsuario.Text + "';";
                            SqlCommand select = new SqlCommand(cadena, conect);
                            SqlDataReader buscar = select.ExecuteReader();

                            if (buscar.Read())
                            {
                                MessageBox.Show("El ID de usuario ingresado ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Usuario objusuario = new Usuario(txtNombre.Text.ToUpper(), txtUsuario.Text.ToUpper(), txtContraseña.Text);

                                try
                                {
                                    objusuario.Agregar();
                                    MessageBox.Show("Nuevo usuario AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtNombre.Clear();
                                    txtUsuario.Clear();
                                    txtContraseña.Clear();

                                }
                                catch (Exception error)
                                {
                                    MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch(Exception error)
                        {
                            MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }  
                        
                    }
                }
            }
            
        }

    }
}
