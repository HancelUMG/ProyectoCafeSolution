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
    public partial class BancosRegistrados : Form
    {
        List<Banco> lista;
        Banco objbanco;
        ListViewItem item;

        public BancosRegistrados()
        {
            InitializeComponent();
            lista = new List<Banco>();
            objbanco = new Banco();
            item = new ListViewItem();

            try
            {
                lista = objbanco.ver();

                foreach(Banco banco in lista)
                {
                    item = lvBancos.Items.Add(banco.ID);
                    item.SubItems.Add(banco.Nombre);
                    item.SubItems.Add(banco.Cuenta);
                }

            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BancosRegistrados_Load(object sender, EventArgs e)
        {

        }
    }
}
