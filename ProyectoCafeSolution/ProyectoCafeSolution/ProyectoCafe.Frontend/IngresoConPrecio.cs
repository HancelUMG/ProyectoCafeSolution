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
    public partial class IngresoConPrecio : Form
    {
        string usuario;
        List<Lugar> lista;
        Lugar objlugar;
        Cliente objcliente;
        List<FormaPago> listafp;
        FormaPago objformapago;

        public IngresoConPrecio(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lista = new List<Lugar>();
            objlugar = new Lugar();
            objcliente = new Cliente();
            listafp = new List<FormaPago>();
            objformapago = new FormaPago();

            try
            {
                lista = objlugar.Ver();
                cbxIngresocp.DataSource = lista;
                cbxIngresocp.DisplayMember = "Nombre";
                cbxIngresocp.ValueMember = "ID";
                cbxIngresocp.SelectedItem = null;

                listafp = objformapago.Ver();
                cbxFormaPago.DisplayMember = "Descripcion";
                cbxFormaPago.ValueMember = "ID";
                cbxFormaPago.DataSource = listafp;
                cbxFormaPago.SelectedItem = null;

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnIngresarcp_Click(object sender, EventArgs e)
        {
            if (cbxIngresocp.SelectedValue == null)
            {
                MessageBox.Show("Es obligatorio seleccionar un LUGAR de ingreso.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtDPIngresocp.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo DPI del cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEntregacp.Text))
                    {
                        MessageBox.Show("Es obligatorio llenar el campo QUIÉN ENTREGA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtPBcp.Text))
                        {
                            MessageBox.Show("Es obligatorio llenar el campo PESO BRUTO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtTaracp.Text))
                            {
                                MessageBox.Show("Es obligatorio llenar el campo TARA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(lblPesoNeto.Text))
                                {
                                    MessageBox.Show("Debe hacer clic en el campo PESO NETO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtQ.Text))
                                    {
                                        MessageBox.Show("Es obligatorio llenar el campo QUETZALES.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtCtv.Text))
                                        {
                                            MessageBox.Show("Es obligatorio llenar el campo CENTAVOS.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        else
                                        {
                                            if(int.Parse(txtQ.Text)>=10 || int.Parse(txtQ.Text) <= 0)
                                            {
                                                MessageBox.Show("Debe pedir autorización para ingresar este precio.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                            else
                                            {
                                                if (int.Parse(txtCtv.Text) > 99 || int.Parse(txtCtv.Text) < 10)
                                                {
                                                    MessageBox.Show("Debe ingresar una cifra de 2 digitos en el campo CENTAVOS.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                                else
                                                {
                                                    int pb = int.Parse(txtPBcp.Text);
                                                    int pn = pb - int.Parse(txtTaracp.Text);

                                                    if (pn != int.Parse(lblPesoNeto.Text))
                                                    {
                                                        MessageBox.Show("El peso neto no coincide con la diferencia entre el peso bruto y la tara.", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                    }
                                                    else
                                                    {
                                                        if (cbxFormaPago.SelectedItem == null)
                                                        {
                                                            MessageBox.Show("Debe seleccionar una FORMA DE PAGO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        }
                                                        else
                                                        {
                                                            if (cbxFormaPago.Text != "EFECTIVO" && cbxBanco.SelectedItem == null)
                                                            {
                                                                MessageBox.Show("Debe seleccionar un BANCO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            }
                                                            else
                                                            {
                                                                try
                                                                {
                                                                    string dpi = txtDPIngresocp.Text;

                                                                    while (dpi.Contains(" "))
                                                                    {
                                                                        dpi = dpi.Replace(" ", "");
                                                                    }

                                                                    SqlConnection conect = new SqlConnection("server = MBETANCOURT; database = cafedb; integrated security = true");
                                                                    conect.Open();
                                                                    string select = "select * from cliente where dpi = '" + dpi + "';";
                                                                    SqlCommand comando = new SqlCommand(select, conect);
                                                                    SqlDataReader buscar = comando.ExecuteReader();

                                                                    string idLugar = cbxIngresocp.SelectedValue.ToString();
                                                                    string idFormaPago = cbxFormaPago.SelectedValue.ToString();
                                                                    string cuenta;

                                                                    if(cbxBanco.SelectedValue == null)
                                                                    {
                                                                        cuenta = "";
                                                                    }
                                                                    else
                                                                    {
                                                                        cuenta = cbxBanco.SelectedValue.ToString();
                                                                    }

                                                                    if (buscar.Read())
                                                                    {
                                                                        Ingresocp objingreso = new Ingresocp(txtDPIngresocp.Text, idLugar, txtEntregacp.Text.ToUpper(), txtPBcp.Text, txtTaracp.Text, lblPesoNeto.Text, txtQ.Text + "." + txtCtv.Text, idFormaPago, cuenta, usuario);
                                                                        objingreso.Agregar();

                                                                        MessageBox.Show("Nuevo ingreso AGREGADO con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        cbxIngresocp.SelectedItem = null;
                                                                        txtDPIngresocp.Clear();
                                                                        txtEntregacp.Clear();
                                                                        txtPBcp.Clear();
                                                                        txtTaracp.Clear();
                                                                        txtQ.Clear();
                                                                        txtCtv.Clear();
                                                                        lblPesoNeto.Text = null;
                                                                        lblTotal.Text = "0.00";
                                                                        cbxFormaPago.SelectedItem = null;
                                                                        cbxBanco.DataSource = null;

                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("El cliente ingresado no aparece registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            }
                        }
                    }
                }
            }
        }

        private void btnPesoNeto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPBcp.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo PESO BRUTO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtTaracp.Text))
                {
                    MessageBox.Show("Es obligatorio llenar el campo TARA.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int pb = int.Parse(txtPBcp.Text);
                    int tara = int.Parse(txtTaracp.Text);

                    lblPesoNeto.Text = Convert.ToString(pb - tara);
                }
            }
        }

        private void btnCancelarcp_Click(object sender, EventArgs e)
        {
            cbxIngresocp.SelectedItem = null;
            txtDPIngresocp.Clear();
            txtEntregacp.Clear();
            txtPBcp.Clear();
            txtTaracp.Clear();
            txtQ.Clear();
            txtCtv.Clear();
            lblPesoNeto.Text = null;
            lblTotal.Text = "0.00";
            cbxFormaPago.SelectedItem = null;
        }

        private void txtQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDPIngresocp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDPIngresocp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPBcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTaracp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPNcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPesoNeto.Text))
            {
                MessageBox.Show("Antes debe presionar el botón PESO NETO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQ.Clear();
            }
            else
            {
                if (string.IsNullOrEmpty(txtQ.Text))
                {
                    if (string.IsNullOrEmpty(txtCtv.Text))
                    {
                        lblTotal.Text = "0.00";
                    }
                    else
                    {
                        decimal total = (decimal.Parse(txtCtv.Text) / 100) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCtv.Text))
                    {
                        decimal total = decimal.Parse(txtQ.Text) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                    else
                    {
                        decimal total = (decimal.Parse(txtQ.Text) + (decimal.Parse(txtCtv.Text) / 100)) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
            }

        }

        private void txtCtv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPesoNeto.Text))
            {
                MessageBox.Show("Antes debe presionar el botón PESO NETO.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCtv.Clear();
            }
            else
            {
                if (string.IsNullOrEmpty(txtCtv.Text))
                {
                    if (string.IsNullOrEmpty(txtQ.Text))
                    {
                        lblTotal.Text = "0.00";
                    }
                    else
                    {
                        decimal total = decimal.Parse(txtQ.Text) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtQ.Text))
                    {
                        decimal total = (decimal.Parse(txtCtv.Text) / 100) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                    else
                    {
                        decimal total = (decimal.Parse(txtQ.Text) + (decimal.Parse(txtCtv.Text) / 100)) * int.Parse(lblPesoNeto.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
            }
        }

        private void cbxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFormaPago.SelectedItem == null || cbxFormaPago.Text.Equals("EFECTIVO"))
            {
                cbxBanco.DataSource = null;
            }
            else
            {
                try
                {
                    List<Banco> lista = new List<Banco>();
                    Banco objbanco = new Banco();
                    lista = objbanco.ver();
                    cbxBanco.DisplayMember = "Nombre";
                    cbxBanco.ValueMember = "Cuenta";
                    cbxBanco.DataSource = lista;
                    cbxBanco.SelectedItem = null;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
