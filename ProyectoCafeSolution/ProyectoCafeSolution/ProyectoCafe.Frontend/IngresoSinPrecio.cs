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
    public partial class IngresoSinPrecio : Form
    {
        string usuario;
        List<Lugar> lista;
        Lugar objlugar;
        Cliente objcliente;

        public IngresoSinPrecio(string pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
            lista = new List<Lugar>();
            objlugar = new Lugar();
            objcliente = new Cliente();

            try
            {
                lista = objlugar.Ver();

                cbxIngresosp.DataSource = lista;

                cbxIngresosp.DisplayMember = "Nombre";

                cbxIngresosp.ValueMember = "ID";

                cbxIngresosp.SelectedItem = null;

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cbxIngresosp.SelectedItem == null)
            {
                MessageBox.Show("Es obligatorio seleccionar un LUGAR de ingreso.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtDPIngresosp.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo DPI del cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEntregasp.Text))
                    {
                        MessageBox.Show("Es obligatorio llenar el campo QUIÉN ENTREGA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtPBsp.Text))
                        {
                            MessageBox.Show("Es obligatorio llenar el campo PESO BRUTO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtTarasp.Text))
                            {
                                MessageBox.Show("Es obligatorio llenar el campo TARA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(lblPesoNeto.Text))
                                {
                                    MessageBox.Show("Debe hacer clic en el botón PESO NETO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    int pb = int.Parse(txtPBsp.Text);
                                    int pn = pb - int.Parse(txtTarasp.Text);

                                    if (pn != int.Parse(lblPesoNeto.Text))
                                    {
                                        MessageBox.Show("El peso neto no coincide con la diferencia entre el peso bruto y la tara.", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            string dpi = txtDPIngresosp.Text;

                                            while (dpi.Contains(" "))
                                            {
                                                dpi = dpi.Replace(" ", "");
                                            }

                                            SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                                            conect.Open();
                                            string select = "select * from cliente where dpi = '" + dpi + "';";
                                            SqlCommand comando = new SqlCommand(select, conect);
                                            SqlDataReader buscar = comando.ExecuteReader();

                                            string idLugar = cbxIngresosp.SelectedValue.ToString();

                                            if (buscar.Read())
                                            {
                                                Ingresosp objingreso = new Ingresosp(txtDPIngresosp.Text, idLugar, txtEntregasp.Text.ToUpper(), txtPBsp.Text, txtTarasp.Text, lblPesoNeto.Text, usuario);
                                                objingreso.Agregar();

                                                int actual = int.Parse(objcliente.getAcumulado(txtDPIngresosp.Text));
                                                int agregado = int.Parse(lblPesoNeto.Text);
                                                int nuevo = actual + agregado;

                                                objcliente.setAcumulado(nuevo.ToString(), txtDPIngresosp.Text);

                                                MessageBox.Show("Nuevo ingreso AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                cbxIngresosp.SelectedItem = null;
                                                txtDPIngresosp.Clear();
                                                txtEntregasp.Clear();
                                                txtPBsp.Clear();
                                                txtTarasp.Clear();
                                                lblPesoNeto.Text = null;
                                            }
                                            else
                                            {
                                                MessageBox.Show("El cliente ingresado no aparece registrado. \nPara continuar ingrese los datos del nuevo cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }

                                            conect.Close();

                                        }
                                        catch (Exception error)
                                        {
                                            MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbxIngresosp.SelectedItem = null;
            txtDPIngresosp.Clear();
            txtEntregasp.Clear();
            txtPBsp.Clear();
            txtTarasp.Clear();
            lblPesoNeto.Text = null;
        }

        private void btnPesoNeto_Click(object sender, EventArgs e)
        {
            int pb = int.Parse(txtPBsp.Text);
            int tara = int.Parse(txtTarasp.Text);

            lblPesoNeto.Text = Convert.ToString(pb - tara);
        }

        private void txtDPIngresosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPBsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTarasp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
