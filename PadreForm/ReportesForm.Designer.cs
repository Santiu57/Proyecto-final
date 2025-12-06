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
            this.dgvtickets.Size = new System.Drawing.Size(705, 226);
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
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 227);
            this.Controls.Add(this.dgvtickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}