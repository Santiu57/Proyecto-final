namespace PadreForm
{
    partial class InventarioForm
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
            this.dgvinventario = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proovedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txbbuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinventario
            // 
            this.dgvinventario.AllowUserToAddRows = false;
            this.dgvinventario.AllowUserToDeleteRows = false;
            this.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.categoria,
            this.Pcompra,
            this.Pventa,
            this.cantidad,
            this.proovedor,
            this.registro});
            this.dgvinventario.Location = new System.Drawing.Point(13, 43);
            this.dgvinventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvinventario.MultiSelect = false;
            this.dgvinventario.Name = "dgvinventario";
            this.dgvinventario.ReadOnly = true;
            this.dgvinventario.RowHeadersVisible = false;
            this.dgvinventario.RowHeadersWidth = 51;
            this.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinventario.Size = new System.Drawing.Size(668, 297);
            this.dgvinventario.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 70;
            // 
            // Pcompra
            // 
            this.Pcompra.HeaderText = "Precio compra";
            this.Pcompra.MinimumWidth = 6;
            this.Pcompra.Name = "Pcompra";
            this.Pcompra.ReadOnly = true;
            this.Pcompra.Width = 70;
            // 
            // Pventa
            // 
            this.Pventa.HeaderText = "Precio venta";
            this.Pventa.MinimumWidth = 6;
            this.Pventa.Name = "Pventa";
            this.Pventa.ReadOnly = true;
            this.Pventa.Width = 70;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 70;
            // 
            // proovedor
            // 
            this.proovedor.HeaderText = "Proovedor";
            this.proovedor.MinimumWidth = 6;
            this.proovedor.Name = "proovedor";
            this.proovedor.ReadOnly = true;
            this.proovedor.Width = 75;
            // 
            // registro
            // 
            this.registro.HeaderText = "Registro";
            this.registro.MinimumWidth = 6;
            this.registro.Name = "registro";
            this.registro.ReadOnly = true;
            this.registro.Width = 125;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(301, 346);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(193, 346);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 28);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txbbuscador
            // 
            this.txbbuscador.Location = new System.Drawing.Point(92, 11);
            this.txbbuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txbbuscador.Name = "txbbuscador";
            this.txbbuscador.Size = new System.Drawing.Size(285, 22);
            this.txbbuscador.TabIndex = 14;
            this.txbbuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscador:";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(409, 346);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 16;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(384, 11);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(145, 24);
            this.cbcategoria.TabIndex = 17;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 387);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbbuscador);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvinventario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventarioForm";
            this.Text = "InventarioForm";
            this.Load += new System.EventHandler(this.InventarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvinventario;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txbbuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn proovedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
    }
}