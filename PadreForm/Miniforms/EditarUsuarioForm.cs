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
    public partial class EditarUsuarioForm : Form
    {
        public EditarUsuarioForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
        }

        public int indice;
        public string nombreUsuario, contraseña, rol, nombre;
        bool esAdmin;

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

        private void EditarUsuarioForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                editar();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            editar();
        }
        private void editar()//Edita los datos, si no hay mas de 1 admin no se le puede quitar el rol
        {
            if (esAdmin && txbRol.Text != "Admin" && PadreForm.adminscount() <= 1)
            {
                MessageBox.Show("No puede cambiar el rol de un administrador sin haber otro");
                return;
            }
            PadreForm.modificaUsuario(indice, txbNombreUsuario.Text, txbContraseña.Text, txbRol.Text, txbNombre.Text);
            this.Close();
        }

        private void allfieldsfilled() //Verifica que todos los campos esten llenos
        {
            if (txbContraseña.Text != "" && txbNombre.Text != "" && txbNombreUsuario.Text != "" && txbRol.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
        private void EditarUsuarioForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            PadreForm.EscalarControles(this);
            this.Icon = PadreForm.ImageToIcon(PadreForm.logo);
            txbContraseña.Text = contraseña; //Llena los campos con los datos del usuario
            txbNombre.Text = nombre;
            txbNombreUsuario.Text = nombreUsuario;
            txbRol.Text = rol;
            if (rol == "Admin")
            {
                esAdmin = true;
            }
        }
    }
}
