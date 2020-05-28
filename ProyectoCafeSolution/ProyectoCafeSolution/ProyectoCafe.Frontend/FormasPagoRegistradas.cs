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
    public partial class FormasPagoRegistradas : Form
    {
        List<FormaPago> lista;
        FormaPago objforma;
        ListViewItem item;

        public FormasPagoRegistradas()
        {
            InitializeComponent();
            lista = new List<FormaPago>();
            objforma = new FormaPago();
            item = new ListViewItem();

            try
            {
                lista = objforma.Ver();

                foreach(FormaPago formas in lista)
                {
                    item = lvFormaPago.Items.Add(formas.ID);
                    item.SubItems.Add(formas.Descripcion);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormasPagoRegistradas_Load(object sender, EventArgs e)
        {

        }
    }
}
