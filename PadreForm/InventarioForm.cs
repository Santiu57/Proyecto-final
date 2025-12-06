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
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.AutoScaleControls(this);
        }

        private void fullErase(int index)
        {
            try
            {
                PadreForm.Productos.RemoveAt(index);
                dgvinventario.Rows.RemoveAt(index);
                PadreForm.registraProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openAgregar()
        {
            AñadirForm añadir = new AñadirForm();
            añadir.ShowDialog();
        }

        private void openEditar(int index)
        {
            EditarForm editar = new EditarForm();
            editar.indice = index;
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
                fullErase(dgvinventario.CurrentRow.Index);
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
            actualizarTabla();
            PadreForm.categoriasProductosAdd(cbcategoria);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(dgvinventario.CurrentRow != null)
            openEditar(dgvinventario.CurrentRow.Index);
            PadreForm.fullregistration();
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
