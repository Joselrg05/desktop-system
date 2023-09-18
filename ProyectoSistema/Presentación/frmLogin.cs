using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistema.Presentación
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void iconBtnIngresar_Click(object sender, EventArgs e)
        {
            //Instanciamos un objeto de tipo formulario principal
            frmPrincipal formulario = new frmPrincipal();
            //Mostramos dicho formulario
            formulario.Show();
            //Esta linea de código oculta formulario de log-in...
            this.Hide();

            //Aquí lo que estamos haciendo es que a la hora de cerrar el sistema
            //vuelva a mostrarse el formulario de log-in...
            formulario.FormClosing += FrmCerrar;
        }

        private void LimpiarCajas()
        {
            txtBoxUsuario.Text = " ";
            txtBoxPassword.Text = " ";
        }

        private void FrmCerrar (object sender, FormClosingEventArgs e)
        {
            LimpiarCajas();
            this.Show();
        }

    }
}
