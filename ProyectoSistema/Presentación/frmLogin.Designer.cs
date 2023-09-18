
namespace ProyectoSistema.Presentación
{
    partial class frmLogin
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconPictureBoxLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.panelDatosUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconBtnIngresar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxLogo)).BeginInit();
            this.panelDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.panelDatosUsuarios);
            this.panelContenedor.Controls.Add(this.lblNombreTienda);
            this.panelContenedor.Controls.Add(this.iconPictureBoxLogo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(499, 211);
            this.panelContenedor.TabIndex = 0;
            // 
            // iconPictureBoxLogo
            // 
            this.iconPictureBoxLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconPictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxLogo.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBoxLogo.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxLogo.IconSize = 200;
            this.iconPictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxLogo.Name = "iconPictureBoxLogo";
            this.iconPictureBoxLogo.Size = new System.Drawing.Size(200, 211);
            this.iconPictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxLogo.TabIndex = 0;
            this.iconPictureBoxLogo.TabStop = false;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreTienda.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.ForeColor = System.Drawing.Color.White;
            this.lblNombreTienda.Location = new System.Drawing.Point(23, 170);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(154, 23);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "Sistema Ventas";
            this.lblNombreTienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDatosUsuarios
            // 
            this.panelDatosUsuarios.Controls.Add(this.iconBtnIngresar);
            this.panelDatosUsuarios.Controls.Add(this.iconBtnCancelar);
            this.panelDatosUsuarios.Controls.Add(this.txtBoxPassword);
            this.panelDatosUsuarios.Controls.Add(this.txtBoxUsuario);
            this.panelDatosUsuarios.Controls.Add(this.lblPassword);
            this.panelDatosUsuarios.Controls.Add(this.lblUsuario);
            this.panelDatosUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDatosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosUsuarios.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatosUsuarios.Location = new System.Drawing.Point(200, 0);
            this.panelDatosUsuarios.Name = "panelDatosUsuarios";
            this.panelDatosUsuarios.Size = new System.Drawing.Size(299, 211);
            this.panelDatosUsuarios.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(28, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsuario.Location = new System.Drawing.Point(32, 58);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(240, 26);
            this.txtBoxUsuario.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPassword.Location = new System.Drawing.Point(32, 117);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(240, 26);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.iconBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCancelar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.White;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnCancelar.IconSize = 25;
            this.iconBtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCancelar.Location = new System.Drawing.Point(172, 163);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.iconBtnCancelar.TabIndex = 4;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconBtnIngresar
            // 
            this.iconBtnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconBtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnIngresar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnIngresar.ForeColor = System.Drawing.Color.White;
            this.iconBtnIngresar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.iconBtnIngresar.IconColor = System.Drawing.Color.White;
            this.iconBtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnIngresar.IconSize = 25;
            this.iconBtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnIngresar.Location = new System.Drawing.Point(32, 163);
            this.iconBtnIngresar.Name = "iconBtnIngresar";
            this.iconBtnIngresar.Size = new System.Drawing.Size(100, 30);
            this.iconBtnIngresar.TabIndex = 5;
            this.iconBtnIngresar.Text = "Ingresar";
            this.iconBtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnIngresar.UseVisualStyleBackColor = false;
            this.iconBtnIngresar.Click += new System.EventHandler(this.iconBtnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(499, 211);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxLogo)).EndInit();
            this.panelDatosUsuarios.ResumeLayout(false);
            this.panelDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblNombreTienda;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxLogo;
        private System.Windows.Forms.Panel panelDatosUsuarios;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconButton iconBtnIngresar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
    }
}