using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadreForm.Miniforms
{
    public partial class AccesoForm : Form
    {
        public AccesoForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
            this.FormClosed += (s, e) => PadreForm.randomSound(PadreForm.closeSounds);
        }

        private void AccesoForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            PadreForm.EscalarControles(this);
            PadreForm.AdminsAdd(cbadmins);
        }

        private void Aceptar() //verifica que la contraseña del usuario sea correcta
        {
            string admin = txbNombreUsuario.Text;
            foreach (var n in PadreForm.Usuarios)
            {
                if(n.NombreUsuario == admin)
                {
                    if(n.Contraseña == txbContraseña.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void AccesoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Aceptar();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void cbadmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbadmins, txbNombreUsuario);
        }
    }
}
