using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PadreForm.PadreForm;

namespace PadreForm
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
        }

        private void fullErase(string producto)
        {
            try
            {
                int index = getProductIndex(producto);
                PadreForm.Productos.RemoveAt(index);
                PadreForm.registraProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getProductIndex(string nombre)
        {
            int index = -1;
            foreach (var p in PadreForm.Productos)
            {
                if (p.Codigo == nombre)
                {
                    index = PadreForm.Productos.IndexOf(p);
                    break;
                }
            }
            return index;
        }

        private void openAgregar()
        {
            AñadirForm añadir = new AñadirForm();
            añadir.ShowDialog();
        }

        private void openEditar(string nombre)
        {
            EditarForm editar = new EditarForm();
            editar.indice = getProductIndex(nombre);
            editar.ShowDialog();
        }

        private void actualizarTabla()
        {
            PadreForm.importacionProductosInventario(dgvinventario);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                string producto = dgvinventario.CurrentRow.Cells[0].Value.ToString();
                fullErase(producto);
                dgvinventario.Rows.RemoveAt(dgvinventario.CurrentRow.Index);
                PadreForm.fullregistration();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            openAgregar();
            actualizarTabla();
            PadreForm.fullregistration();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            actualizarTabla();
            PadreForm.categoriasProductosAdd(cbcategoria);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(dgvinventario.CurrentRow != null)
                openEditar(dgvinventario.CurrentRow.Cells[0].Value.ToString());
                PadreForm.fullregistration();
                actualizarTabla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarInventario(dgvinventario, cbcategoria.Text, txbbuscador.Text);
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarInventario(dgvinventario, cbcategoria.Text, txbbuscador.Text);
        }

        private void InventarioForm_Activated(object sender, EventArgs e)
        {
            actualizarTabla();
            PadreForm.categoriasProductosAdd(cbcategoria);
        }
    }
}
