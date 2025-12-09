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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
            this.Resize += (s, e) => PadreForm.EscalarControles(this);
            this.FormClosed += (s, e) => PadreForm.randomSound(PadreForm.closeSounds);
        }

        private void abrirAgregarUsuario()
        {
            PadreForm.randomSound(PadreForm.openSounds);
            AgregarUsuarioForm agregarUsuario = new AgregarUsuarioForm();
            agregarUsuario.ShowDialog();
        }

        private void abrirEditarUsuario(int index) //Abre editar usuarios, mandando toda la informacion del usuario
        {
            PadreForm.randomSound(PadreForm.openSounds);
            EditarUsuarioForm editarUsuario = new EditarUsuarioForm();
            editarUsuario.indice = index;
            editarUsuario.ShowDialog();
        }
        private void txbbuscador_TextChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarUsuarios(dgvusuarios, cbrol.Text, txbbuscador.Text);
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            PadreForm.rolesUsuariosAdd(cbrol);
            PadreForm.importacionUsuariosDTG(dgvusuarios);
        }

        private void cbrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            PadreForm.FiltrarUsuarios(dgvusuarios, cbrol.Text, txbbuscador.Text);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            abrirAgregarUsuario();
            PadreForm.importacionUsuariosDTG(dgvusuarios);
            PadreForm.rolesUsuariosAdd(cbrol);
        }

        private void btnborrar_Click(object sender, EventArgs e)//Elimina el usuario, si es admin hay confirmacion, y si es el Usuario actual reinicia
        {
            string nombreUsuario = dgvusuarios.CurrentRow.Cells[0].Value.ToString();
            if (dgvusuarios.CurrentRow.Cells[1].Value.ToString() == "Admin")
            {
                if (MessageBox.Show("Este usuario es un administrador, ¿Está seguro de eliminarlo?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool restart = false;
                    if (PadreForm.usuarioActual == dgvusuarios.CurrentRow.Cells[0].Value.ToString())
                    {
                        restart = true;
                    }
                    PadreForm.eliminaUsuario(nombreUsuario);
                    PadreForm.importacionUsuariosDTG(dgvusuarios);
                    MessageBox.Show("Se ha eliminado el usuario");
                    PadreForm.rolesUsuariosAdd(cbrol);
                    if (restart)
                    {
                        Application.Restart();
                    }
                }
            }
            else
            {
                PadreForm.eliminaUsuario(nombreUsuario);
                PadreForm.importacionUsuariosDTG(dgvusuarios);
                MessageBox.Show("Se ha eliminado el usuario");
                PadreForm.rolesUsuariosAdd(cbrol);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            abrirEditarUsuario(dgvusuarios.CurrentRow.Index);
            PadreForm.importacionUsuariosDTG(dgvusuarios);
            PadreForm.rolesUsuariosAdd(cbrol);
        }

        private void UsuariosForm_Activated(object sender, EventArgs e)
        {
            PadreForm.rolesUsuariosAdd(cbrol);
            PadreForm.importacionUsuariosDTG(dgvusuarios);
        }
    }
}
