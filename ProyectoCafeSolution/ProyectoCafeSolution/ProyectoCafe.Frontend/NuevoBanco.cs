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
    public partial class NuevoBanco : Form
    {
        public NuevoBanco()
        {
            InitializeComponent();
        }

        private void btnAgregarBanco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreBanco.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo NOMBRE.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtCuenta.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo CUENTA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string cuenta = txtCuenta.Text;

                        while (cuenta.Contains(" "))
                        {
                            cuenta = cuenta.Replace(" ", "");
                        }

                        SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                        conect.Open();
                        string select = "select * from banco where cuenta = '" + cuenta + "';";
                        SqlCommand comando = new SqlCommand(select, conect);
                        SqlDataReader buscar = comando.ExecuteReader();

                        if (buscar.Read())
                        {
                            MessageBox.Show("La cuenta ingresada ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Banco objbanco = new Banco(txtNombreBanco.Text.ToUpper(), cuenta);

                            try
                            {
                                objbanco.Agregar();
                                MessageBox.Show("Nuevo banco AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombreBanco.Clear();
                                txtCuenta.Clear();
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
}
