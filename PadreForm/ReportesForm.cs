using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadreForm
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.AutoScaleControls(this);
        }

        private void openTicket(int index) 
        { 
            TicketForm ticketForm = new TicketForm();
            ticketForm.txbticket.Text = PadreForm.Tickets[index].Contenido;
            ticketForm.ShowDialog();
        }

        private void dgvinventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openTicket(dgvtickets.CurrentRow.Index);
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorFondo, PadreForm.colorLetra);
            try
            {
                PadreForm.importacionTickets();
                PadreForm.importacioTicketsDTG(dgvtickets);
            }
            catch
            {
                PadreForm.registrarTickets();
            }
        }

        private void dgvtickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
