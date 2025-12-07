namespace PadreForm.Miniforms
{
    partial class AccesoForm
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
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblSesion = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.cbadmins = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(88, 122);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Location = new System.Drawing.Point(13, 94);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(99, 26);
            this.lblcontraseña.TabIndex = 19;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.Location = new System.Drawing.Point(13, 66);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(69, 26);
            this.lblusuario.TabIndex = 18;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblSesion
            // 
            this.lblSesion.Location = new System.Drawing.Point(12, 13);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(210, 20);
            this.lblSesion.TabIndex = 15;
            this.lblSesion.Text = "Confirme su Identidad";
            this.lblSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(118, 94);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(100, 22);
            this.txbContraseña.TabIndex = 14;
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(88, 66);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.ReadOnly = true;
            this.txbNombreUsuario.Size = new System.Drawing.Size(130, 22);
            this.txbNombreUsuario.TabIndex = 13;
            // 
            // cbadmins
            // 
            this.cbadmins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadmins.FormattingEnabled = true;
            this.cbadmins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbadmins.Location = new System.Drawing.Point(56, 36);
            this.cbadmins.Name = "cbadmins";
            this.cbadmins.Size = new System.Drawing.Size(121, 24);
            this.cbadmins.TabIndex = 11;
            this.cbadmins.SelectedIndexChanged += new System.EventHandler(this.cbadmins_SelectedIndexChanged);
            // 
            // AccesoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 164);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbNombreUsuario);
            this.Controls.Add(this.cbadmins);
            this.KeyPreview = true;
            this.Name = "AccesoForm";
            this.Text = "AccesoForm";
            this.Load += new System.EventHandler(this.AccesoForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccesoForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.ComboBox cbadmins;
    }
}