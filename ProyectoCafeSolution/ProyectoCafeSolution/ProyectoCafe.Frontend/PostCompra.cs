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

namespace ProyectoCafe.Frontend
{
    public partial class PostCompra : Form
    {
        string usuario;
        Cliente objcliente;
        Lugar objlugar;
        FormaPago objformapago;
        Banco objbanco;
        
        public PostCompra(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            objcliente = new Cliente();
            objlugar = new Lugar();
            objformapago = new FormaPago();
            objbanco = new Banco();
            lblAcumClie.Text = "";

            try
            {
                cbxLugar.DataSource = objlugar.Ver();
                cbxLugar.DisplayMember = "Nombre";
                cbxLugar.ValueMember = "ID";
                cbxLugar.SelectedItem = null;

                cbxFormaPago.DataSource = objformapago.Ver();
                cbxFormaPago.DisplayMember = "Descripcion";
                cbxFormaPago.ValueMember = "ID";
                cbxFormaPago.SelectedItem = null;

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtDPI.Text.Length == 12)
                {
                    lblNomClie.Text = objcliente.getNombre(txtDPI.Text);
                    lblAcumClie.Text = objcliente.getAcumulado(txtDPI.Text);
                }
                else
                {
                    lblNomClie.Text = null;
                    lblAcumClie.Text = null;
                }

                if(txtDPI.Text.Length == 13 && string.IsNullOrEmpty(lblNomClie.Text))
                {
                    MessageBox.Show("El cliente ingresado no aparece registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDPI.Clear();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompra.Text))
            {
                MessageBox.Show("Antes debe ingresar la cantidad en libras a comprar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        decimal total = (decimal.Parse(txtCtv.Text) / 100) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCtv.Text))
                    {
                        decimal total = decimal.Parse(txtQ.Text) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                    else
                    {
                        decimal total = (decimal.Parse(txtQ.Text) + (decimal.Parse(txtCtv.Text) / 100)) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
            }
        }

        private void txtCtv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompra.Text))
            {
                MessageBox.Show("Antes debe ingresar la cantidad en libras a comprar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        decimal total = decimal.Parse(txtQ.Text) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtQ.Text))
                    {
                        decimal total = (decimal.Parse(txtCtv.Text) / 100) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                    else
                    {
                        decimal total = (decimal.Parse(txtQ.Text) + (decimal.Parse(txtCtv.Text) / 100)) * int.Parse(txtCompra.Text);

                        lblTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
            }
        }

        private void txtCompra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompra.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad de libras a comprar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(lblAcumClie.Text))
                {
                    MessageBox.Show("Faltan los datos del cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCompra.Clear();
                }
                else
                {
                    if (int.Parse(txtCompra.Text) > int.Parse(lblAcumClie.Text))
                    {
                        MessageBox.Show("La cantidad ingresada supera la cantidad registrada en el sistema.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCompra.Clear();
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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDPI.Text))
            {
                MessageBox.Show("Es obligatorio llenar el campo DPI Del Cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(cbxLugar.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar el LUGAR donde se realiza la compra.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCompra.Text))
                    {
                        MessageBox.Show("Es obligatorio ingresar la cantidad de libras a comprar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                if(int.Parse(txtQ.Text) >= 10 || int.Parse(txtQ.Text) <= 0)
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
                                                    int acum = int.Parse(objcliente.getAcumulado(txtDPI.Text));
                                                    int pend = acum - int.Parse(txtCompra.Text);

                                                    string banco;

                                                    if(cbxBanco.SelectedValue == null)
                                                    {
                                                        banco = "";
                                                    }
                                                    else
                                                    {
                                                        banco = cbxBanco.SelectedValue.ToString();
                                                    }

                                                    Compra objcompra = new Compra(txtDPI.Text, cbxFormaPago.SelectedValue.ToString(), banco, acum.ToString(), txtCompra.Text, txtQ.Text + "." + txtCtv.Text, pend.ToString(), cbxLugar.SelectedValue.ToString(), usuario);
                                                    objcompra.Agregar();

                                                    int actual = int.Parse(objcliente.getAcumulado(txtDPI.Text));
                                                    int comprado = int.Parse(txtCompra.Text);
                                                    int acumulado = actual - comprado;

                                                    objcliente.setAcumulado(acumulado.ToString(), txtDPI.Text);

                                                    int actualcomprado = int.Parse(objcliente.getComprado(txtDPI.Text));
                                                    int agregado = int.Parse(txtCompra.Text);
                                                    int nuevo = actualcomprado + agregado;

                                                    objcliente.setComprado(nuevo.ToString(), txtDPI.Text);

                                                    MessageBox.Show("La compra se ha registrado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    txtDPI.Clear();
                                                    cbxLugar.SelectedItem = null;
                                                    txtQ.Clear();
                                                    txtCtv.Clear();
                                                    txtCompra.Clear();
                                                    lblNomClie.Text = null;
                                                    lblAcumClie.Text = null;
                                                    lblTotal.Text = "0.00";
                                                    cbxFormaPago.SelectedItem = null;
                                                    cbxBanco.DataSource = null;
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
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDPI.Clear();
            cbxLugar.SelectedItem = null;
            txtQ.Clear();
            txtCtv.Clear();
            txtCompra.Clear();
            lblNomClie.Text = null;
            lblAcumClie.Text = null;
            lblTotal.Text = "0.00";
            cbxFormaPago.SelectedItem = null;
            cbxBanco.DataSource = null;
        }
    }
}
