using ProyectoSistema.Controlador;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace ProyectoSistema.Presentación
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

       
        //private void iconBtnGuardarProducto_Click(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        if (!VerificarVacios())
        //        {

        //            int rst = ctrlProducto.GuardarProducto(txtCodigoProducto.Text.ToUpper(), txtNombreProducto.Text.ToUpper(), 
        //                    txtDescrProducto.Text.ToUpper(), checkedListBoxEstado.CheckOnClick.ToString(), comboBoxCategoría.Text.ToUpper());

        //            if (rst > 0)
        //                MessageBox.Show("El registro del producto ha sido guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            Limpiar();
        //            txtCodigoProducto.ReadOnly = false;

        //        }
        //        else
        //            MessageBox.Show("Debe completar todos los campos para \ningresar el nuevo producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //    }
        //    catch (ArgumentException arg)
        //    {

        //        MessageBox.Show("Se ha producido una falla al ejecutar \n" + "la accion guardar: " + arg.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (InvalidOperationException inv)
        //    {
        //        MessageBox.Show("Se ha producido una falla al ejecutar \n" + "la accion guardar: " + inv.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    catch (DbUpdateException db)
        //    {
        //        MessageBox.Show("Se ha producido una falla al ejecutar \n" + "la accion guardar: " + db.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}//fin el metodo

        private void Limpiar()
        {

            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescrProducto.Clear();
            checkedListBoxEstado.Items.Clear();
            comboBoxCategoría.Items.Clear();
            textBoxListarProducto.Clear();
        }

        private bool VerificarVacios()
        {
            bool resultado = true;
            if (!string.IsNullOrEmpty(txtCodigoProducto.Text) && !string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtDescrProducto.Text)
                        && !string.IsNullOrEmpty(checkedListBoxEstado.Text) && !string.IsNullOrEmpty(comboBoxCategoría.SelectedIndex.ToString()))
                resultado = false;
            return resultado;
        }
    }
}
