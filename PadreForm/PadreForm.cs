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
using System.Data.SqlTypes;

namespace PadreForm
{
    public partial class PadreForm : Form
    {
        public PadreForm()
        {
            InitializeComponent();
        }

        public static List<Producto> Productos = new List<Producto> { }; //Guarda los productos registrados
        public static List<Usuario> Usuarios = new List<Usuario> { }; //Guarda los usuarios registrados
        public static List<Ticket> Tickets = new List<Ticket> { }; //Guarda los tickets registrados
        public static int numeroTicket = 1000; //Mantiene los numeros de los tickets

        public static string usuarioActual; //Guarda cual es el usuario Actual
        public static string nombreTienda = "Mini Super Kokona";
        public static string direccionTienda = "Alguna";
        public static string rfcTienda = "MSK230606ABC";
        public static System.Drawing.Image logo = null; //Guarda el logo
        public static Color colorFondo = Color.White;
        public static Color colorLetra = Color.FromArgb(-50375);
        public static float tamanoLetra = 10f;
        public static bool musica = true;

        public static void CambiarColores(Control control, Color fore, Color back) //Cambia el color de letra y fondo por los globales
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
                    var pb = control as PictureBox; //si el picture box contiene en el nombre "logo", su imagen se cambiara al logo
                    if (pb != null)
                    {
                        if (pb.Name.Contains("logo"))
                        {
                            pb.Image = logo;
                            pb.Click += (s, e) => PadreForm.Play("cat.mp3");
                        }
                    }
                    else
                    {
                        var btn = control as Button; //Añade sonido al presionar botones
                        if (btn != null)
                        {
                            btn.Click += (s, e) => PadreForm.randomSound(openSounds);
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
                }
            }

            // Recursividad: hijos del control
            foreach (Control hijo in control.Controls)
            {
                CambiarColores(hijo, fore, back);
            }
        }
        public static void SetFontSize(Form form)// Aplica tamaño de letra global
        {
            if (form.Tag == null)
                form.Tag = new SizeF(form.Width, form.Height); // Tamaño original del form

            foreach (Control c in form.Controls)
            {
                if (c.Tag == null)
                    c.Tag = new object[] { c.Location, c.Size, c.Font.Size }; // Valores originales

                
                c.Font = new Font(c.Font.FontFamily, PadreForm.tamanoLetra, c.Font.Style);
            }

            form.Font = new Font(form.Font.FontFamily, PadreForm.tamanoLetra, form.Font.Style);
        }


        public static void EscalarControles(Form form)//Escala los controles al cambiar el tamaño del form
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


        public static bool noRepeatForms(Form mdiParent, Type formType) // Verifica si hay un tipo de form especifico en el PadreForm
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
                string config = nombreTienda + "/" + direccionTienda + "/" + colorFondo.ToArgb() + "/" + colorLetra.ToArgb() + "/" + wmp.settings.volume.ToString() + "/" + numeroTicket.ToString() + "/" + rfcTienda + "/" + tamanoLetra.ToString() + "/" + musica.ToString();
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
                wmpbg.settings.volume = int.Parse(valores[4]) - 20;
                numeroTicket = int.Parse(valores[5]);
                rfcTienda = valores[6];
                tamanoLetra = float.Parse(valores[7]);
                musica = bool.Parse(valores[8]);

                try
                {
                    if (File.Exists("logo.png")) // verifica que haya un logo
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

        public static Icon ImageToIcon(Image img) // Genera un icono dedsde la imagen
        {
            if (img == null)
            {
                CrearLogoGenerico();
                logo = Image.FromFile("logo.png");
                img = logo;
            }
            Bitmap bmp = new Bitmap(img);

            // Convertimos la imagen en un icono a partir del HICON
            Icon icon = Icon.FromHandle(bmp.GetHicon());

            return icon;
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

        public static void importacionTickets() // Importa los tickets desde el archivo de texto
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

        public static bool registraUsuario( // Simplifica la manera de registrar un nuevo usuario
            string nombreUsuario,
            string contraseña,
            string rol,
            string nombre)
        {
            Usuario usuario = new Usuario(nombreUsuario, contraseña, rol, nombre);
            if (!usuarioRepetido(usuario))
            {
                Usuarios.Add(usuario);
                registrarUsuarios();
                importacionUsuarios();
                return true;
            }
            return false;
        }

        public static void eliminaUsuario(string nombre) //Elimina el usuario seleccionado, lo busca por nombre para evitar eliminar el equivocado
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

        public static int adminscount() // devuelve la cantidad de Admins que hay
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

        public static void modificaUsuario( // Simplifica la manera de modificar un Usuario
            int indice,
            string nombreUsuario,
            string contraseña,
            string rol,
            string nombre)
        {
            Usuarios[indice].NombreUsuario = nombreUsuario;
            Usuarios[indice].Contraseña = contraseña;
            Usuarios[indice].Rol = rol;
            Usuarios[indice].Nombre = nombre;
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

        public static void importacionUsuarios()// Importa los usuarios
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

        public static void importacioTicketsDTG(DataGridView tabla) //Inserta ciertos datos a un dtg sobre los tickets
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
        public static void importacionUsuariosDTG(DataGridView tabla) //Inserta ciertos datos a un dtg sobre los Usuarios
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

        public static void importacionProductosInventario(DataGridView tabla)//Inserta todos los datos a un dtg sobre los productos
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

        public static void importacionProductos()// llena la lista de Productos con los datos del archivo de texto
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

        public static void categoriasProductosAdd(ComboBox caja)//Añade todas las categorias existentes en un cb
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

        public static void proveedoresProductosAdd(ComboBox caja)//Añade todas las categorias existentes en un cb
        {
            caja.Items.Clear();
            for (int i = 0; i < Productos.Count(); i++)
            {
                if (!caja.Items.Contains(Productos[i].Proveedor))
                {
                    caja.Items.Add(Productos[i].Proveedor);
                }
            }
        }

        public static void AdminsAdd(ComboBox caja)//Añade todos los Admins existentes en un cb
        {
            caja.Items.Clear();
            for (int i = 0; i < Usuarios.Count(); i++)
            {
                if (!caja.Items.Contains(Usuarios[i].NombreUsuario) && Usuarios[i].Rol == "Admin")
                {
                    caja.Items.Add(Usuarios[i].NombreUsuario);
                }
            }
        }

        public static void usuariosAdd(ComboBox caja)//Añade todos los Usuarios existentes en un cb
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

        public static void rolesUsuariosAdd(ComboBox caja)//Añade todos los Roles existentes en un cb
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

        public static void registraProductos()//Registra los productos en un archivo de texto
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

        public static void fullregistration()//Registra e importa los productos
        {
            PadreForm.registraProductos();
            PadreForm.importacionProductos();
        }

        public static bool productoRepetido(Producto p)//verifica que el producto no tenga el mismo codigo de otro
        {
            foreach(var pr in Productos)
            {
                if(pr.Codigo == p.Codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool usuarioRepetido(Usuario u)//verifica que el usuario no tenga el mismo Nombre de Usuario de otro
        {
            foreach (var us in Usuarios)
            {
                if (us.NombreUsuario == u.NombreUsuario)
                {
                    MessageBox.Show("Ya hay otro usuario con el mismo nombre de usuario");
                    return true;
                }
            }
            return false;
        }

        public static void FiltrarInventario(//Filtro para el inventario de productos
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

                // Filtrar por código, nombre o proveedor
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

        public static void FiltrarUsuarios(//Filtro para Usuarios
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

        public static void onlynums(KeyPressEventArgs e, object sender)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Evitar dos puntos decimales
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }



        public static void comboboxToTextbox(ComboBox c, TextBox t)//Establece el texto del txb al del cb
        {
            if (c.SelectedItem != null)
            {
                t.Text = c.SelectedItem.ToString();
            }
        }

        private void openVentas()//Abre el form Ventas como hijo del padreForm si no esta ya abierto
        {
            if (!noRepeatForms(this, typeof(VentasForm))) return;
            VentasForm ventas = new VentasForm();
            ventas.MdiParent = this;
            ventas.Show();
            randomSound(openSounds);
        }

        private void openInventario()//Abre el form Inventario como hijo del padreForm si no esta ya abierto
        {
            if (!noRepeatForms(this, typeof(InventarioForm))) return;
            InventarioForm inventario = new InventarioForm();
            inventario.MdiParent = this;
            inventario.Show();
            randomSound(openSounds);
        }

        private void openUsuarios()//Abre el form Usuarios como hijo del padreForm si no esta ya abierto y si eres Admin
        {
            if (isAdmin())
            {
                if (!noRepeatForms(this, typeof(UsuariosForm))) return;
                UsuariosForm usuarios = new UsuariosForm();
                usuarios.MdiParent = this;
                usuarios.Show();
                randomSound(openSounds);
            }
        }
        private void openReportes()//Abre el form Reportes como hijo del padreForm si no esta ya abierto
        {
            if (!noRepeatForms(this, typeof(ReportesForm))) return;
            ReportesForm reportes = new ReportesForm();
            reportes.MdiParent = this;
            reportes.Show();
            randomSound(openSounds);
        }

        private void PadreForm_Load(object sender, EventArgs e)
        {
            importacionProductos();
            tlslusuarioActual.Text = "Usuario Actual: " + usuarioActual;
            tssUsuarioActual.Text = "Usuario Actual: " + usuarioActual;
            CambiarColores(this, colorLetra, colorFondo);
            SetFontSize(this);
            this.Icon = ImageToIcon(logo);
            this.Text = nombreTienda;
            if (musica)
            {
                PlayBg("Irasshaimase.mp3");
            }
            try //Carga los tickets desde antes por si se hace una venta antes de abrir los tickets
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
        public static WindowsMediaPlayer wmpbg = new WindowsMediaPlayer();
        public static List<string> openSounds = new List<string> {"open1.mp3", "open2.mp3", "open3.mp3", "open4.mp3"};
        public static List<string> closeSounds = new List<string> {"close1.mp3", "close2.mp3"};
        public static void randomSound(List<string> soundList) //Reproduce un sonido aleatorio de la lista proporcionada
        {
            Random rng = new Random();
            int ran = rng.Next(0, soundList.Count());
            Play(soundList[ran]);
        }
        public static void Play(string archivo) //Reproduce un sonido especifico de la carpeta "sonidos"
        {
            string rutaBase = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string ruta = Path.Combine(rutaBase, "sonidos", archivo);
            wmp.URL = ruta;
            wmp.controls.play();
        }
        public static void PlayBg(string archivo) //Reproduce un sonido especifico de la carpeta "sonidos"
        {
            string rutaBase = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string ruta = Path.Combine(rutaBase, "sonidos", archivo);
            wmpbg.settings.setMode("loop", true);
            wmpbg.URL = ruta;
            wmpbg.controls.play();
        }

        private void PadreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            randomSound(closeSounds);
            configSafe();
            Application.Exit();
        }

        private void tmractualizaciondeDatos_Tick(object sender, EventArgs e) //Timer que solo actualiza la hora
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
        private void openConfig()//Abre el form Condiguracion como hijo del padreForm si no esta ya abierto y si el usuario es admin
        {
            if (!noRepeatForms(this, typeof(ConfiguracionForm))) return;
            if (!isAdmin()) return;
            ConfiguracionForm config = new ConfiguracionForm();
            config.MdiParent = this;
            config.Show();
            randomSound(openSounds);
        }

        //Clases
        public class Ticket //Para guardar todos los datos de los tickets
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
        public class Producto //Para guardar todos los datos de los productos
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
        public class Usuario //Para guardar todos los datos de los Usuarios
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

        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)//si el usuario es admin puede limpiar todos los productos
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

        private void limpiarToolStripMenuItem3_Click(object sender, EventArgs e)//si el usuario es admin puede limpiar todos los tickets, el numero de ticket no se ve afectado
        {
            if (!isAdmin()) return;
            Tickets.Clear();
            registrarTickets();
        }

        private void tsbCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
