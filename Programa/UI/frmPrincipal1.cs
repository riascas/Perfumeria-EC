using BLL;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmPrincipal1 : Form
    {
        private static Empleado empleadoLogin;
        private static IconMenuItem MenuActual = null;
        private static Form PantallaActual = null;

        public frmPrincipal1(Empleado empleado)
        {
            empleadoLogin = empleado;

            InitializeComponent();
        }

        private void frmPrincipal1_Load(object sender, EventArgs e)
        {
            lblEmpleadoLogin.Text = empleadoLogin.NombreUsuario;
        }

        private void AbrirPantalla(IconMenuItem menu, Form pantalla)
        {
            if (MenuActual != null)
            {
                MenuActual.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActual = menu;

            if (PantallaActual != null)
            {
                PantallaActual.Close();
            }

            PantallaActual = pantalla;
            pantalla.TopLevel = false;
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.Dock = DockStyle.Fill;
            pantalla.BackColor = Color.SteelBlue;
            panelPantalla.Controls.Add(pantalla);
            pantalla.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoABM, new frmCategoria());
        }

        private void iconoEmpleados_Click(object sender, EventArgs e)
        {
            AbrirPantalla((IconMenuItem)sender, new frmEmpleados());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoABM, new frmProducto());
        }

        private void iconoVenta_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoVenta, new frmVentas());
        }

        private void iconoCompra_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoCompra, new frmCompras());
        }

        private void iconoCliente_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoCliente, new frmClientes());
        }

        private void iconoProveedor_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoProveedor, new frmProveedores());
        }

        private void iconoReporte_Click(object sender, EventArgs e)
        {
            AbrirPantalla(iconoReporte, new frmReportes());
        }
    }
}
