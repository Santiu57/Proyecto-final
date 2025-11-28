namespace PadreForm
{
    partial class InicioSesionForm
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
            this.cbusuarios = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbRol = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbusuarios
            // 
            this.cbusuarios.FormattingEnabled = true;
            this.cbusuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbusuarios.Location = new System.Drawing.Point(55, 39);
            this.cbusuarios.Name = "cbusuarios";
            this.cbusuarios.Size = new System.Drawing.Size(121, 33);
            this.cbusuarios.TabIndex = 0;
            this.cbusuarios.Text = "Usuarios";
            this.cbusuarios.SelectedIndexChanged += new System.EventHandler(this.cbusuarios_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(79, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(87, 77);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(130, 30);
            this.txbNombreUsuario.TabIndex = 2;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(117, 110);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(100, 30);
            this.txbContraseña.TabIndex = 3;
            // 
            // lblSesion
            // 
            this.lblSesion.Location = new System.Drawing.Point(12, 16);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(221, 20);
            this.lblSesion.TabIndex = 4;
            this.lblSesion.Text = "Inicie sesion";
            this.lblSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(87, 176);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(130, 30);
            this.txbNombre.TabIndex = 6;
            this.txbNombre.Visible = false;
            // 
            // txbRol
            // 
            this.txbRol.Location = new System.Drawing.Point(55, 143);
            this.txbRol.Name = "txbRol";
            this.txbRol.Size = new System.Drawing.Size(162, 30);
            this.txbRol.TabIndex = 5;
            this.txbRol.Visible = false;
            // 
            // lblusuario
            // 
            this.lblusuario.Location = new System.Drawing.Point(12, 77);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(69, 26);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Location = new System.Drawing.Point(12, 110);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(99, 26);
            this.lblcontraseña.TabIndex = 8;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblrol
            // 
            this.lblrol.Location = new System.Drawing.Point(12, 143);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(43, 26);
            this.lblrol.TabIndex = 9;
            this.lblrol.Text = "Rol:";
            this.lblrol.Visible = false;
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(12, 176);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(69, 26);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.Visible = false;
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 239);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbRol);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbNombreUsuario);
            this.Controls.Add(this.cbusuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InicioSesionForm";
            this.Text = "InicioSesionForm";
            this.Load += new System.EventHandler(this.InicioSesionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbusuarios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbRol;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lblnombre;
    }
}