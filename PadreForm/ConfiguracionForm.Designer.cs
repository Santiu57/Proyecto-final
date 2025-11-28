namespace PadreForm
{
    partial class ConfiguracionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdfondo = new System.Windows.Forms.ColorDialog();
            this.cdletra = new System.Windows.Forms.ColorDialog();
            this.ofdlogo = new System.Windows.Forms.OpenFileDialog();
            this.txbnombretienda = new System.Windows.Forms.TextBox();
            this.txbubicaciontienda = new System.Windows.Forms.TextBox();
            this.btnlogo = new System.Windows.Forms.Button();
            this.btnfondo = new System.Windows.Forms.Button();
            this.btnletra = new System.Windows.Forms.Button();
            this.pnlfondo = new System.Windows.Forms.Panel();
            this.pnlletra = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la tienda:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicacion de la tienda:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logo de la tienda:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color de fondo:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(39, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color de letra:";
            // 
            // ofdlogo
            // 
            this.ofdlogo.FileName = "openFileDialog1";
            this.ofdlogo.Filter = "Imágenes PNG (*.png)|*.png";
            // 
            // txbnombretienda
            // 
            this.txbnombretienda.Location = new System.Drawing.Point(192, 35);
            this.txbnombretienda.Name = "txbnombretienda";
            this.txbnombretienda.Size = new System.Drawing.Size(126, 22);
            this.txbnombretienda.TabIndex = 5;
            // 
            // txbubicaciontienda
            // 
            this.txbubicaciontienda.Location = new System.Drawing.Point(192, 72);
            this.txbubicaciontienda.Name = "txbubicaciontienda";
            this.txbubicaciontienda.Size = new System.Drawing.Size(126, 22);
            this.txbubicaciontienda.TabIndex = 6;
            // 
            // btnlogo
            // 
            this.btnlogo.Location = new System.Drawing.Point(192, 108);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(126, 23);
            this.btnlogo.TabIndex = 7;
            this.btnlogo.Text = "Cambiar";
            this.btnlogo.UseVisualStyleBackColor = true;
            this.btnlogo.Click += new System.EventHandler(this.btnlogo_Click);
            // 
            // btnfondo
            // 
            this.btnfondo.Location = new System.Drawing.Point(192, 150);
            this.btnfondo.Name = "btnfondo";
            this.btnfondo.Size = new System.Drawing.Size(126, 23);
            this.btnfondo.TabIndex = 8;
            this.btnfondo.Text = "Cambiar";
            this.btnfondo.UseVisualStyleBackColor = true;
            this.btnfondo.Click += new System.EventHandler(this.btnfondo_Click);
            // 
            // btnletra
            // 
            this.btnletra.Location = new System.Drawing.Point(192, 189);
            this.btnletra.Name = "btnletra";
            this.btnletra.Size = new System.Drawing.Size(126, 23);
            this.btnletra.TabIndex = 9;
            this.btnletra.Text = "Cambiar";
            this.btnletra.UseVisualStyleBackColor = true;
            this.btnletra.Click += new System.EventHandler(this.btnletra_Click);
            // 
            // pnlfondo
            // 
            this.pnlfondo.Location = new System.Drawing.Point(324, 150);
            this.pnlfondo.Name = "pnlfondo";
            this.pnlfondo.Size = new System.Drawing.Size(106, 22);
            this.pnlfondo.TabIndex = 10;
            // 
            // pnlletra
            // 
            this.pnlletra.Location = new System.Drawing.Point(324, 189);
            this.pnlletra.Name = "pnlletra";
            this.pnlletra.Size = new System.Drawing.Size(106, 22);
            this.pnlletra.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(155, 230);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pblogo
            // 
            this.pblogo.Location = new System.Drawing.Point(325, 61);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(100, 83);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 13;
            this.pblogo.TabStop = false;
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 265);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlletra);
            this.Controls.Add(this.pnlfondo);
            this.Controls.Add(this.btnletra);
            this.Controls.Add(this.btnfondo);
            this.Controls.Add(this.btnlogo);
            this.Controls.Add(this.txbubicaciontienda);
            this.Controls.Add(this.txbnombretienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguracionForm";
            this.Text = "ConfiguracionForm";
            this.Load += new System.EventHandler(this.ConfiguracionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog cdfondo;
        private System.Windows.Forms.ColorDialog cdletra;
        private System.Windows.Forms.OpenFileDialog ofdlogo;
        private System.Windows.Forms.TextBox txbnombretienda;
        private System.Windows.Forms.TextBox txbubicaciontienda;
        private System.Windows.Forms.Button btnlogo;
        private System.Windows.Forms.Button btnfondo;
        private System.Windows.Forms.Button btnletra;
        private System.Windows.Forms.Panel pnlfondo;
        private System.Windows.Forms.Panel pnlletra;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pblogo;
    }
}