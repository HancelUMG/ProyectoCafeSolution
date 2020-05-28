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
    public partial class ClientesRegistrados : Form
    {
        List<Cliente> lista;
        Cliente objcliente;
        ListViewItem item;

        public ClientesRegistrados()
        {
            InitializeComponent();

            try
            {
                lista = new List<Cliente>();
                objcliente = new Cliente();
                item = new ListViewItem();

                lvClientes.Items.Clear();

                lista = objcliente.Ver();

                foreach(Cliente cliente in lista)
                {
                    item = lvClientes.Items.Add(cliente.Nombre);
                    item.SubItems.Add(cliente.DPI);
                    item.SubItems.Add(cliente.Acumulado);
                    item.SubItems.Add(cliente.Comprado);
                    item.SubItems.Add(cliente.Pendiente);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                lvClientes.Items.Clear();

                lista = objcliente.Buscar(txtBuscarCliente.Text.ToUpper());

                txtBuscarCliente.Clear();

                foreach (Cliente cliente in lista)
                {
                    item = lvClientes.Items.Add(cliente.Nombre);
                    item.SubItems.Add(cliente.DPI);
                    item.SubItems.Add(cliente.Acumulado);
                    item.SubItems.Add(cliente.Comprado);
                    item.SubItems.Add(cliente.Pendiente);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodosCliente_Click(object sender, EventArgs e)
        {
            try
            {
                lvClientes.Items.Clear();

                lista = objcliente.Ver();

                foreach (Cliente cliente in lista)
                {
                    item = lvClientes.Items.Add(cliente.Nombre);
                    item.SubItems.Add(cliente.DPI);
                    item.SubItems.Add(cliente.Acumulado);
                    item.SubItems.Add(cliente.Comprado);
                    item.SubItems.Add(cliente.Pendiente);
                }
            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
