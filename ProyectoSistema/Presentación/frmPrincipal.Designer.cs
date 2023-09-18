
namespace ProyectoSistema
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.PanelSubmenuVentas = new System.Windows.Forms.Panel();
            this.iconBtnDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.iconBtnRgtVentas = new FontAwesome.Sharp.IconButton();
            this.iconBtnVentas = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenuCompras = new System.Windows.Forms.Panel();
            this.iconBtnDetalleCompra = new FontAwesome.Sharp.IconButton();
            this.iconBtnRgtCompra = new FontAwesome.Sharp.IconButton();
            this.iconBtnCompras = new FontAwesome.Sharp.IconButton();
            this.iconBtnCliente = new FontAwesome.Sharp.IconButton();
            this.iconBtnProducto = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.PanelSubmenuVentas.SuspendLayout();
            this.PanelSubMenuCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuVertical.Controls.Add(this.PanelSubmenuVentas);
            this.MenuVertical.Controls.Add(this.iconBtnVentas);
            this.MenuVertical.Controls.Add(this.PanelSubMenuCompras);
            this.MenuVertical.Controls.Add(this.iconBtnCompras);
            this.MenuVertical.Controls.Add(this.iconBtnCliente);
            this.MenuVertical.Controls.Add(this.iconBtnProducto);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 561);
            this.MenuVertical.TabIndex = 0;
            // 
            // PanelSubmenuVentas
            // 
            this.PanelSubmenuVentas.BackColor = System.Drawing.Color.DarkGray;
            this.PanelSubmenuVentas.Controls.Add(this.iconBtnDetalleVenta);
            this.PanelSubmenuVentas.Controls.Add(this.iconBtnRgtVentas);
            this.PanelSubmenuVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSubmenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubmenuVentas.Location = new System.Drawing.Point(0, 330);
            this.PanelSubmenuVentas.Name = "PanelSubmenuVentas";
            this.PanelSubmenuVentas.Size = new System.Drawing.Size(250, 70);
            this.PanelSubmenuVentas.TabIndex = 2;
            // 
            // iconBtnDetalleVenta
            // 
            this.iconBtnDetalleVenta.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconBtnDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnDetalleVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnDetalleVenta.FlatAppearance.BorderSize = 0;
            this.iconBtnDetalleVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.iconBtnDetalleVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconBtnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDetalleVenta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.iconBtnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconBtnDetalleVenta.IconColor = System.Drawing.Color.White;
            this.iconBtnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDetalleVenta.IconSize = 35;
            this.iconBtnDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDetalleVenta.Location = new System.Drawing.Point(0, 35);
            this.iconBtnDetalleVenta.Name = "iconBtnDetalleVenta";
            this.iconBtnDetalleVenta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.iconBtnDetalleVenta.Size = new System.Drawing.Size(250, 35);
            this.iconBtnDetalleVenta.TabIndex = 3;
            this.iconBtnDetalleVenta.Text = "Ver detalle";
            this.iconBtnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDetalleVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDetalleVenta.UseVisualStyleBackColor = false;
            this.iconBtnDetalleVenta.Click += new System.EventHandler(this.iconBtnDetalleVenta_Click);
            // 
            // iconBtnRgtVentas
            // 
            this.iconBtnRgtVentas.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconBtnRgtVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnRgtVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnRgtVentas.FlatAppearance.BorderSize = 0;
            this.iconBtnRgtVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.iconBtnRgtVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconBtnRgtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRgtVentas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnRgtVentas.ForeColor = System.Drawing.Color.White;
            this.iconBtnRgtVentas.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconBtnRgtVentas.IconColor = System.Drawing.Color.White;
            this.iconBtnRgtVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnRgtVentas.IconSize = 35;
            this.iconBtnRgtVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconBtnRgtVentas.Location = new System.Drawing.Point(0, 0);
            this.iconBtnRgtVentas.Name = "iconBtnRgtVentas";
            this.iconBtnRgtVentas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.iconBtnRgtVentas.Size = new System.Drawing.Size(250, 35);
            this.iconBtnRgtVentas.TabIndex = 2;
            this.iconBtnRgtVentas.Text = "Registrar Ventas";
            this.iconBtnRgtVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnRgtVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRgtVentas.UseVisualStyleBackColor = false;
            this.iconBtnRgtVentas.Click += new System.EventHandler(this.iconBtnRgtVentas_Click);
            // 
            // iconBtnVentas
            // 
            this.iconBtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnVentas.FlatAppearance.BorderSize = 0;
            this.iconBtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnVentas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnVentas.ForeColor = System.Drawing.Color.White;
            this.iconBtnVentas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconBtnVentas.IconColor = System.Drawing.Color.White;
            this.iconBtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnVentas.IconSize = 40;
            this.iconBtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnVentas.Location = new System.Drawing.Point(0, 290);
            this.iconBtnVentas.Name = "iconBtnVentas";
            this.iconBtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnVentas.Size = new System.Drawing.Size(250, 40);
            this.iconBtnVentas.TabIndex = 2;
            this.iconBtnVentas.Text = "Ventas";
            this.iconBtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnVentas.UseVisualStyleBackColor = true;
            this.iconBtnVentas.Click += new System.EventHandler(this.iconBtnVentas_Click);
            // 
            // PanelSubMenuCompras
            // 
            this.PanelSubMenuCompras.BackColor = System.Drawing.Color.Silver;
            this.PanelSubMenuCompras.Controls.Add(this.iconBtnDetalleCompra);
            this.PanelSubMenuCompras.Controls.Add(this.iconBtnRgtCompra);
            this.PanelSubMenuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSubMenuCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuCompras.Location = new System.Drawing.Point(0, 220);
            this.PanelSubMenuCompras.Name = "PanelSubMenuCompras";
            this.PanelSubMenuCompras.Size = new System.Drawing.Size(250, 70);
            this.PanelSubMenuCompras.TabIndex = 2;
            // 
            // iconBtnDetalleCompra
            // 
            this.iconBtnDetalleCompra.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconBtnDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnDetalleCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnDetalleCompra.FlatAppearance.BorderSize = 0;
            this.iconBtnDetalleCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.iconBtnDetalleCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconBtnDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDetalleCompra.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDetalleCompra.ForeColor = System.Drawing.Color.White;
            this.iconBtnDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconBtnDetalleCompra.IconColor = System.Drawing.Color.White;
            this.iconBtnDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDetalleCompra.IconSize = 35;
            this.iconBtnDetalleCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDetalleCompra.Location = new System.Drawing.Point(0, 35);
            this.iconBtnDetalleCompra.Name = "iconBtnDetalleCompra";
            this.iconBtnDetalleCompra.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconBtnDetalleCompra.Size = new System.Drawing.Size(250, 35);
            this.iconBtnDetalleCompra.TabIndex = 2;
            this.iconBtnDetalleCompra.Text = "Ver detalle";
            this.iconBtnDetalleCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDetalleCompra.UseVisualStyleBackColor = false;
            this.iconBtnDetalleCompra.Click += new System.EventHandler(this.iconBtnDetalleCompra_Click);
            // 
            // iconBtnRgtCompra
            // 
            this.iconBtnRgtCompra.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconBtnRgtCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnRgtCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnRgtCompra.FlatAppearance.BorderSize = 0;
            this.iconBtnRgtCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.iconBtnRgtCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.iconBtnRgtCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRgtCompra.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnRgtCompra.ForeColor = System.Drawing.Color.White;
            this.iconBtnRgtCompra.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconBtnRgtCompra.IconColor = System.Drawing.Color.White;
            this.iconBtnRgtCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnRgtCompra.IconSize = 35;
            this.iconBtnRgtCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnRgtCompra.Location = new System.Drawing.Point(0, 0);
            this.iconBtnRgtCompra.Name = "iconBtnRgtCompra";
            this.iconBtnRgtCompra.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconBtnRgtCompra.Size = new System.Drawing.Size(250, 35);
            this.iconBtnRgtCompra.TabIndex = 1;
            this.iconBtnRgtCompra.Text = "Registrar compra";
            this.iconBtnRgtCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnRgtCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRgtCompra.UseVisualStyleBackColor = false;
            this.iconBtnRgtCompra.Click += new System.EventHandler(this.iconBtnRgtCompra_Click);
            // 
            // iconBtnCompras
            // 
            this.iconBtnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCompras.FlatAppearance.BorderSize = 0;
            this.iconBtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCompras.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCompras.ForeColor = System.Drawing.Color.White;
            this.iconBtnCompras.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.iconBtnCompras.IconColor = System.Drawing.Color.White;
            this.iconBtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCompras.IconSize = 40;
            this.iconBtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCompras.Location = new System.Drawing.Point(0, 180);
            this.iconBtnCompras.Name = "iconBtnCompras";
            this.iconBtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCompras.Size = new System.Drawing.Size(250, 40);
            this.iconBtnCompras.TabIndex = 2;
            this.iconBtnCompras.Text = "Compras";
            this.iconBtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCompras.UseVisualStyleBackColor = true;
            this.iconBtnCompras.Click += new System.EventHandler(this.iconBtnCompras_Click);
            // 
            // iconBtnCliente
            // 
            this.iconBtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCliente.FlatAppearance.BorderSize = 0;
            this.iconBtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCliente.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCliente.ForeColor = System.Drawing.Color.White;
            this.iconBtnCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.iconBtnCliente.IconColor = System.Drawing.Color.White;
            this.iconBtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCliente.IconSize = 40;
            this.iconBtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCliente.Location = new System.Drawing.Point(0, 140);
            this.iconBtnCliente.Name = "iconBtnCliente";
            this.iconBtnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCliente.Size = new System.Drawing.Size(250, 40);
            this.iconBtnCliente.TabIndex = 1;
            this.iconBtnCliente.Text = "Clientes";
            this.iconBtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCliente.UseVisualStyleBackColor = true;
            // 
            // iconBtnProducto
            // 
            this.iconBtnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnProducto.FlatAppearance.BorderSize = 0;
            this.iconBtnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnProducto.ForeColor = System.Drawing.Color.White;
            this.iconBtnProducto.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            this.iconBtnProducto.IconColor = System.Drawing.Color.White;
            this.iconBtnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnProducto.IconSize = 40;
            this.iconBtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnProducto.Location = new System.Drawing.Point(0, 100);
            this.iconBtnProducto.Name = "iconBtnProducto";
            this.iconBtnProducto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnProducto.Size = new System.Drawing.Size(250, 40);
            this.iconBtnProducto.TabIndex = 0;
            this.iconBtnProducto.Text = "Productos";
            this.iconBtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnProducto.UseVisualStyleBackColor = true;
            this.iconBtnProducto.Click += new System.EventHandler(this.iconBtnProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraTitulo.ForeColor = System.Drawing.Color.Black;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(684, 62);
            this.BarraTitulo.TabIndex = 3;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenedor.Controls.Add(this.PictureLogo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContenedor.Location = new System.Drawing.Point(250, 62);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(684, 499);
            this.PanelContenedor.TabIndex = 4;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(88, 67);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(538, 329);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 1;
            this.PictureLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.PanelSubmenuVentas.ResumeLayout(false);
            this.PanelSubMenuCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private FontAwesome.Sharp.IconButton iconBtnProducto;
        private FontAwesome.Sharp.IconButton iconBtnCliente;
        private FontAwesome.Sharp.IconButton iconBtnCompras;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Panel PanelSubMenuCompras;
        private FontAwesome.Sharp.IconButton iconBtnDetalleCompra;
        private FontAwesome.Sharp.IconButton iconBtnRgtCompra;
        private FontAwesome.Sharp.IconButton iconBtnVentas;
        private System.Windows.Forms.Panel PanelSubmenuVentas;
        private FontAwesome.Sharp.IconButton iconBtnDetalleVenta;
        private FontAwesome.Sharp.IconButton iconBtnRgtVentas;
    }
}

