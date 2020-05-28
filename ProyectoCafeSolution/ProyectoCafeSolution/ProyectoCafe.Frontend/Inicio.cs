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
    public partial class Inicio : Form
    {
        string usuario;

        public Inicio(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosRegistrados usuariosRegistrados = new UsuariosRegistrados();
            usuariosRegistrados.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.Show();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientesRegistrados clientesRegistrados = new ClientesRegistrados();
            clientesRegistrados.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevaBodega nuevaBodega = new NuevaBodega();
            nuevaBodega.Show();
        }

        private void verToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BodegasRegistradas bodegasRegistradas = new BodegasRegistradas();
            bodegasRegistradas.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoBeneficio nuevoBeneficio = new NuevoBeneficio();
            nuevoBeneficio.Show();
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BeneficiosRegistrados beneficiosRegistrados = new BeneficiosRegistrados();
            beneficiosRegistrados.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevaFormaPago formaPago = new NuevaFormaPago();
            formaPago.Show();
        }

        private void verToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormasPagoRegistradas formasPago = new FormasPagoRegistradas();
            formasPago.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NuevoBanco nuevoBanco = new NuevoBanco();
            nuevoBanco.Show();
        }

        private void verToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BancosRegistrados bancosRegistrados = new BancosRegistrados();
            bancosRegistrados.Show();
        }

        private void sinPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoSinPrecio sinPrecio = new IngresoSinPrecio(usuario);
            sinPrecio.Show();
        }

        private void verIngresosSinPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresosSPRegistrados registrados = new IngresosSPRegistrados();
            registrados.Show();
        }

        private void ingresoConPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoConPrecio conPrecio = new IngresoConPrecio(usuario);
            conPrecio.Show();
        }

        private void verIngresosConPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresosCPRegistrados ingresosCP = new IngresosCPRegistrados();
            ingresosCP.Show();
        }

        private void postCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostCompra postCompra = new PostCompra(usuario);
            postCompra.Show();
        }
    }
}
