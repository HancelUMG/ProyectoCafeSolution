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
    public partial class UsuariosRegistrados : Form
    {
        List<Usuario> lista;
        Usuario objusuario;
        ListViewItem item;

        public UsuariosRegistrados()
        {
            InitializeComponent();

            try
            {
                lista = new List<Usuario>();
                objusuario = new Usuario();
                item = new ListViewItem();

                lvUsuarios.Items.Clear();

                lista = objusuario.Ver();

                foreach (Usuario usuario in lista)
                {
                    item = lvUsuarios.Items.Add(usuario.Nombre);
                    item.SubItems.Add(usuario.NomUsuario);
                }
            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosRegistrados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                lvUsuarios.Items.Clear();

                lista = objusuario.Buscar(txtBuscarUsuario.Text.ToUpper());

                txtBuscarUsuario.Clear();

                foreach (Usuario usuario in lista)
                {
                    item = lvUsuarios.Items.Add(usuario.Nombre);
                    item.SubItems.Add(usuario.NomUsuario);
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodosUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                txtBuscarUsuario.Clear();

                lvUsuarios.Items.Clear();

                lista = objusuario.Ver();

                foreach (Usuario usuario in lista)
                {
                    item = lvUsuarios.Items.Add(usuario.Nombre);
                    item.SubItems.Add(usuario.NomUsuario);
                }
            }catch(Exception error)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
