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
    public partial class BeneficiosRegistrados : Form
    {
        List<Lugar> lista;
        Lugar objlugar;
        ListViewItem item;

        public BeneficiosRegistrados()
        {
            InitializeComponent();
            lista = new List<Lugar>();
            objlugar = new Lugar();
            item = new ListViewItem();

            try
            {
                lista = objlugar.Ver("BENEFICIO");

                foreach(Lugar lugares in lista)
                {
                    item = lvBeneficio.Items.Add(lugares.ID);
                    item.SubItems.Add(lugares.Nombre);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BeneficiosRegistrados_Load(object sender, EventArgs e)
        {

        }
    }
}
