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
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
            this.FormClosed += (s, e) => PadreForm.randomSound(PadreForm.closeSounds);
        }

        private void openTicket(int numTicket) //Abre el ticet en el ticket Form, buscando por numero de ticket
        {
            PadreForm.randomSound(PadreForm.openSounds);

            TicketForm ticketForm = new TicketForm();
            
            int index = -1;

            for (int i = 0; i < PadreForm.Tickets.Count; i++)
            {
                if (PadreForm.Tickets[i].NumTicket == numTicket)
                {
                    index = i;
                    break;
                }
            }

            ticketForm.txbticket.Text = PadreForm.Tickets[index].Contenido;
            ticketForm.ShowDialog();
        }

        private void dgvinventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
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

        private void dgvtickets_CellContentClick(object sender, DataGridViewCellEventArgs e) //Al clickear en el contenido del dtg, abre su respectivo ticket
        {
            try
            {
                int ticketnumero = 0;

                var value = dgvtickets.Rows[e.RowIndex].Cells[2].Value;

                int n = -1;
                if (value != null && int.TryParse(value.ToString(), out n))
                {
                    ticketnumero = n;
                }
                openTicket(ticketnumero);
            }
            catch
            {
            }
        }

        private void ReportesForm_Activated(object sender, EventArgs e)//Cuando el form recupeta el foco, se actualiza
        {
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
    }
}
