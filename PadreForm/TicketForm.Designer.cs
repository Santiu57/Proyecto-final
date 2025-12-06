namespace PadreForm
{
    partial class TicketForm
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
            this.txbticket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbticket
            // 
            this.txbticket.Location = new System.Drawing.Point(3, 2);
            this.txbticket.Multiline = true;
            this.txbticket.Name = "txbticket";
            this.txbticket.ReadOnly = true;
            this.txbticket.Size = new System.Drawing.Size(475, 414);
            this.txbticket.TabIndex = 0;
            this.txbticket.TextChanged += new System.EventHandler(this.txbticket_TextChanged);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 421);
            this.Controls.Add(this.txbticket);
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbticket;
    }
}