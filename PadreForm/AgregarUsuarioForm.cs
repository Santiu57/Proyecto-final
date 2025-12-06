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
    public partial class AgregarUsuarioForm : Form
    {
        public AgregarUsuarioForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.AutoScaleControls(this);
        }

        private void allfieldsfilled()
        {
            if(txbContraseña.Text != "" && txbNombre.Text != "" && txbNombreUsuario.Text != "" && txbRol.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PadreForm.registraUsuario(txbNombreUsuario.Text, txbContraseña.Text, txbRol.Text, txbNombre.Text);
            txbContraseña.Clear(); txbNombre.Clear(); txbNombreUsuario.Clear(); txbRol.Clear();
        }

        private void txbNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            allfieldsfilled();
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {
            allfieldsfilled();
        }

        private void txbRol_TextChanged(object sender, EventArgs e)
        {
            allfieldsfilled();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            allfieldsfilled();
        }

        private void AgregarUsuarioForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
        }
    }
}
