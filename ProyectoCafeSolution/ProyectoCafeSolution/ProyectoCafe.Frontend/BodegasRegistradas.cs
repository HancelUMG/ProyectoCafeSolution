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
    public partial class BodegasRegistradas : Form
    {
        List<Lugar> lista;
        Lugar objlugar;
        ListViewItem item;
        
        public BodegasRegistradas()
        {
            InitializeComponent();
            lista = new List<Lugar>();
            objlugar = new Lugar();
            item = new ListViewItem();

            try
            {
                lista = objlugar.Ver("BODEGA");

                foreach(Lugar lugares in lista)
                {
                    item = lvBodega.Items.Add(lugares.ID);
                    item.SubItems.Add(lugares.Nombre);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BodegasRegistradas_Load(object sender, EventArgs e)
        {

        }
    }
}
