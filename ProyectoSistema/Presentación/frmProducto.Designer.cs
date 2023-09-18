
namespace ProyectoSistema.Presentación
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconBtnProductoPdf = new FontAwesome.Sharp.IconButton();
            this.iconBtnProductoExcel = new FontAwesome.Sharp.IconButton();
            this.comboBoxCategoría = new System.Windows.Forms.ComboBox();
            this.grpbxPnlProducto = new System.Windows.Forms.GroupBox();
            this.checkedListBoxEstado = new System.Windows.Forms.CheckedListBox();
            this.iconBtnCancelarProducto = new FontAwesome.Sharp.IconButton();
            this.iconBtnLimpiarProducto = new FontAwesome.Sharp.IconButton();
            this.iconBtnGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescrProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.iconBntLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBtnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.comboBoxFiltroProducto = new System.Windows.Forms.ComboBox();
            this.lblBuscarProd = new System.Windows.Forms.Label();
            this.textBoxListarProducto = new System.Windows.Forms.TextBox();
            this.dataGridViewListProd = new System.Windows.Forms.DataGridView();
            this.panelFileDown = new System.Windows.Forms.Panel();
            this.iconBtnFileCvs = new FontAwesome.Sharp.IconButton();
            this.iconBtnPDF = new FontAwesome.Sharp.IconButton();
            this.grpbxPnlProducto.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProd)).BeginInit();
            this.panelFileDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconBtnProductoPdf
            // 
            this.iconBtnProductoPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnProductoPdf.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnProductoPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconBtnProductoPdf.IconColor = System.Drawing.Color.DarkRed;
            this.iconBtnProductoPdf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnProductoPdf.IconSize = 22;
            this.iconBtnProductoPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnProductoPdf.Location = new System.Drawing.Point(730, 518);
            this.iconBtnProductoPdf.Name = "iconBtnProductoPdf";
            this.iconBtnProductoPdf.Size = new System.Drawing.Size(127, 31);
            this.iconBtnProductoPdf.TabIndex = 9;
            this.iconBtnProductoPdf.Text = "Descargar PDF";
            this.iconBtnProductoPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnProductoPdf.UseVisualStyleBackColor = false;
            // 
            // iconBtnProductoExcel
            // 
            this.iconBtnProductoExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnProductoExcel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnProductoExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnProductoExcel.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnProductoExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnProductoExcel.IconSize = 22;
            this.iconBtnProductoExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnProductoExcel.Location = new System.Drawing.Point(883, 518);
            this.iconBtnProductoExcel.Name = "iconBtnProductoExcel";
            this.iconBtnProductoExcel.Size = new System.Drawing.Size(139, 31);
            this.iconBtnProductoExcel.TabIndex = 8;
            this.iconBtnProductoExcel.Text = "Descargar Excel";
            this.iconBtnProductoExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnProductoExcel.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategoría
            // 
            this.comboBoxCategoría.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategoría.BackColor = System.Drawing.Color.White;
            this.comboBoxCategoría.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoría.FormattingEnabled = true;
            this.comboBoxCategoría.Items.AddRange(new object[] {
            "Sistema Eléctrico",
            "Sistema de Suspensión",
            "Sistema de Motor",
            "Repuesto Básicos",
            "Sistema de Encendido",
            "SISTEMA DE fRENOPS"});
            this.comboBoxCategoría.Location = new System.Drawing.Point(17, 301);
            this.comboBoxCategoría.Name = "comboBoxCategoría";
            this.comboBoxCategoría.Size = new System.Drawing.Size(216, 27);
            this.comboBoxCategoría.TabIndex = 11;
            // 
            // grpbxPnlProducto
            // 
            this.grpbxPnlProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpbxPnlProducto.Controls.Add(this.checkedListBoxEstado);
            this.grpbxPnlProducto.Controls.Add(this.comboBoxCategoría);
            this.grpbxPnlProducto.Controls.Add(this.iconBtnCancelarProducto);
            this.grpbxPnlProducto.Controls.Add(this.iconBtnLimpiarProducto);
            this.grpbxPnlProducto.Controls.Add(this.iconBtnGuardarProducto);
            this.grpbxPnlProducto.Controls.Add(this.label8);
            this.grpbxPnlProducto.Controls.Add(this.label7);
            this.grpbxPnlProducto.Controls.Add(this.label4);
            this.grpbxPnlProducto.Controls.Add(this.label3);
            this.grpbxPnlProducto.Controls.Add(this.label2);
            this.grpbxPnlProducto.Controls.Add(this.txtDescrProducto);
            this.grpbxPnlProducto.Controls.Add(this.txtNombreProducto);
            this.grpbxPnlProducto.Controls.Add(this.txtCodigoProducto);
            this.grpbxPnlProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbxPnlProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxPnlProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPnlProducto.Location = new System.Drawing.Point(0, 0);
            this.grpbxPnlProducto.Name = "grpbxPnlProducto";
            this.grpbxPnlProducto.Size = new System.Drawing.Size(252, 499);
            this.grpbxPnlProducto.TabIndex = 13;
            this.grpbxPnlProducto.TabStop = false;
            this.grpbxPnlProducto.Text = "Detalle del producto";
            // 
            // checkedListBoxEstado
            // 
            this.checkedListBoxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxEstado.BackColor = System.Drawing.Color.White;
            this.checkedListBoxEstado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxEstado.FormattingEnabled = true;
            this.checkedListBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.checkedListBoxEstado.Location = new System.Drawing.Point(17, 239);
            this.checkedListBoxEstado.Name = "checkedListBoxEstado";
            this.checkedListBoxEstado.Size = new System.Drawing.Size(216, 25);
            this.checkedListBoxEstado.TabIndex = 36;
            // 
            // iconBtnCancelarProducto
            // 
            this.iconBtnCancelarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCancelarProducto.BackColor = System.Drawing.Color.DarkRed;
            this.iconBtnCancelarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnCancelarProducto.FlatAppearance.BorderSize = 0;
            this.iconBtnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCancelarProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCancelarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnCancelarProducto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnCancelarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnCancelarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelarProducto.IconSize = 20;
            this.iconBtnCancelarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCancelarProducto.Location = new System.Drawing.Point(19, 437);
            this.iconBtnCancelarProducto.Name = "iconBtnCancelarProducto";
            this.iconBtnCancelarProducto.Size = new System.Drawing.Size(216, 34);
            this.iconBtnCancelarProducto.TabIndex = 35;
            this.iconBtnCancelarProducto.Text = "Cancelar\r\n";
            this.iconBtnCancelarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCancelarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCancelarProducto.UseVisualStyleBackColor = false;
            // 
            // iconBtnLimpiarProducto
            // 
            this.iconBtnLimpiarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnLimpiarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.iconBtnLimpiarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnLimpiarProducto.FlatAppearance.BorderSize = 0;
            this.iconBtnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLimpiarProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnLimpiarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnLimpiarProducto.IconChar = FontAwesome.Sharp.IconChar.WandMagicSparkles;
            this.iconBtnLimpiarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnLimpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnLimpiarProducto.IconSize = 20;
            this.iconBtnLimpiarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLimpiarProducto.Location = new System.Drawing.Point(17, 397);
            this.iconBtnLimpiarProducto.Name = "iconBtnLimpiarProducto";
            this.iconBtnLimpiarProducto.Size = new System.Drawing.Size(216, 34);
            this.iconBtnLimpiarProducto.TabIndex = 34;
            this.iconBtnLimpiarProducto.Text = "Limpiar";
            this.iconBtnLimpiarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLimpiarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnLimpiarProducto.UseVisualStyleBackColor = false;
            // 
            // iconBtnGuardarProducto
            // 
            this.iconBtnGuardarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnGuardarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconBtnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.iconBtnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnGuardarProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnGuardarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconBtnGuardarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnGuardarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnGuardarProducto.IconSize = 20;
            this.iconBtnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnGuardarProducto.Location = new System.Drawing.Point(17, 357);
            this.iconBtnGuardarProducto.Name = "iconBtnGuardarProducto";
            this.iconBtnGuardarProducto.Size = new System.Drawing.Size(216, 34);
            this.iconBtnGuardarProducto.TabIndex = 33;
            this.iconBtnGuardarProducto.Text = "Guardar";
            this.iconBtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnGuardarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Estado";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre ";
            // 
            // txtDescrProducto
            // 
            this.txtDescrProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescrProducto.BackColor = System.Drawing.Color.White;
            this.txtDescrProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrProducto.Location = new System.Drawing.Point(17, 178);
            this.txtDescrProducto.Name = "txtDescrProducto";
            this.txtDescrProducto.Size = new System.Drawing.Size(216, 26);
            this.txtDescrProducto.TabIndex = 21;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreProducto.BackColor = System.Drawing.Color.White;
            this.txtNombreProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(17, 118);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(216, 26);
            this.txtNombreProducto.TabIndex = 20;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoProducto.BackColor = System.Drawing.Color.White;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(17, 58);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(216, 26);
            this.txtCodigoProducto.TabIndex = 19;
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxProducto.Controls.Add(this.iconBntLimpiar);
            this.groupBoxProducto.Controls.Add(this.iconBtnBuscarProd);
            this.groupBoxProducto.Controls.Add(this.comboBoxFiltroProducto);
            this.groupBoxProducto.Controls.Add(this.lblBuscarProd);
            this.groupBoxProducto.Controls.Add(this.textBoxListarProducto);
            this.groupBoxProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxProducto.Location = new System.Drawing.Point(252, 0);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(432, 100);
            this.groupBoxProducto.TabIndex = 14;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Lista de productos";
            // 
            // iconBntLimpiar
            // 
            this.iconBntLimpiar.BackColor = System.Drawing.Color.ForestGreen;
            this.iconBntLimpiar.FlatAppearance.BorderSize = 0;
            this.iconBntLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBntLimpiar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBntLimpiar.ForeColor = System.Drawing.Color.White;
            this.iconBntLimpiar.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.iconBntLimpiar.IconColor = System.Drawing.Color.White;
            this.iconBntLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBntLimpiar.IconSize = 20;
            this.iconBntLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBntLimpiar.Location = new System.Drawing.Point(340, 58);
            this.iconBntLimpiar.Name = "iconBntLimpiar";
            this.iconBntLimpiar.Size = new System.Drawing.Size(80, 25);
            this.iconBntLimpiar.TabIndex = 30;
            this.iconBntLimpiar.Text = "Limpiar";
            this.iconBntLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBntLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBntLimpiar.UseVisualStyleBackColor = false;
            // 
            // iconBtnBuscarProd
            // 
            this.iconBtnBuscarProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconBtnBuscarProd.FlatAppearance.BorderSize = 0;
            this.iconBtnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBuscarProd.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.iconBtnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconBtnBuscarProd.IconColor = System.Drawing.Color.White;
            this.iconBtnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnBuscarProd.IconSize = 20;
            this.iconBtnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBuscarProd.Location = new System.Drawing.Point(340, 27);
            this.iconBtnBuscarProd.Name = "iconBtnBuscarProd";
            this.iconBtnBuscarProd.Size = new System.Drawing.Size(80, 25);
            this.iconBtnBuscarProd.TabIndex = 29;
            this.iconBtnBuscarProd.Text = "Buscar";
            this.iconBtnBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBuscarProd.UseVisualStyleBackColor = false;
            // 
            // comboBoxFiltroProducto
            // 
            this.comboBoxFiltroProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFiltroProducto.BackColor = System.Drawing.Color.White;
            this.comboBoxFiltroProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroProducto.FormattingEnabled = true;
            this.comboBoxFiltroProducto.Items.AddRange(new object[] {
            "Sistema Eléctrico",
            "Sistema de Suspensión",
            "Sistema de Motor",
            "Repuesto Básicos",
            "Sistema de Encendido",
            "SISTEMA DE fRENOPS"});
            this.comboBoxFiltroProducto.Location = new System.Drawing.Point(105, 29);
            this.comboBoxFiltroProducto.Name = "comboBoxFiltroProducto";
            this.comboBoxFiltroProducto.Size = new System.Drawing.Size(216, 24);
            this.comboBoxFiltroProducto.TabIndex = 28;
            // 
            // lblBuscarProd
            // 
            this.lblBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscarProd.AutoSize = true;
            this.lblBuscarProd.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProd.Location = new System.Drawing.Point(24, 32);
            this.lblBuscarProd.Name = "lblBuscarProd";
            this.lblBuscarProd.Size = new System.Drawing.Size(75, 16);
            this.lblBuscarProd.TabIndex = 27;
            this.lblBuscarProd.Text = "Buscar por:";
            // 
            // textBoxListarProducto
            // 
            this.textBoxListarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxListarProducto.BackColor = System.Drawing.Color.White;
            this.textBoxListarProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxListarProducto.Location = new System.Drawing.Point(27, 61);
            this.textBoxListarProducto.Name = "textBoxListarProducto";
            this.textBoxListarProducto.Size = new System.Drawing.Size(294, 23);
            this.textBoxListarProducto.TabIndex = 26;
            // 
            // dataGridViewListProd
            // 
            this.dataGridViewListProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewListProd.Location = new System.Drawing.Point(252, 100);
            this.dataGridViewListProd.Name = "dataGridViewListProd";
            this.dataGridViewListProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListProd.Size = new System.Drawing.Size(432, 346);
            this.dataGridViewListProd.TabIndex = 15;
            // 
            // panelFileDown
            // 
            this.panelFileDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFileDown.Controls.Add(this.iconBtnFileCvs);
            this.panelFileDown.Controls.Add(this.iconBtnPDF);
            this.panelFileDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileDown.Location = new System.Drawing.Point(252, 446);
            this.panelFileDown.Name = "panelFileDown";
            this.panelFileDown.Size = new System.Drawing.Size(432, 53);
            this.panelFileDown.TabIndex = 16;
            // 
            // iconBtnFileCvs
            // 
            this.iconBtnFileCvs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnFileCvs.BackColor = System.Drawing.Color.ForestGreen;
            this.iconBtnFileCvs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnFileCvs.FlatAppearance.BorderSize = 0;
            this.iconBtnFileCvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnFileCvs.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.iconBtnFileCvs.ForeColor = System.Drawing.Color.White;
            this.iconBtnFileCvs.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnFileCvs.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnFileCvs.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnFileCvs.IconSize = 20;
            this.iconBtnFileCvs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnFileCvs.Location = new System.Drawing.Point(291, 8);
            this.iconBtnFileCvs.Name = "iconBtnFileCvs";
            this.iconBtnFileCvs.Size = new System.Drawing.Size(129, 34);
            this.iconBtnFileCvs.TabIndex = 36;
            this.iconBtnFileCvs.Text = "Download Cvs";
            this.iconBtnFileCvs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnFileCvs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnFileCvs.UseVisualStyleBackColor = false;
            // 
            // iconBtnPDF
            // 
            this.iconBtnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnPDF.BackColor = System.Drawing.Color.DarkRed;
            this.iconBtnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnPDF.FlatAppearance.BorderSize = 0;
            this.iconBtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPDF.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnPDF.ForeColor = System.Drawing.Color.White;
            this.iconBtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconBtnPDF.IconColor = System.Drawing.Color.White;
            this.iconBtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPDF.IconSize = 20;
            this.iconBtnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPDF.Location = new System.Drawing.Point(148, 9);
            this.iconBtnPDF.Name = "iconBtnPDF";
            this.iconBtnPDF.Size = new System.Drawing.Size(125, 34);
            this.iconBtnPDF.TabIndex = 34;
            this.iconBtnPDF.Text = "Download PDF";
            this.iconBtnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPDF.UseVisualStyleBackColor = false;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.panelFileDown);
            this.Controls.Add(this.dataGridViewListProd);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.grpbxPnlProducto);
            this.Controls.Add(this.iconBtnProductoExcel);
            this.Controls.Add(this.iconBtnProductoPdf);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.grpbxPnlProducto.ResumeLayout(false);
            this.grpbxPnlProducto.PerformLayout();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProd)).EndInit();
            this.panelFileDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconBtnProductoPdf;
        private FontAwesome.Sharp.IconButton iconBtnProductoExcel;
        private System.Windows.Forms.ComboBox comboBoxCategoría;
        private System.Windows.Forms.GroupBox grpbxPnlProducto;
        private System.Windows.Forms.CheckedListBox checkedListBoxEstado;
        private FontAwesome.Sharp.IconButton iconBtnCancelarProducto;
        private FontAwesome.Sharp.IconButton iconBtnLimpiarProducto;
        private FontAwesome.Sharp.IconButton iconBtnGuardarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescrProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.ComboBox comboBoxFiltroProducto;
        private System.Windows.Forms.Label lblBuscarProd;
        private System.Windows.Forms.TextBox textBoxListarProducto;
        private FontAwesome.Sharp.IconButton iconBntLimpiar;
        private FontAwesome.Sharp.IconButton iconBtnBuscarProd;
        private System.Windows.Forms.DataGridView dataGridViewListProd;
        private System.Windows.Forms.Panel panelFileDown;
        private FontAwesome.Sharp.IconButton iconBtnFileCvs;
        private FontAwesome.Sharp.IconButton iconBtnPDF;
    }
}