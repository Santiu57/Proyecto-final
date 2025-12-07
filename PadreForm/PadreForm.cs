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

        public static List<Producto> Productos = new List<Producto> { };
        public static List<Usuario> Usuarios = new List<Usuario> { };
        public static List<Ticket> Tickets = new List<Ticket> { };
        public static int numeroTicket = 1000;

        public static string usuarioActual;
        public static string nombreTienda = "Mini Super Kokona";
        public static string direccionTienda = "Alguna";
        public static string rfcTienda = "MSK230606ABC";
        public static System.Drawing.Image logo = null;
        public static Color colorFondo = Color.Black;
        public static Color colorLetra = Color.FromArgb(-50375);
        public static float tamanoLetra = 10f;

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
        public static void SetFontSize(Form form)
        {
            if (form.Tag == null)
                form.Tag = new SizeF(form.Width, form.Height); // Tamaño original del form

            foreach (Control c in form.Controls)
            {
                if (c.Tag == null)
                    c.Tag = new object[] { c.Location, c.Size, c.Font.Size }; // Valores originales

                // Aplicar tamaño de letra global SOLO en el Load
                c.Font = new Font(c.Font.FontFamily, PadreForm.tamanoLetra, c.Font.Style);
            }

            form.Font = new Font(form.Font.FontFamily, PadreForm.tamanoLetra, form.Font.Style);
        }


        public static void EscalarControles(Form form)
        {
            if (form.Tag == null)
                return;

            SizeF originalFormSize = (SizeF)form.Tag;

            float scaleX = form.Width / originalFormSize.Width;
            float scaleY = form.Height / originalFormSize.Height;

            foreach (Control c in form.Controls)
            {
                if (c.Tag is object[] data)
                {
                    Point originalLoc = (Point)data[0];
                    Size originalSize = (Size)data[1];
                    float originalFont = (float)data[2];

                    // Escalar posición
                    c.Location = new Point(
                        (int)(originalLoc.X * scaleX),
                        (int)(originalLoc.Y * scaleY)
                    );

                    // Escalar tamaño
                    c.Size = new Size(
                        (int)(originalSize.Width * scaleX),
                        (int)(originalSize.Height * scaleY)
                    );

                    // Escalar fuente
                    float newFontSize = originalFont * Math.Min(scaleX, scaleY);
                    c.Font = new Font(c.Font.FontFamily, newFontSize, c.Font.Style);
                }
            }
        }


        public static bool noRepeatForms(Form mdiParent, Type formType)
        {
            foreach (Form form in mdiParent.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    form.Activate();
                    return false;
                }
            }
            return true;
        }

        public static void configSafe() // Guarda la configuración en un archivo de texto
        {
            using (var fs = new StreamWriter("Configuracion"))
            {
                string config = nombreTienda + "/" + direccionTienda + "/" + colorFondo.ToArgb() + "/" + colorLetra.ToArgb() + "/" + wmp.settings.volume.ToString() + "/" + numeroTicket.ToString() + "/" + rfcTienda + "/" + tamanoLetra.ToString();
                fs.WriteLine(config);
            }
        }

        public static void importacionConfig() // Importa la configuración desde un archivo de texto
        {
            if (!File.Exists("Configuracion")) return;
            using (var fr = new StreamReader("Configuracion"))
            {
                string linea = fr.ReadLine();
                var valores = linea.Split('/');
                nombreTienda = valores[0];
                direccionTienda = valores[1];
                colorFondo = Color.FromArgb(int.Parse(valores[2]));
                colorLetra = Color.FromArgb(int.Parse(valores[3]));
                wmp.settings.volume = int.Parse(valores[4]);
                numeroTicket = int.Parse(valores[5]);
                rfcTienda = valores[6];
                tamanoLetra = float.Parse(valores[7]);

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

        private static void CrearLogoGenerico() // Crea un logo genérico si no existe uno personalizado
        {
            int w = 200, h = 200;

            using (Bitmap bmp = new Bitmap(w, h))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Gray);
                g.DrawString("LOGO",
                    new Font("Arial", 24, FontStyle.Bold),
                    Brushes.White,
                    new PointF(40, 80));

                bmp.Save("logo.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        public static void registrarTickets() // Guarda los tickets en un archivo de texto
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
                Ticketsfile.WriteLine("RFC|" + t.RFC);
                Ticketsfile.WriteLine("CONTENIDO|");
                Ticketsfile.WriteLine(t.Contenido.TrimEnd());
                Ticketsfile.WriteLine("END_TICKET");
            }
            Ticketsfile.Close();
        }

        public static void registrarUsuarios() // Guarda los usuarios en un archivo de texto
        {
            StreamWriter Usuariosfile = new StreamWriter("Usuarios");
            foreach (var u in Usuarios)
            {
                Usuariosfile.WriteLine(u.NombreUsuario + "/" + u.Contraseña + "/" + u.Rol + "/" + u.Nombre);
            }
            Usuariosfile.Close();
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
                string rfcTienda = "";

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
                    else if (line.StartsWith("RFC|"))
                    {
                        rfcTienda = (line.Substring(4));
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
                        Tickets.Add(new Ticket(contenido, fecha, total, vendedor, numTicket, nombreTienda, direccionTienda,rfcTienda));
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
            Usuario usuario = new Usuario(nombreUsuario, contraseña, rol, nombre);
            Usuarios.Add(usuario);
            registrarUsuarios();
            importacionUsuarios();
        }

        public static void eliminaUsuario(string nombre)
        {
            int indice = -1;
            foreach (var n in Usuarios)
            {
                if(n.NombreUsuario == nombre)
                {
                    indice = Usuarios.IndexOf(n);
                }
            }
            Usuarios.RemoveAt(indice);
            registrarUsuarios();
            importacionUsuarios();
        }

        public static int adminscount()
        {
            int count = 0;
            for (int i = 0; i < Usuarios.Count(); i++)
            {
                if (Usuarios[i].Rol == "Admin")
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
            Usuarios[indice].NombreUsuario = nombreUsuario;
            registrarUsuarios();
            importacionUsuarios();
        }

        public static bool isAdmin() // Verifica si el usuario actual es admin
        {
            foreach (var u in Usuarios)
            {
                if (u.NombreUsuario == usuarioActual)
                {
                    if (u.Rol == "Admin")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No tienes permisos para realizar esta acción.");
                        return false;
                    }
                }
            }
            return false;
        }

        public static void importacionUsuarios()
        {
            Usuarios.Clear();

            if (!File.Exists("Usuarios")) return;

            foreach (var linea in File.ReadAllLines("Usuarios"))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var valores = linea.Split('/');
                Usuario usuario = new Usuario(valores[0], valores[1], valores[2], valores[3]);
                Usuarios.Add(usuario);
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
                Productos.Clear(); 
                using (var leer = new StreamReader("Productos"))
                {
                    string linea;
                    while ((linea = leer.ReadLine()) != null)
                    {
                        var valores = linea.Split('|');
                        Producto producto = new Producto(
                            valores[0],
                            valores[1],
                            valores[2],
                            decimal.Parse(valores[3]),
                            decimal.Parse(valores[4]),
                            int.Parse(valores[5]),
                            valores[6],
                            DateTime.Parse(valores[7])
                        );
                        Productos.Add(producto);
                    }
                }
            }
            catch
            {
                registraProductos();
            }
        }

        public static void categoriasProductosAdd(ComboBox caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < Productos.Count(); i++)
            {
                if (!caja.Items.Contains(Productos[i].Categoria))
                {
                    caja.Items.Add(Productos[i].Categoria);
                }
            }
        }

        public static void usuariosAdd(ComboBox caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < Usuarios.Count(); i++)
            {
                if (!caja.Items.Contains(Usuarios[i].NombreUsuario))
                {
                    caja.Items.Add(Usuarios[i].NombreUsuario);
                }
            }
        }

        public static void rolesUsuariosAdd(ComboBox caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < Usuarios.Count(); i++)
            {
                if (!caja.Items.Contains(Usuarios[i].Rol))
                {
                    caja.Items.Add(Usuarios[i].Rol);
                }
            }
        }

        public static void registraProductos()
        {
            StreamWriter Productosfile = new StreamWriter("Productos");
            foreach (var p in Productos)
            {
                Productosfile.WriteLine(
                    p.Codigo + "|" +
                    p.Nombre + "|" +
                    p.Categoria + "|" +
                    p.PrecioCompra + "|" +
                    p.PrecioVenta + "|" +
                    p.Cantidad + "|" +
                    p.Proveedor + "|" +
                    p.FechaRegistro
                );
            }
            Productosfile.Close();
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

            for (int i = 0; i < Productos.Count; i++)
            {
                bool coincideCategoria = true;
                bool coincideBusqueda = true;

                // Filtrar por categoría
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    coincideCategoria =
                        Productos[i].Categoria.ToUpper().Contains(categoriaFiltro);
                }

                // Filtrar por código o nombre
                if (!string.IsNullOrWhiteSpace(buscador))
                {
                    coincideBusqueda =
                        Productos[i].Codigo.ToUpper().Contains(buscadorFiltro) ||
                        Productos[i].Nombre.ToUpper().Contains(buscadorFiltro) ||
                        Productos[i].Proveedor.ToUpper().Contains(buscadorFiltro);
                }

                // Si cumple ambos filtros
                if (coincideCategoria && coincideBusqueda)
                {
                    tabla.Rows.Add(
                        Productos[i].Codigo,
                        Productos[i].Nombre,
                        Productos[i].Categoria,
                        Productos[i].PrecioCompra,
                        Productos[i].PrecioVenta,
                        Productos[i].Cantidad,
                        Productos[i].Proveedor,
                        Productos[i].FechaRegistro.ToShortDateString()
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

            for (int i = 0; i < Usuarios.Count; i++)
            {
                bool coincideCategoria = true;
                bool coincideBusqueda = true;

                // Filtrar por roles
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    coincideCategoria =
                        Usuarios[i].Rol.ToUpper().Contains(categoriaFiltro);
                }

                // Filtrar por usuario o nombre
                if (!string.IsNullOrWhiteSpace(buscador))
                {
                    coincideBusqueda =
                        Usuarios[i].NombreUsuario.ToUpper().Contains(buscadorFiltro) ||
                        Usuarios[i].Nombre.ToUpper().Contains(buscadorFiltro);
                }

                // Si cumple ambos filtros
                if (coincideCategoria && coincideBusqueda)
                {
                    tabla.Rows.Add(
                        Usuarios[i].NombreUsuario,
                        Usuarios[i].Rol,
                        Usuarios[i].Nombre
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
            if (!noRepeatForms(this, typeof(VentasForm))) return;
            VentasForm ventas = new VentasForm();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void openInventario()
        {
            if (!noRepeatForms(this, typeof(InventarioForm))) return;
            InventarioForm inventario = new InventarioForm();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void openUsuarios()
        {
            if (isAdmin())
            {
                if (!noRepeatForms(this, typeof(UsuariosForm))) return;
                UsuariosForm usuarios = new UsuariosForm();
                usuarios.MdiParent = this;
                usuarios.Show();
            }
        }
        private void openReportes()
        {
            if (!noRepeatForms(this, typeof(ReportesForm))) return;
            ReportesForm reportes = new ReportesForm();
            reportes.MdiParent = this;
            reportes.Show();
        }

        private void PadreForm_Load(object sender, EventArgs e)
        {
            importacionProductos();
            tlslusuarioActual.Text = "Usuario Actual: " + usuarioActual;
            tssUsuarioActual.Text = "Usuario Actual: " + usuarioActual;
            CambiarColores(this, colorLetra, colorFondo);
            SetFontSize(this);
            Play("Polyphonic.mp3");
            try
            {
                PadreForm.importacionTickets();
            }
            catch
            {
                PadreForm.registrarTickets();
            }
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
            configSafe();
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
            if (!noRepeatForms(this, typeof(ConfiguracionForm))) return;
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
            public string RFC { get; set; }

            public Ticket(string contenido, DateTime fecha, decimal total, string vendedor, int numTicket, string nombre, string direccion, string rfc)
            {
                Contenido = contenido;
                FechaCreacion = fecha;
                Total = total;
                Vendedor = vendedor;
                NumTicket = numTicket;
                Nombre = nombre;
                Direccion = direccion;
                RFC = rfc;
            }
        }
        public class Producto
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public int Cantidad { get; set; }
            public string Proveedor { get; set; }
            public DateTime FechaRegistro { get; set; }
            public Producto(string codigo, string nombre, string categoria, decimal precioCompra, decimal precioVenta, int cantidad, string proveedor, DateTime fechaRegistro)
            {
                Codigo = codigo;
                Nombre = nombre;
                Categoria = categoria;
                PrecioCompra = precioCompra;
                PrecioVenta = precioVenta;
                Cantidad = cantidad;
                Proveedor = proveedor;
                FechaRegistro = fechaRegistro;
            }
        }
        public class Usuario
        {
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
            public string Rol { get; set; }
            public string Nombre { get; set; }
            public Usuario(string nombreUsuario, string contraseña, string rol, string nombre)
            {
                NombreUsuario = nombreUsuario;
                Contraseña = contraseña;
                Rol = rol;
                Nombre = nombre;
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
