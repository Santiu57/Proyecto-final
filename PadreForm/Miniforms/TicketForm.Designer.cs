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
            this.pblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbticket
            // 
            this.txbticket.Location = new System.Drawing.Point(3, 2);
            this.txbticket.Multiline = true;
            this.txbticket.Name = "txbticket";
            this.txbticket.ReadOnly = true;
            this.txbticket.Size = new System.Drawing.Size(344, 249);
            this.txbticket.TabIndex = 0;
            this.txbticket.TextChanged += new System.EventHandler(this.txbticket_TextChanged);
            // 
            // pblogo
            // 
            this.pblogo.Image = global::PadreForm.Properties.Resources.marifumos;
            this.pblogo.Location = new System.Drawing.Point(257, 22);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(90, 90);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 1;
            this.pblogo.TabStop = false;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 249);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.txbticket);
            this.KeyPreview = true;
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TicketForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbticket;
        private System.Windows.Forms.PictureBox pblogo;
    }
}