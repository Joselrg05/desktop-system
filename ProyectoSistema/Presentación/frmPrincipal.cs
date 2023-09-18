using ProyectoSistema.Presentación;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoSistema
{
    public partial class frmPrincipal : Form
    {

        public Form frmActivo;

        public frmPrincipal()
        {
            InitializeComponent();
            ComponentDesing();
        }

        private void ComponentDesing ()
        {
            PanelSubMenuCompras.Visible = false;
            PanelSubmenuVentas.Visible = false;
            //PanelSubmenuReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelSubMenuCompras.Visible == true)
                PanelSubMenuCompras.Visible = false;
            if (PanelSubmenuVentas.Visible == true)
                PanelSubmenuVentas.Visible = false;
            //...
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
       
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void LoadForm(object frmChild)
        {
            if (frmActivo != null)
                frmActivo.Close();
            frmActivo = (Form)frmChild;
            frmActivo.TopLevel = false;
            frmActivo.FormBorderStyle = FormBorderStyle.None;
            frmActivo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(frmActivo);
            PanelContenedor.Tag = frmActivo;
            frmActivo.BringToFront();
            frmActivo.Show();
            frmActivo = null;
        }

        private void iconBtnProducto_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                this.LoadForm(new frmProducto());
            }
            else
                this.LoadForm(new frmProducto());
        }

        private void iconBtnCompras_Click(object sender, EventArgs e)
        {
            //...
            // Code
            showSubMenu(PanelSubMenuCompras);
        }

        private void iconBtnRgtCompra_Click(object sender, EventArgs e)
        {
            //...
            // Code
            hideSubMenu();
        }

        private void iconBtnDetalleCompra_Click(object sender, EventArgs e)
        {
            //...
            // Code
            hideSubMenu();
        }

        private void iconBtnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubmenuVentas);
        }

        private void iconBtnRgtVentas_Click(object sender, EventArgs e)
        {
            //:...
            hideSubMenu();
        }

        private void iconBtnDetalleVenta_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }
    }
}
