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
    public partial class NuevaFormaPago : Form
    {
        public NuevaFormaPago()
        {
            InitializeComponent();
        }

        private void btnCancelFP_Click(object sender, EventArgs e)
        {
            txtNombreFP.Clear();
        }

        private void btnAgregarFP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreFP.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo DESCRIPCIÓN.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                    conect.Open();
                    string select = "select * from formapago where descripcion = '" + txtNombreFP.Text + "';";
                    SqlCommand comando = new SqlCommand(select, conect);
                    SqlDataReader buscar = comando.ExecuteReader();

                    if (buscar.Read())
                    {
                        MessageBox.Show("El registro ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FormaPago objforma = new FormaPago(txtNombreFP.Text.ToUpper());

                        try
                        {
                            objforma.Agregar();
                            MessageBox.Show("Nueva forma de pago AGREGADA con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombreFP.Clear();

                        }
                        catch(Exception error)
                        {
                            MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conect.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
