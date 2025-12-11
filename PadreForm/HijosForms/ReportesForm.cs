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
            PadreForm.usuariosAdd(cbusuarios);
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            dtpfecha.Value = DateTime.Now;
            ActDatos();
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

        private void ActDatos()
        {
            string dia = dtpfecha.Value.ToShortDateString();
            decimal total = 0;
            int prods = 0;
            decimal Dtotal = 0;
            int Dprods = 0;
            foreach (var t in PadreForm.Tickets)
            {
                string Tdia = t.FechaCreacion.ToShortDateString();
                total += t.Total;
                prods += t.CProductos;
                if(dia == Tdia)
                {
                    Dtotal += t.Total;
                    Dprods += t.CProductos;
                }
            }
            lblproductostotalesvendidos.Text = prods.ToString() + " Productos";
            lblventastotales.Text = total.ToString("C");
            lblventasdia.Text = Dtotal.ToString("C");
            lblproductosvendidos.Text = Dprods.ToString() + " Productos";
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
            PadreForm.usuariosAdd(cbusuarios);
            ActDatos();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarTickets(dgvtickets, cbusuarios.Text, dtpfecha.Value.ToShortDateString(), txbnumTicket.Text);
            ActDatos();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarTickets(dgvtickets, cbusuarios.Text, dtpfecha.Value.ToShortDateString(), txbnumTicket.Text);
            ActDatos();
        }

        private void txbnumTicket_TextChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarTickets(dgvtickets, cbusuarios.Text, dtpfecha.Value.ToShortDateString(), txbnumTicket.Text);
        }
    }
}
