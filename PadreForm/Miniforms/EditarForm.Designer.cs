namespace PadreForm
{
    partial class EditarForm
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
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txbPventa = new System.Windows.Forms.TextBox();
            this.txbPcompra = new System.Windows.Forms.TextBox();
            this.txbcategoria = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbproovedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbproveedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(330, 124);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(132, 22);
            this.txbCantidad.TabIndex = 27;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(330, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(195, 237);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 25;
            this.btneditar.Text = "Aceptar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(330, 75);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(132, 24);
            this.cbcategoria.TabIndex = 24;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // txbPventa
            // 
            this.txbPventa.Location = new System.Drawing.Point(179, 124);
            this.txbPventa.Margin = new System.Windows.Forms.Padding(4);
            this.txbPventa.Name = "txbPventa";
            this.txbPventa.Size = new System.Drawing.Size(132, 22);
            this.txbPventa.TabIndex = 23;
            this.txbPventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPventa_KeyPress);
            // 
            // txbPcompra
            // 
            this.txbPcompra.Location = new System.Drawing.Point(26, 124);
            this.txbPcompra.Margin = new System.Windows.Forms.Padding(4);
            this.txbPcompra.Name = "txbPcompra";
            this.txbPcompra.Size = new System.Drawing.Size(132, 22);
            this.txbPcompra.TabIndex = 22;
            this.txbPcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPcompra_KeyPress);
            // 
            // txbcategoria
            // 
            this.txbcategoria.Location = new System.Drawing.Point(330, 43);
            this.txbcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txbcategoria.Name = "txbcategoria";
            this.txbcategoria.Size = new System.Drawing.Size(132, 22);
            this.txbcategoria.TabIndex = 21;
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(179, 43);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(132, 22);
            this.txbnombre.TabIndex = 20;
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(26, 43);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(132, 22);
            this.txbcodigo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio de compra";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(333, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categoria";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(181, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio de ventra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(181, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbproovedor
            // 
            this.txbproovedor.Location = new System.Drawing.Point(179, 176);
            this.txbproovedor.Margin = new System.Windows.Forms.Padding(4);
            this.txbproovedor.Name = "txbproovedor";
            this.txbproovedor.Size = new System.Drawing.Size(132, 22);
            this.txbproovedor.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(181, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Proovedor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbproveedores
            // 
            this.cbproveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedores.FormattingEnabled = true;
            this.cbproveedores.Location = new System.Drawing.Point(179, 205);
            this.cbproveedores.Margin = new System.Windows.Forms.Padding(4);
            this.cbproveedores.Name = "cbproveedores";
            this.cbproveedores.Size = new System.Drawing.Size(132, 24);
            this.cbproveedores.TabIndex = 30;
            this.cbproveedores.SelectedIndexChanged += new System.EventHandler(this.cbproveedores_SelectedIndexChanged);
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 271);
            this.Controls.Add(this.cbproveedores);
            this.Controls.Add(this.txbproovedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btneditar);
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
            this.KeyPreview = true;
            this.Name = "EditarForm";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.EditarForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditarForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.TextBox txbPventa;
        private System.Windows.Forms.TextBox txbPcompra;
        private System.Windows.Forms.TextBox txbcategoria;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbproovedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbproveedores;
    }
}