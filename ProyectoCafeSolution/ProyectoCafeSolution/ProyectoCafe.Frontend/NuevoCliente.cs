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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarClie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreClie.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo NOMBRE.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtDPI.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo DPI.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string dpi = txtDPI.Text;

                        while(dpi.Contains(" "))
                        {
                            dpi = dpi.Replace(" ","");
                        }

                        SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                        conect.Open();
                        string select = "select * from cliente where dpi = '" + dpi + "';";
                        SqlCommand comando = new SqlCommand(select, conect);
                        SqlDataReader buscar = comando.ExecuteReader();

                        if (buscar.Read())
                        {
                            MessageBox.Show("El cliente ingresado ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Cliente objcliente = new Cliente(dpi, txtNombreClie.Text.ToUpper());

                            try
                            {
                                objcliente.Agregar();
                                MessageBox.Show("Nuevo usuario AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombreClie.Clear();
                                txtDPI.Clear();
                            }
                            catch(Exception error)
                            {
                                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        conect.Close();
                    }catch(Exception error)
                    {
                        MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelClie_Click(object sender, EventArgs e)
        {
            txtNombreClie.Clear();
            txtDPI.Clear();
        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
