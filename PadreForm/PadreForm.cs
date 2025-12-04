using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;
using System.Windows.Forms;

namespace PadreForm
{
    public partial class PadreForm : Form
    {
        public PadreForm()
        {
            InitializeComponent();
        }

        public static string usuarioActual;
        public static List<string> Usuarios = new List<string> { };
        public static List<string> NombreUsuarios = new List<string> { };
        public static List<string> Contraseñas = new List<string> { };
        public static List<string> Roles = new List<string> { };
        public static List<string> Nombres = new List<string> { };

        public static List<string> Productos = new List<string> { };
        public static List<string> Pcodigo = new List<string> { };
        public static List<string> Pnombre = new List<string> { };
        public static List<int> Pcantidad = new List<int> { };
        public static List<string> Pcategoria = new List<string> { };
        public static List<string> Pprecio_compra = new List<string> { };
        public static List<string> Pprecio_venta = new List<string> { };
        public static List<string> Pproovedor = new List<string> { };
        public static List<string> PfechaRegistro = new List<string> { };

        public static List<Ticket> Tickets = new List<Ticket> { };
        public static int numeroTicket = 1000;

        public static string nombreTienda = "Mi Tienda";
        public static string direccionTienda = "Calle Falsa 123";
        public static System.Drawing.Image logo = null;
        public static Color colorFondo = Color.White;
        public static Color colorLetra = Color.Black;

        public static void CambiarColores(Control control, Color fore, Color back)
        {
            // Cambiar color del control actual
            control.ForeColor = fore;

            // Solo cambiar BackColor si no es un TextBox de solo lectura
            control.BackColor = back;

            // Ajustes especiales según el tipo de control
            var dgv = control as DataGridView;
            if (dgv != null)
            {
                dgv.BackgroundColor = back;
                dgv.GridColor = fore;

                dgv.DefaultCellStyle.BackColor = back;
                dgv.DefaultCellStyle.ForeColor = fore;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = back;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = fore;
                dgv.EnableHeadersVisualStyles = false;

                dgv.RowHeadersDefaultCellStyle.BackColor = back;
                dgv.RowHeadersDefaultCellStyle.ForeColor = fore;
            }
            else
            {
                var tb = control as TextBox;
                if (tb != null)
                {
                    if (tb.ReadOnly) tb.BackColor = Color.White;
                    else tb.BackColor = back;
                }
                else
                {
                    var ts = control as ToolStrip;
                    if (ts != null)
                    {
                        ts.BackColor = back;
                        ts.ForeColor = fore;

                        foreach (ToolStripItem item in ts.Items)
                        {
                            item.ForeColor = fore;
                            item.BackColor = back;
                        }
                    }
                }
            }

            // Recursividad: hijos del control
            foreach (Control hijo in control.Controls)
            {
                CambiarColores(hijo, fore, back);
            }
        }

        public static void AutoScaleControls(Form form)
        {
            if (form.Tag == null)
                form.Tag = new SizeF(form.Width, form.Height);

            SizeF originalFormSize = (SizeF)form.Tag;

            float scaleX = form.Width / originalFormSize.Width;
            float scaleY = form.Height / originalFormSize.Height;

            foreach (Control c in form.Controls)
            {
                // Guardar datos originales una sola vez
                if (c.Tag == null)
                    c.Tag = new object[] { c.Width, c.Height, c.Left, c.Top, c.Font.Size };

                object[] data = (object[])c.Tag;

                c.Width = (int)((int)data[0] * scaleX);
                c.Height = (int)((int)data[1] * scaleY);
                c.Left = (int)((int)data[2] * scaleX);
                c.Top = (int)((int)data[3] * scaleY);

                float originalFont = (float)data[4];
                c.Font = new Font(c.Font.FontFamily, originalFont * Math.Min(scaleX, scaleY));

                ScaleChildren(c, scaleX, scaleY);
            }
        }

        private static void ScaleChildren(Control parent, float scaleX, float scaleY)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Tag == null)
                    c.Tag = new object[] { c.Width, c.Height, c.Left, c.Top, c.Font.Size };

                object[] data = (object[])c.Tag;

                c.Width = (int)((int)data[0] * scaleX);
                c.Height = (int)((int)data[1] * scaleY);
                c.Left = (int)((int)data[2] * scaleX);
                c.Top = (int)((int)data[3] * scaleY);

                float originalFont = (float)data[4];
                c.Font = new Font(c.Font.FontFamily, originalFont * Math.Min(scaleX, scaleY));

                if (c.Controls.Count > 0)
                    ScaleChildren(c, scaleX, scaleY);
            }
        }

        private int MaxTicketnumber()
        {
            int Tnum = 1000;
            importacionTickets();
            Tnum += Tickets.Count();
            return Tnum;
        }

        public static void configSafe()
        {
            using (var fs = new StreamWriter("Configuracion"))
            {
                string config = nombreTienda + "/" + direccionTienda + "/" + colorFondo.ToArgb() + "/" + colorLetra.ToArgb() + "/" + wmp.settings.volume.ToString();
                fs.WriteLine(config);
            }
        }

        public static void importacionConfig()
        {
            if (!File.Exists("Configuracion")) return;
            using (var fr = new StreamReader("Configuracion"))
            {
                string linea = fr.ReadLine();
                var valores = linea.Split('/');
                nombreTienda = valores[0];
                direccionTienda = valores[1];
                colorFondo = Color.FromArgb(int.Parse(valores[3]));
                colorLetra = Color.FromArgb(int.Parse(valores[2]));
                wmp.settings.volume = int.Parse(valores[4]);

                try
                {
                    if (File.Exists("logo.png"))
                    {
                        logo = Image.FromFile("logo.png");
                    }
                    else
                    {
                        CrearLogoGenerico();
                        logo = Image.FromFile("logo.png");
                    }
                }
                catch
                {
                    CrearLogoGenerico();
                    logo = Image.FromFile("logo.png");
                }
            }
        }

        private static void CrearLogoGenerico()
        {
            int w = 200, h = 200;

            using (Bitmap bmp = new Bitmap(w, h))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Gray);  // Fondo genérico
                g.DrawString("LOGO",
                    new Font("Arial", 24, FontStyle.Bold),
                    Brushes.White,
                    new PointF(40, 80));

                bmp.Save("logo.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        public static void registrarTickets()
        {
            StreamWriter Ticketsfile = new StreamWriter("Tickets");
            foreach (var t in Tickets)
            {
                Ticketsfile.WriteLine("BEGIN_TICKET");
                Ticketsfile.WriteLine("FECHA|" + t.FechaCreacion);
                Ticketsfile.WriteLine("TOTAL|" + t.Total);
                Ticketsfile.WriteLine("VENDEDOR|" + t.Vendedor);
                Ticketsfile.WriteLine("NUM TICKET|" + t.NumTicket);
                Ticketsfile.WriteLine("TIENDA|" + t.Nombre);
                Ticketsfile.WriteLine("DIRECCION|" + t.Direccion);
                Ticketsfile.WriteLine("CONTENIDO|");
                Ticketsfile.WriteLine(t.Contenido.TrimEnd());
                Ticketsfile.WriteLine("END_TICKET");
            }
            Ticketsfile.Close();
        }

        public static void registrarUsuarios()
        {
            // Sobrescribe el fichero y cierra automáticamente
            File.WriteAllLines("Usuarios", Usuarios);
        }

        public static void importacionTickets()
        {
            try
            {

                if (!File.Exists("Tickets")) return;
                Tickets.Clear();
                StreamReader leer = new StreamReader("Tickets");
                string line;
                string contenido = "";
                DateTime fecha = DateTime.Now;
                decimal total = 0;
                string vendedor = "";
                int numTicket = 0;
                string nombreTienda = "";
                string direccionTienda = "";

                while ((line = leer.ReadLine()) != null)
                {
                    if (line == "BEGIN_TICKET")
                    {
                        contenido = "";
                    }
                    else if (line.StartsWith("FECHA|"))
                    {
                        fecha = DateTime.Parse(line.Substring(6));
                    }
                    else if (line.StartsWith("TOTAL|"))
                    {
                        total = decimal.Parse(line.Substring(6));
                    }
                    else if (line.StartsWith("VENDEDOR|"))
                    {
                        vendedor = line.Substring(9);
                    }
                    else if (line.StartsWith("NUM TICKET|"))
                    {
                        numTicket = int.Parse(line.Substring(11));
                    }
                    else if (line.StartsWith("TIENDA|"))
                    {
                        nombreTienda = (line.Substring(7));
                    }
                    else if (line.StartsWith("DIRECCION|"))
                    {
                        direccionTienda = (line.Substring(10));
                    }
                    else if (line == "CONTENIDO|")
                    {
                        // Leer contenido hasta END_TICKET
                        string cLine;
                        contenido = "";

                        while ((cLine = leer.ReadLine()) != null && cLine != "END_TICKET")
                        {
                            contenido += cLine + Environment.NewLine;
                        }

                        // Guardar ticket
                        Tickets.Add(new Ticket(contenido, fecha, total, vendedor, numTicket, nombreTienda, direccionTienda));
                    }
                }
                leer.Close();
            }
            catch
            {
                registrarTickets();
            }

        }

        public static void registraUsuario(
            string nombreUsuario,
            string contraseña,
            string rol,
            string nombre)
        {
            string usuario = nombreUsuario + "/" + contraseña + "/" + rol + "/" + nombre;
            Usuarios.Add(usuario);
            registrarUsuarios();
            importacionUsuarios();
        }

        public static void eliminaUsuario(int indice)
        {
            Usuarios.RemoveAt(indice);
            registrarUsuarios();
            importacionUsuarios();
        }

        public static int adminscount()
        {
            int count = 0;
            for (int i = 0; i < Roles.Count(); i++)
            {
                if (Roles[i] == "Admin")
                {
                    count++;
                }
            }
            return count;
        }

        public static void modificaUsuario(
            int indice,
            string nombreUsuario,
            string contraseña,
            string rol,
            string nombre)
        {
            string usuario = nombreUsuario + "/" + contraseña + "/" + rol + "/" + nombre;
            Usuarios[indice] = usuario;
            registrarUsuarios();
            importacionUsuarios();
        }

        public static bool isAdmin()
        {
            if (Roles[NombreUsuarios.IndexOf(usuarioActual)] != "Admin")
            {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
                return false;
            }
            return true;
        }

        public static void importacionUsuarios()
        {
            Usuarios.Clear(); NombreUsuarios.Clear(); Contraseñas.Clear(); Roles.Clear(); Nombres.Clear();

            if (!File.Exists("Usuarios")) return;

            foreach (var linea in File.ReadAllLines("Usuarios"))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var valores = linea.Split('/');
                Usuarios.Add(linea);
                NombreUsuarios.Add(valores[0]);
                Contraseñas.Add(valores[1]);
                Roles.Add(valores[2]);
                Nombres.Add(valores[3]);
            }
        }

        public static void importacioTicketsDTG(DataGridView tabla)
        {
            try
            {
                tabla.Rows.Clear();
                for (int i = 0; Tickets.Count() > i; i++)
                {
                    int nuevaFila = tabla.Rows.Add();
                    tabla.Rows[nuevaFila].Cells[0].Value = Tickets[i].FechaCreacion.ToString();
                    tabla.Rows[nuevaFila].Cells[3].Value = Tickets[i].Total.ToString("C2");
                    tabla.Rows[nuevaFila].Cells[1].Value = Tickets[i].Vendedor;
                    tabla.Rows[nuevaFila].Cells[2].Value = Tickets[i].NumTicket.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void importacionUsuariosDTG(DataGridView tabla)
        {
            try
            {
                StreamReader leer = new StreamReader("Usuarios");
                tabla.Rows.Clear();
                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] valores = linea.Split('/');
                    int nuevaFila = tabla.Rows.Add();
                    tabla.Rows[nuevaFila].Cells[0].Value = valores[0];
                    tabla.Rows[nuevaFila].Cells[1].Value = valores[2];
                    tabla.Rows[nuevaFila].Cells[2].Value = valores[3];
                    linea = leer.ReadLine();
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void importacionProductosInventario(DataGridView tabla)
        {
            try
            {
                tabla.Rows.Clear();
                using (var leer = new StreamReader("Productos"))
                {
                    string linea = leer.ReadLine();
                    while (linea != null)
                    {
                        var valores = linea.Split('|');
                        int nuevaFila = tabla.Rows.Add();
                        tabla.Rows[nuevaFila].Cells[0].Value = valores[0];
                        tabla.Rows[nuevaFila].Cells[1].Value = valores[1];
                        tabla.Rows[nuevaFila].Cells[2].Value = valores[2];
                        tabla.Rows[nuevaFila].Cells[3].Value = valores[3];
                        tabla.Rows[nuevaFila].Cells[4].Value = valores[4];
                        tabla.Rows[nuevaFila].Cells[5].Value = valores[5];
                        tabla.Rows[nuevaFila].Cells[6].Value = valores[6];
                        tabla.Rows[nuevaFila].Cells[7].Value = valores[7];
                        linea = leer.ReadLine();
                    }
                } // el StreamReader se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void importacionProductos()
        {
            try
            {
                Productos.Clear(); Pcodigo.Clear(); Pnombre.Clear(); Pcantidad.Clear(); Pcategoria.Clear(); Pprecio_compra.Clear(); Pprecio_venta.Clear(); PfechaRegistro.Clear();
                using (var leer = new StreamReader("Productos"))
                {
                    string linea;
                    while ((linea = leer.ReadLine()) != null)
                    {
                        var valores = linea.Split('|');
                        Productos.Add(linea);
                        Pcodigo.Add(valores[0]);
                        Pnombre.Add(valores[1]);
                        Pcategoria.Add(valores[2]);
                        Pprecio_compra.Add(valores[3]);
                        Pprecio_venta.Add(valores[4]);
                        Pproovedor.Add(valores[6]);
                        PfechaRegistro.Add(valores[7]);


                        int cant;
                        if (int.TryParse(valores[5], out cant)) Pcantidad.Add(cant);
                        else Pcantidad.Add(0);
                    }
                }
            }
            catch
            {
                // aquí el StreamReader ya está cerrado si se lanzó excepción dentro del using
                registraProductos();
            }
        }

        public static void categoriasProductosAdd(ComboBox caja)
        {
            for (int i = 0; i < Pcategoria.Count(); i++)
            {
                if (!caja.Items.Contains(Pcategoria[i]))
                {
                    caja.Items.Add(Pcategoria[i]);
                }
            }
        }

        public static void rolesUsuariosAdd(ComboBox caja)
        {
            for (int i = 0; i < Roles.Count(); i++)
            {
                if (!caja.Items.Contains(Roles[i]))
                {
                    caja.Items.Add(Roles[i]);
                }
            }
        }

        public static void registraProductos()
        {
            // Sobrescribe el fichero con el contenido actual de la lista y cierra inmediatamente.
            File.WriteAllLines("Productos", Productos);
        }

        public static void fullregistration()
        {
            PadreForm.registraProductos();
            PadreForm.importacionProductos();
        }

        public static void FiltrarInventario(
        DataGridView tabla,
        string categoria,
        string buscador)
        {
            tabla.Rows.Clear();

            string categoriaFiltro = categoria?.ToUpper() ?? "";
            string buscadorFiltro = buscador?.ToUpper() ?? "";

            for (int i = 0; i < Pcodigo.Count; i++)
            {
                bool coincideCategoria = true;
                bool coincideBusqueda = true;

                // Filtrar por categoría
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    coincideCategoria =
                        Pcategoria[i].ToUpper().Contains(categoriaFiltro);
                }

                // Filtrar por código o nombre
                if (!string.IsNullOrWhiteSpace(buscador))
                {
                    coincideBusqueda =
                        Pcodigo[i].ToUpper().Contains(buscadorFiltro) ||
                        Pnombre[i].ToUpper().Contains(buscadorFiltro) ||
                        Pproovedor[i].ToUpper().Contains(buscadorFiltro);
                }

                // Si cumple ambos filtros
                if (coincideCategoria && coincideBusqueda)
                {
                    tabla.Rows.Add(
                        Pcodigo[i],
                        Pnombre[i],
                        Pcategoria[i],
                        Pprecio_compra[i],
                        Pprecio_venta[i],
                        Pcantidad[i],
                        Pproovedor[i],
                        PfechaRegistro[i]
                    );
                }
            }
        }

        public static void FiltrarUsuarios(
        DataGridView tabla,
        string categoria,
        string buscador)
        {
            tabla.Rows.Clear();

            string categoriaFiltro = categoria?.ToUpper() ?? "";
            string buscadorFiltro = buscador?.ToUpper() ?? "";

            for (int i = 0; i < NombreUsuarios.Count; i++)
            {
                bool coincideCategoria = true;
                bool coincideBusqueda = true;

                // Filtrar por roles
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    coincideCategoria =
                        Roles[i].ToUpper().Contains(categoriaFiltro);
                }

                // Filtrar por usuario o nombre
                if (!string.IsNullOrWhiteSpace(buscador))
                {
                    coincideBusqueda =
                        NombreUsuarios[i].ToUpper().Contains(buscadorFiltro) ||
                        Nombres[i].ToUpper().Contains(buscadorFiltro);
                }

                // Si cumple ambos filtros
                if (coincideCategoria && coincideBusqueda)
                {
                    tabla.Rows.Add(
                        NombreUsuarios[i],
                        Roles[i],
                        Nombres[i]
                    );
                }
            }
        }


        public static void comboboxToTextbox(ComboBox caja, TextBox cajaTexto)
        {
            if (caja.SelectedItem != null)
            {
                cajaTexto.Text = caja.SelectedItem.ToString();
            }
        }

        private void openVentas()
        {
            VentasForm ventas = new VentasForm();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void openInventario()
        {
            InventarioForm inventario = new InventarioForm();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void openUsuarios()
        {
            if (isAdmin())
            {
                UsuariosForm usuarios = new UsuariosForm();
                usuarios.MdiParent = this;
                usuarios.Show();
            }
        }
        private void openReportes()
        {
            ReportesForm reportes = new ReportesForm();
            reportes.MdiParent = this;
            reportes.Show();
        }

        private void PadreForm_Load(object sender, EventArgs e)
        {
            importacionProductos();
            tlslusuarioActual.Text = "Usuario Actual: " + usuarioActual;
            tssUsuarioActual.Text = "Usuario Actual: " + usuarioActual;
            CambiarColores(this, colorFondo, colorLetra);
            numeroTicket = MaxTicketnumber();
            Play("Polyphonic.mp3");
        }

        // Metodos de los sonidos
        public static WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        public void Play(string archivo)
        {
            string ruta = Path.Combine(Application.StartupPath, "sonidos", archivo);
            wmp.URL = ruta;
            wmp.controls.play();
        }

        private void PadreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tmractualizaciondeDatos_Tick(object sender, EventArgs e)
        {
            tlshora.Text = DateTime.Now.ToLongTimeString();
        }

        private void tlsbVentas_Click(object sender, EventArgs e)
        {
            openVentas();
        }

        private void tlsbinventario_Click(object sender, EventArgs e)
        {
            openInventario();
        }

        private void tlsbreportes_Click(object sender, EventArgs e)
        {
            openReportes();
        }

        private void tlsbusuarios_Click(object sender, EventArgs e)
        {
            openUsuarios();
        }
        private void openConfig()
        {
            if (!isAdmin()) return;
            ConfiguracionForm config = new ConfiguracionForm();
            config.MdiParent = this;
            config.Show();
        }
        public class Ticket
        {
            public string Contenido { get; set; }
            public string Vendedor { get; set; }
            public DateTime FechaCreacion { get; set; }
            public decimal Total { get; set; }
            public int NumTicket { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }

            public Ticket(string contenido, DateTime fecha, decimal total, string vendedor, int numTicket, string nombre, string direccion)
            {
                Contenido = contenido;
                FechaCreacion = fecha;
                Total = total;
                Vendedor = vendedor;
                NumTicket = numTicket;
                Nombre = nombre;
                Direccion = direccion;
            }
        }

        private void tlsbconfiguracion_Click(object sender, EventArgs e)
        {
            openConfig();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isAdmin()) return;
            openConfig();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openVentas();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openInventario();
        }

        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!isAdmin()) return;
            Productos.Clear();
            registraProductos();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUsuarios();
        }

        private void abrirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openReportes();
        }

        private void limpiarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!isAdmin()) return;
            Tickets.Clear();
            registrarTickets();
        }
    }
}


