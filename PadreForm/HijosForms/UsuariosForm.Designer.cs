namespace PadreForm
{
    partial class UsuariosForm
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
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cbrol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbbuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.rol,
            this.nombre});
            this.dgvusuarios.Location = new System.Drawing.Point(4, 43);
            this.dgvusuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvusuarios.MultiSelect = false;
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.ReadOnly = true;
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.RowHeadersWidth = 51;
            this.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuarios.Size = new System.Drawing.Size(532, 197);
            this.dgvusuarios.TabIndex = 1;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(306, 250);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 19;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(198, 250);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 18;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(90, 248);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 28);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cbrol
            // 
            this.cbrol.FormattingEnabled = true;
            this.cbrol.Location = new System.Drawing.Point(382, 12);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(145, 24);
            this.cbrol.TabIndex = 22;
            this.cbrol.SelectedIndexChanged += new System.EventHandler(this.cbrol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscador:";
            // 
            // txbbuscador
            // 
            this.txbbuscador.Location = new System.Drawing.Point(90, 12);
            this.txbbuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txbbuscador.Name = "txbbuscador";
            this.txbbuscador.Size = new System.Drawing.Size(285, 22);
            this.txbbuscador.TabIndex = 20;
            this.txbbuscador.TextChanged += new System.EventHandler(this.txbbuscador_TextChanged);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 288);
            this.Controls.Add(this.cbrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbbuscador);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvusuarios);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.Activated += new System.EventHandler(this.UsuariosForm_Activated);
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cbrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbbuscador;
    }
}