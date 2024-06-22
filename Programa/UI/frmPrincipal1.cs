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
    public partial class frmPrincipal1 : Form
    {
        private static Empleado empleadoLogin;
        public frmPrincipal1(Empleado empleado)
        {
            empleadoLogin = empleado;

            InitializeComponent();
        }

        private void frmPrincipal1_Load(object sender, EventArgs e) 
        {
            lblEmpleadoLogin.Text = empleadoLogin.NombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
