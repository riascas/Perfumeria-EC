using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Empleado> Test = new Empleado().Listado();

            Empleado Empleados = new Empleado().Listado().Where(e => e.NombreUsuario == tboxUsuario.Text && e.Clave == tboxClave.Text).FirstOrDefault(); 

            if (Empleados != null)
            {
                frmPrincipal1 principal = new frmPrincipal1(Empleados);

                principal.Show();
                this.Hide();

                principal.FormClosing += frm_closing;
            }
            else 
            {
                MessageBox.Show("El Empleado ingresado no esta registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private void frm_closing(object sender, EventArgs e)
        {
            tboxUsuario.Text = "";
            tboxClave.Text = "";


            this.Show();
        }
    }
}
