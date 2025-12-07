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

        private bool hasSafefile() //Intenta importar los usuarios y meterlos en el cb
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

        private void firstSesion()//Configuracion para una primera sesion
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

        private bool dataVerification()//verifica que los campos esten llenos
        {
            if(txbNombreUsuario.Text != "" && txbContraseña.Text != "" && txbRol.Text != "" && txbNombre.Text != "")
            {
                return true;
            }
            return false;
        }

        private bool isFirstSesion()//Verifica si es la primera sesion
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
            PadreForm.SetFontSize(this);
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            if (isFirstSesion())//Si es primera sesion se carga la configuracion de primera sesion
            {
                firstSesion();
            }
            else
            {
                txbNombreUsuario.ReadOnly = true;
            }
        }

        private void openPadre()//habre el papá
        {
            this.Hide();
            PadreForm papa = new PadreForm();
            papa.Show();
        }
        
        private void Aceptar()
        {
            if (isFirstSesion())//registra el primer usuario y habre el papa
            {
                if (dataVerification())
                {

                    PadreForm.registraUsuario(txbNombreUsuario.Text, txbContraseña.Text, txbRol.Text, txbNombre.Text);
                    PadreForm.usuarioActual = PadreForm.Usuarios[0].NombreUsuario;
                    openPadre();
                }
            }
            else //Verifica que la contraseña del usuario seleccionado sea correcta
            {
                txbRol.Text = "x"; txbNombre.Text = "x";
                if (dataVerification())
                {
                    int index = -1;
                    foreach (var n in PadreForm.Usuarios)
                    {
                        if (n.NombreUsuario == txbNombreUsuario.Text)
                        {
                            index = PadreForm.Usuarios.IndexOf(n);
                            break;
                        }
                    }
                    if (txbContraseña.Text == PadreForm.Usuarios[index].Contraseña)
                    {
                        PadreForm.usuarioActual = PadreForm.Usuarios[index].NombreUsuario;
                        openPadre();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void cbusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.comboboxToTextbox(cbusuarios, txbNombreUsuario);
        }

        private void InicioSesionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Aceptar();
            }
        }
    }
}
