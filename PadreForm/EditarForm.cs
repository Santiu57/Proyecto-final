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
            PadreForm.CambiarColores(this, PadreForm.colorFondo, PadreForm.colorLetra);
            PadreForm.categoriasProductosAdd(cbcategoria);
            if (indice != -1)
            {
                string[] producto = PadreForm.Productos[indice].Split('|');
                txbcodigo.Text = producto[0];
                txbnombre.Text = producto[1];
                txbcategoria.Text = producto[2];
                txbPcompra.Text = producto[3];
                txbPventa.Text = producto[4];
                txbCantidad.Text = producto[5];
                txbproovedor.Text = producto[6];
            }
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbcategoria, txbcategoria);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string producto = txbcodigo.Text + "|" + txbnombre.Text + "|" + txbcategoria.Text + "|" + txbPcompra.Text + "|" + txbPventa.Text + "|" + txbCantidad.Text + "|" + txbproovedor.Text + "|" + DateTime.Now.ToString();
            PadreForm.Productos[indice] = producto;
            this.Close();
        }
    }
}
