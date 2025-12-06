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
    public partial class EditarForm : Form
    {
        public EditarForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.AutoScaleControls(this);
        }

        public int indice = -1;

        private void EditarForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.categoriasProductosAdd(cbcategoria);
            if (indice != -1)
            {
                txbcodigo.Text = PadreForm.Productos[indice].Codigo;
                txbnombre.Text = PadreForm.Productos[indice].Nombre;
                txbcategoria.Text = PadreForm.Productos[indice].Categoria;
                txbPcompra.Text = PadreForm.Productos[indice].PrecioCompra.ToString();
                txbPventa.Text = PadreForm.Productos[indice].PrecioVenta.ToString();
                txbCantidad.Text = PadreForm.Productos[indice].Cantidad.ToString();
                txbproovedor.Text = PadreForm.Productos[indice].Proveedor;
            }
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbcategoria, txbcategoria);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            PadreForm.Productos[indice].Codigo = txbcodigo.Text;
            PadreForm.Productos[indice].Nombre = txbnombre.Text;
            PadreForm.Productos[indice].Categoria = txbcategoria.Text;
            PadreForm.Productos[indice].PrecioCompra = decimal.Parse(txbPcompra.Text);
            PadreForm.Productos[indice].PrecioVenta = decimal.Parse(txbPventa.Text);
            PadreForm.Productos[indice].Cantidad = int.Parse(txbCantidad.Text);
            PadreForm.Productos[indice].Proveedor = txbproovedor.Text;
            PadreForm.Productos[indice].FechaRegistro = DateTime.Now;
            this.Close();
        }
    }
}
