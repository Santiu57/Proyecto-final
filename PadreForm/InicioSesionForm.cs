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
        }

        private bool hasSafefile()
        {
            try
            {
                PadreForm.importacionUsuarios();
                for (int i = 0; i < PadreForm.NombreUsuarios.Count(); i++)
                {
                    cbusuarios.Items.Add(PadreForm.NombreUsuarios[i]);
                }
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
            PadreForm.CambiarColores(this,PadreForm.colorFondo,PadreForm.colorLetra);
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
                    PadreForm.usuarioActual = PadreForm.NombreUsuarios[0];
                    openPadre();
                }
            }
            else
            {
                txbRol.Text = "x"; txbNombre.Text = "x";
                if (dataVerification())
                {
                    int index = cbusuarios.SelectedIndex;
                    int Altindex = PadreForm.NombreUsuarios.IndexOf(txbNombreUsuario.Text);
                    if (index > 0)
                    {
                        if (txbContraseña.Text == PadreForm.Contraseñas[index])
                        {
                            PadreForm.usuarioActual = PadreForm.NombreUsuarios[index];
                            openPadre();
                        }
                    }
                    else
                    {
                        if (txbContraseña.Text == PadreForm.Contraseñas[Altindex])
                        {
                            PadreForm.usuarioActual = PadreForm.NombreUsuarios[Altindex];
                            openPadre();
                        }
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
