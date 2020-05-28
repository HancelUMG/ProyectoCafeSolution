using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectoCafe.Backend;

namespace ProyectoCafe.Frontend
{
    public partial class NuevoBeneficio : Form
    {
        public NuevoBeneficio()
        {
            InitializeComponent();
        }

        private void btnAgregarBen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreBen.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo NOMBRE.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                    conect.Open();
                    string select = "select * from lugar where nombre_lugar = '" + txtNombreBen.Text + "';";
                    SqlCommand comando = new SqlCommand(select, conect);
                    SqlDataReader buscar = comando.ExecuteReader();

                    if (buscar.Read())
                    {
                        MessageBox.Show("El nombre ingresado ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Lugar objlugar = new Lugar(txtNombreBen.Text.ToUpper(), "BENEFICIO");
                        try
                        {
                            objlugar.Agregar();
                            MessageBox.Show("Nuevo beneficio AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombreBen.Clear();
                        }
                        catch(Exception error)
                        {
                            MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conect.Close();

                }catch (Exception error)
                {
                    MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
