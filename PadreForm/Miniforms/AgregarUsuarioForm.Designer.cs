namespace PadreForm
{
    partial class AgregarUsuarioForm
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbRol = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(69, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(4, 106);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(69, 26);
            this.lblnombre.TabIndex = 21;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblrol
            // 
            this.lblrol.Location = new System.Drawing.Point(4, 73);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(43, 26);
            this.lblrol.TabIndex = 20;
            this.lblrol.Text = "Rol:";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Location = new System.Drawing.Point(4, 40);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(99, 26);
            this.lblcontraseña.TabIndex = 19;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.Location = new System.Drawing.Point(4, 7);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(69, 26);
            this.lblusuario.TabIndex = 18;
            this.lblusuario.Text = "Usuario:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(79, 106);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(130, 22);
            this.txbNombre.TabIndex = 17;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // txbRol
            // 
            this.txbRol.Location = new System.Drawing.Point(47, 73);
            this.txbRol.Name = "txbRol";
            this.txbRol.Size = new System.Drawing.Size(162, 22);
            this.txbRol.TabIndex = 16;
            this.txbRol.TextChanged += new System.EventHandler(this.txbRol_TextChanged);
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(109, 40);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(100, 22);
            this.txbContraseña.TabIndex = 14;
            this.txbContraseña.TextChanged += new System.EventHandler(this.txbContraseña_TextChanged);
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(79, 7);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(130, 22);
            this.txbNombreUsuario.TabIndex = 13;
            this.txbNombreUsuario.TextChanged += new System.EventHandler(this.txbNombreUsuario_TextChanged);
            // 
            // AgregarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 168);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbRol);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AgregarUsuarioForm";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.AgregarUsuarioForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgregarUsuarioForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbRol;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbNombreUsuario;
    }
}