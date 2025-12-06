using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PadreForm
{
    public partial class InicioSesionForm : Form
    {
        public InicioSesionForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.AutoScaleControls(this);
        }

        private bool hasSafefile()
        {
            try
            {
                PadreForm.importacionUsuarios();
                PadreForm.usuariosAdd(cbusuarios);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void firstSesion()
        {
            lblSesion.Text = "Registre Primer usuario";
            cbusuarios.Visible = false;
            txbRol.Text = "Admin";
            txbRol.ReadOnly = true;
            txbRol.Visible = true;
            txbNombre.Visible = true;
            lblrol.Visible = true;
            lblnombre.Visible = true;
            lblSesion.Location = new Point(12, 42);
            btnAceptar.Location = new Point(80, 204);
        }

        private bool dataVerification()
        {
            if(txbNombreUsuario.Text != "" && txbContraseña.Text != "" && txbRol.Text != "" && txbNombre.Text != "")
            {
                return true;
            }
            return false;
        }

        private bool isFirstSesion()
        {
            if (hasSafefile() == false || cbusuarios.Items.Count == 0)
            {
                return true;
            }
            return false;
        }

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {
            PadreForm.importacionConfig();
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            if (isFirstSesion())
            {
                firstSesion();
            }
            else
            {
                txbNombreUsuario.ReadOnly = true;
            }
        }

        private void openPadre()
        {
            this.Hide();
            PadreForm papa = new PadreForm();
            papa.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (isFirstSesion())
            {
                if (dataVerification())
                {

                    PadreForm.registraUsuario(txbNombreUsuario.Text, txbContraseña.Text, txbRol.Text, txbNombre.Text);
                    PadreForm.usuarioActual = PadreForm.Usuarios[0].NombreUsuario;
                    openPadre();
                }
            }
            else
            {
                txbRol.Text = "x"; txbNombre.Text = "x";
                if (dataVerification())
                {
                    int index = cbusuarios.SelectedIndex;
                    if (txbContraseña.Text == PadreForm.Usuarios[index].Contraseña)
                    {
                        PadreForm.usuarioActual = PadreForm.Usuarios[index].NombreUsuario;
                        openPadre();
                    } 
                }
            }
        }

        private void cbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbusuarios, txbNombreUsuario);
        }
    }
}
