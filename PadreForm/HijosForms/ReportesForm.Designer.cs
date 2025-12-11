namespace PadreForm
{
    partial class ReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            this.dgvtickets = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costofinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.cbusuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblventasdia = new System.Windows.Forms.Label();
            this.lblproductosvendidos = new System.Windows.Forms.Label();
            this.lblproductostotalesvendidos = new System.Windows.Forms.Label();
            this.lblventastotales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtickets
            // 
            this.dgvtickets.AllowUserToAddRows = false;
            this.dgvtickets.AllowUserToDeleteRows = false;
            this.dgvtickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.vendedor,
            this.numticket,
            this.costofinal});
            this.dgvtickets.Location = new System.Drawing.Point(0, -1);
            this.dgvtickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtickets.MultiSelect = false;
            this.dgvtickets.Name = "dgvtickets";
            this.dgvtickets.ReadOnly = true;
            this.dgvtickets.RowHeadersVisible = false;
            this.dgvtickets.RowHeadersWidth = 51;
            this.dgvtickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtickets.Size = new System.Drawing.Size(530, 226);
            this.dgvtickets.TabIndex = 1;
            this.dgvtickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtickets_CellContentClick);
            this.dgvtickets.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventario_CellContentDoubleClick);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.MinimumWidth = 6;
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 125;
            // 
            // numticket
            // 
            this.numticket.HeaderText = "Numero de ticket";
            this.numticket.MinimumWidth = 6;
            this.numticket.Name = "numticket";
            this.numticket.ReadOnly = true;
            this.numticket.Width = 125;
            // 
            // costofinal
            // 
            this.costofinal.HeaderText = "Costo Final";
            this.costofinal.MinimumWidth = 6;
            this.costofinal.Name = "costofinal";
            this.costofinal.ReadOnly = true;
            this.costofinal.Width = 125;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(607, 43);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(246, 22);
            this.dtpfecha.TabIndex = 2;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // cbusuarios
            // 
            this.cbusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbusuarios.FormattingEnabled = true;
            this.cbusuarios.Location = new System.Drawing.Point(642, 12);
            this.cbusuarios.Name = "cbusuarios";
            this.cbusuarios.Size = new System.Drawing.Size(211, 24);
            this.cbusuarios.TabIndex = 3;
            this.cbusuarios.SelectedIndexChanged += new System.EventHandler(this.cbusuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(537, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(537, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(554, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ventas del dia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(688, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Produtos vendidos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblventasdia
            // 
            this.lblventasdia.Location = new System.Drawing.Point(572, 108);
            this.lblventasdia.Name = "lblventasdia";
            this.lblventasdia.Size = new System.Drawing.Size(64, 21);
            this.lblventasdia.TabIndex = 8;
            this.lblventasdia.Text = "0";
            this.lblventasdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblproductosvendidos
            // 
            this.lblproductosvendidos.Location = new System.Drawing.Point(714, 108);
            this.lblproductosvendidos.Name = "lblproductosvendidos";
            this.lblproductosvendidos.Size = new System.Drawing.Size(64, 21);
            this.lblproductosvendidos.TabIndex = 9;
            this.lblproductosvendidos.Text = "0";
            this.lblproductosvendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblproductostotalesvendidos
            // 
            this.lblproductostotalesvendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductostotalesvendidos.Location = new System.Drawing.Point(714, 182);
            this.lblproductostotalesvendidos.Name = "lblproductostotalesvendidos";
            this.lblproductostotalesvendidos.Size = new System.Drawing.Size(64, 21);
            this.lblproductostotalesvendidos.TabIndex = 13;
            this.lblproductostotalesvendidos.Text = "0";
            this.lblproductostotalesvendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblproductostotalesvendidos.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblventastotales
            // 
            this.lblventastotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventastotales.Location = new System.Drawing.Point(572, 182);
            this.lblventastotales.Name = "lblventastotales";
            this.lblventastotales.Size = new System.Drawing.Size(64, 21);
            this.lblventastotales.TabIndex = 12;
            this.lblventastotales.Text = "0";
            this.lblventastotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblventastotales.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(688, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Produtos Totales vendidos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(554, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ventas Totales:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 227);
            this.Controls.Add(this.lblproductostotalesvendidos);
            this.Controls.Add(this.lblventastotales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblproductosvendidos);
            this.Controls.Add(this.lblventasdia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbusuarios);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.dgvtickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportesForm";
            this.Text = "Tickets";
            this.Activated += new System.EventHandler(this.ReportesForm_Activated);
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn costofinal;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ComboBox cbusuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblventasdia;
        private System.Windows.Forms.Label lblproductosvendidos;
        private System.Windows.Forms.Label lblproductostotalesvendidos;
        private System.Windows.Forms.Label lblventastotales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}