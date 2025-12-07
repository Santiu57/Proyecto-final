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
    public partial class ConfiguracionForm : Form
    {
        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) //Reemplaza los valores globales
        {
            PadreForm.nombreTienda = txbnombretienda.Text;
            PadreForm.direccionTienda = txbubicaciontienda.Text;
            PadreForm.rfcTienda = txbrfcTienda.Text;
            PadreForm.colorLetra = cdletra.Color;
            PadreForm.colorFondo = cdfondo.Color;
            PadreForm.wmp.settings.volume = trbVolumen.Value;

            if (PadreForm.logo != null)// Si el logo cambio, lo guarda
            {
                try
                {
                    PadreForm.logo.Save("logo.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                catch 
                {
                    
                }
            }

            PadreForm.configSafe();
            Application.Restart();
        }

        private void btnlogo_Click(object sender, EventArgs e)
        {
            if (ofdlogo.ShowDialog() == DialogResult.OK)//Mustra el ofd para el logo y lo guarda
            {
                try
                {
                    if (ofdlogo.FileName == "") return;

                    // Liberar imagen anterior si existe
                    PadreForm.logo?.Dispose();

                    using (var fs = new FileStream(ofdlogo.FileName, FileMode.Open, FileAccess.Read))
                    using (var tmp = Image.FromStream(fs))
                    {
                        // Clonar en un Bitmap independiente del stream
                        PadreForm.logo = new Bitmap(tmp);
                    }

                    pblogo.Image = PadreForm.logo;
                }
                catch
                {

                }
            }
        }
        
        private void btnfondo_Click(object sender, EventArgs e)// muetra el cd para el fondo y cambia el color del pnl como previsualizacion
        {
            cdfondo.ShowDialog();
            pnlfondo.BackColor = cdfondo.Color;
        }

        private void ConfiguracionForm_Load(object sender, EventArgs e)//Asigna los valores globales a los controles para que si solo se actualiza 1 los demas no se reinicien
        {
            PadreForm.CambiarColores(this, PadreForm.colorLetra, PadreForm.colorFondo);
            PadreForm.SetFontSize(this);
            pnlfondo.BackColor = PadreForm.colorFondo;
            pnlletra.BackColor = PadreForm.colorLetra;
            pblogo.Image = PadreForm.logo;
            cdfondo.Color = PadreForm.colorFondo;
            cdletra.Color = PadreForm.colorLetra;
            trbVolumen.Value = PadreForm.wmp.settings.volume;
            tkbLetraTamaño.Value = (int)PadreForm.tamanoLetra;

            txbnombretienda.Text = PadreForm.nombreTienda;
            txbubicaciontienda.Text = PadreForm.direccionTienda;
            txbrfcTienda.Text = PadreForm.rfcTienda;
        }

        private void btnletra_Click(object sender, EventArgs e)// muetra el cd para el letra y cambia el color del pnl como previsualizacion
        {
            cdletra.ShowDialog();
            pnlletra.BackColor = cdletra.Color;
        }


        private void tkbLetraTamaño_MouseUp(object sender, MouseEventArgs e)//Cuando se suelta el click se actualiza el font como previsualizacion
        {
            PadreForm.tamanoLetra = tkbLetraTamaño.Value;
            PadreForm.SetFontSize(this);
        }
    }
}
