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
    public partial class AñadirForm : Form
    {
        public AñadirForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
        }

        private bool allTxbfull()
        {
            if(txbnombre.Text == "")
            {
                MessageBox.Show("Defina el nombre del producto");
                return false;
            }
            if (txbcodigo.Text == "")
            {
                MessageBox.Show("Defina el codigo del producto");
                return false;
            }
            if (txbcategoria.Text == "")
            {
                MessageBox.Show("Defina la categoria del producto");
                return false;
            }
            if (txbPcompra.Text == "")
            {
                MessageBox.Show("Defina el precio de compra del producto");
                return false;
            }
            if (txbPventa.Text == "")
            {
                MessageBox.Show("Defina el precio de venta del producto");
                return false;
            }
            if (txbcategoria.Text == "")
            {
                MessageBox.Show("Defina la cantidad del producto");
                return false;
            }
            if (txbproovedor.Text == "")
            {
                MessageBox.Show("Defina el proovedor del producto");
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txbnombre.Clear(); txbcodigo.Clear(); txbcategoria.Clear(); txbPcompra.Clear(); txbPventa.Clear(); txbCantidad.Clear(); txbproovedor.Clear();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            añadir();
        }

        private void añadir()
        {
            if (allTxbfull())
            {
                PadreForm.Producto producto = new PadreForm.Producto
                (
                    txbcodigo.Text,
                    txbnombre.Text,
                    txbcategoria.Text,
                    decimal.Parse(txbPcompra.Text),
                    decimal.Parse(txbPventa.Text),
                    int.Parse(txbCantidad.Text),
                    txbproovedor.Text,
                    DateTime.Now
                );
                if (!PadreForm.productoRepetido(producto))
                {
                    PadreForm.Productos.Add(producto);
                    PadreForm.categoriasProductosAdd(cbcategoria);
                    PadreForm.fullregistration();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Ya hay otro producto con el mismo codigo");
                }
            }
        }

        private void AñadirForm_Load(object sender, EventArgs e)
        {
            PadreForm.categoriasProductosAdd(cbcategoria);
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            PadreForm.EscalarControles(this);
            this.Icon = PadreForm.ImageToIcon(PadreForm.logo);
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbcategoria, txbcategoria);
        }

        private void AñadirForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                añadir();
            }
        }
    }
}
