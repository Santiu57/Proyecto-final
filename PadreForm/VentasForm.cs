using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PadreForm.PadreForm;

namespace PadreForm
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
        }
        private void VentasForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            PadreForm.categoriasProductosAdd(cbcategoria);
            PadreForm.importacionProductosInventario(dgvinventarioventas);
            PadreForm.fullregistration();
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarInventario(dgvinventarioventas, cbcategoria.Text, txbbuscador.Text);
        }

        private void txbbuscador_TextChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarInventario(dgvinventarioventas, cbcategoria.Text, txbbuscador.Text);
        }
        private void AgregarProductoAVenta(string nombre, string precio)
        {
            foreach (DataGridViewRow fila in dgvproductosregistrados.Rows)
            {
                if (fila.Cells[0].Value != null &&
                    fila.Cells[0].Value.ToString() == nombre)
                {
                    int cant = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                    fila.Cells[2].Value = cant + 1;
                    return;
                }
            }

            dgvproductosregistrados.Rows.Add(nombre, precio, 1);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!PadreForm.isAdmin())
            {
                return;
            }

            if (dgvproductosregistrados.CurrentRow == null) return;

            string nombre = dgvproductosregistrados.CurrentRow.Cells[0].Value.ToString();
            int cantidadCarrito = int.Parse(dgvproductosregistrados.CurrentRow.Cells[2].Value.ToString());

            // Regresar inventario
            foreach (DataGridViewRow filaInv in dgvinventarioventas.Rows)
            {
                if (filaInv.Cells[1].Value.ToString() == nombre)
                {
                    int existencias = int.Parse(filaInv.Cells[3].Value.ToString());
                    filaInv.Cells[3].Value = existencias + cantidadCarrito;
                    break;
                }
            }

            dgvproductosregistrados.Rows.Remove(dgvproductosregistrados.CurrentRow);
            PadreForm.importacionProductosInventario(dgvinventarioventas);

            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvproductosregistrados.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[2].Value != null)
                {
                    decimal precio = decimal.Parse(fila.Cells[1].Value.ToString());
                    int cantidad = int.Parse(fila.Cells[2].Value.ToString());
                    total += precio * cantidad;
                }
            }

            lbltotal.Text = total.ToString("C");
        }

        private void FinalizarVenta(DataGridView tablaVenta)
        {
            try
            {
                for (int i = 0; i < tablaVenta.Rows.Count; i++)
                {
                    string nombre = tablaVenta.Rows[i].Cells[0].Value.ToString();
                    int cantidadVendida = int.Parse(tablaVenta.Rows[i].Cells[2].Value.ToString());

                    // Buscar producto en la lista
                    foreach (var p in Productos)
                    {
                        if(p.Nombre == nombre)
                        {
                            int index = Productos.IndexOf(p);
                            p.Cantidad -= cantidadVendida;
                            guardarCambios(index, nombre);
                            lbltotal.Text = "$0.00";
                        }
                    }
                }

                //limpiar tabla de venta
                tablaVenta.Rows.Clear();

                // Guardar cambios
                PadreForm.fullregistration();
                MessageBox.Show("Venta finalizada con Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar la venta: " + ex.Message);
            }
        }

        private static void guardarCambios(int index, string nombre)
        {
            PadreForm.registraProductos();
        }

        public static void GenerarTicket(DataGridView tablaVenta)
        {
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("====== TICKET DE COMPRA ======");
            ticket.AppendLine("Fecha: " + DateTime.Now.ToString());
            ticket.AppendLine("Vendedor: " + PadreForm.usuarioActual);
            ticket.AppendLine("Ticket: " + PadreForm.numeroTicket);
            ticket.AppendLine("Tienda: " + PadreForm.nombreTienda);
            ticket.AppendLine("Direccion: " + PadreForm.direccionTienda);
            ticket.AppendLine("RFC: " + PadreForm.rfcTienda);
            ticket.AppendLine("-------------------------------");

            double total = 0;

            for (int i = 0; i < tablaVenta.Rows.Count; i++)
            {
                string nombre = tablaVenta.Rows[i].Cells[0].Value.ToString();
                int cantidad = int.Parse(tablaVenta.Rows[i].Cells[2].Value.ToString());
                double precio = double.Parse(tablaVenta.Rows[i].Cells[1].Value.ToString());

                double subtotal = cantidad * precio;
                total += subtotal;

                ticket.AppendLine($"{nombre} x{cantidad}  = ${subtotal}");
            }

            ticket.AppendLine("-------------------------------");
            ticket.AppendLine("TOTAL: $" + total);
            ticket.AppendLine("===============================");

            // Guardar el ticket
            var newticket = new PadreForm.Ticket
            (
                ticket.ToString(),
                DateTime.Now,
                (decimal)total,
                PadreForm.usuarioActual, 
                PadreForm.numeroTicket,
                PadreForm.nombreTienda,
                PadreForm.direccionTienda,
                PadreForm.rfcTienda
            );
            PadreForm.Tickets.Add(newticket);
            PadreForm.registrarTickets();
            PadreForm.importacionTickets();
            PadreForm.numeroTicket++;

        }

        private void btnfinalizarVenta_Click(object sender, EventArgs e)
        {
            GenerarTicket(dgvproductosregistrados);
            FinalizarVenta(dgvproductosregistrados);
        }

        private void VentasForm_Activated(object sender, EventArgs e)
        {
            PadreForm.categoriasProductosAdd(cbcategoria);
            PadreForm.importacionProductosInventario(dgvinventarioventas);
            PadreForm.fullregistration();
        }

        private void dgvinventarioventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvinventarioventas.Rows[e.RowIndex];

            string nombre = fila.Cells[1].Value.ToString();
            string precio = fila.Cells[4].Value.ToString();
            int cantidadInventario = int.Parse(fila.Cells[5].Value.ToString());

            if (cantidadInventario <= 0)
            {
                MessageBox.Show("No hay existencias de este producto.");
                return;
            }

            AgregarProductoAVenta(nombre, precio);

            fila.Cells[5].Value = cantidadInventario - 1;

            CalcularTotal();
        }

        // Para que al presionar (CTRL + Enter) Finalize la venta
        HashSet<Keys> teclasPresionadas = new HashSet<Keys>();
        private void VentasForm_KeyDown(object sender, KeyEventArgs e)
        {
            teclasPresionadas.Add(e.KeyCode);

            if (teclasPresionadas.Contains(Keys.ControlKey) &&
                teclasPresionadas.Contains(Keys.Enter))
            {
                GenerarTicket(dgvproductosregistrados);
                FinalizarVenta(dgvproductosregistrados);
            }
        }

        private void VentasForm_KeyUp(object sender, KeyEventArgs e)
        {
            teclasPresionadas.Remove(e.KeyCode);
        }
    }
}
