namespace PadreForm
{
    partial class AñadirForm
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
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbcategoria = new System.Windows.Forms.TextBox();
            this.txbPcompra = new System.Windows.Forms.TextBox();
            this.txbPventa = new System.Windows.Forms.TextBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbproovedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de ventra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de compra";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(16, 36);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(132, 22);
            this.txbcodigo.TabIndex = 5;
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(169, 36);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(132, 22);
            this.txbnombre.TabIndex = 6;
            // 
            // txbcategoria
            // 
            this.txbcategoria.Location = new System.Drawing.Point(320, 36);
            this.txbcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txbcategoria.Name = "txbcategoria";
            this.txbcategoria.Size = new System.Drawing.Size(132, 22);
            this.txbcategoria.TabIndex = 7;
            // 
            // txbPcompra
            // 
            this.txbPcompra.Location = new System.Drawing.Point(16, 130);
            this.txbPcompra.Margin = new System.Windows.Forms.Padding(4);
            this.txbPcompra.Name = "txbPcompra";
            this.txbPcompra.Size = new System.Drawing.Size(132, 22);
            this.txbPcompra.TabIndex = 8;
            // 
            // txbPventa
            // 
            this.txbPventa.Location = new System.Drawing.Point(169, 130);
            this.txbPventa.Margin = new System.Windows.Forms.Padding(4);
            this.txbPventa.Name = "txbPventa";
            this.txbPventa.Size = new System.Drawing.Size(132, 22);
            this.txbPventa.TabIndex = 9;
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(320, 68);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(132, 24);
            this.cbcategoria.TabIndex = 10;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(182, 241);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(100, 28);
            this.btnañadir.TabIndex = 11;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(320, 130);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(132, 22);
            this.txbCantidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // txbproovedor
            // 
            this.txbproovedor.Location = new System.Drawing.Point(169, 198);
            this.txbproovedor.Margin = new System.Windows.Forms.Padding(4);
            this.txbproovedor.Name = "txbproovedor";
            this.txbproovedor.Size = new System.Drawing.Size(132, 22);
            this.txbproovedor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proovedor";
            // 
            // AñadirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 282);
            this.Controls.Add(this.txbproovedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.txbPventa);
            this.Controls.Add(this.txbPcompra);
            this.Controls.Add(this.txbcategoria);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AñadirForm";
            this.Text = "AñadirForm";
            this.Load += new System.EventHandler(this.AñadirForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbcategoria;
        private System.Windows.Forms.TextBox txbPcompra;
        private System.Windows.Forms.TextBox txbPventa;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbproovedor;
        private System.Windows.Forms.Label label7;
    }
}