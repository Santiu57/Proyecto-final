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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PadreForm.nombreTienda = txbnombretienda.Text;
            PadreForm.direccionTienda = txbubicaciontienda.Text;
            PadreForm.colorLetra = cdletra.Color;
            PadreForm.colorFondo = cdfondo.Color;
            PadreForm.wmp.settings.volume = trbVolumen.Value;

            if (PadreForm.logo != null)
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
            if (ofdlogo.ShowDialog() == DialogResult.OK)
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
        
        private void btnfondo_Click(object sender, EventArgs e)
        {
            cdfondo.ShowDialog();
            pnlfondo.BackColor = cdfondo.Color;
        }

        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            PadreForm.CambiarColores(this, PadreForm.colorFondo, PadreForm.colorLetra);
            pnlfondo.BackColor = PadreForm.colorLetra; 
            pnlletra.BackColor = PadreForm.colorFondo;
            pblogo.Image = PadreForm.logo;
            cdfondo.Color = PadreForm.colorFondo;
            cdletra.Color = PadreForm.colorLetra;
            trbVolumen.Value = PadreForm.wmp.settings.volume;
        }

        private void btnletra_Click(object sender, EventArgs e)
        {
            cdletra.ShowDialog();
            pnlletra.BackColor = cdletra.Color;
        }
    }
}
