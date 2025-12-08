namespace PadreForm
{
    partial class PadreForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PadreForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlshora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsbVentas = new System.Windows.Forms.ToolStripButton();
            this.tlsbinventario = new System.Windows.Forms.ToolStripButton();
            this.tlsbreportes = new System.Windows.Forms.ToolStripButton();
            this.tlsbusuarios = new System.Windows.Forms.ToolStripButton();
            this.tlsbconfiguracion = new System.Windows.Forms.ToolStripButton();
            this.tlslusuarioActual = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmractualizaciondeDatos = new System.Windows.Forms.Timer(this.components);
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsuarioActual,
            this.tlshora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1332, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsuarioActual
            // 
            this.tssUsuarioActual.Name = "tssUsuarioActual";
            this.tssUsuarioActual.Size = new System.Drawing.Size(108, 20);
            this.tssUsuarioActual.Text = "Usuario Actual:";
            // 
            // tlshora
            // 
            this.tlshora.Name = "tlshora";
            this.tlshora.Size = new System.Drawing.Size(69, 20);
            this.tlshora.Text = "00/00/00";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbVentas,
            this.tlsbinventario,
            this.tlsbreportes,
            this.tlsbusuarios,
            this.tlsbconfiguracion,
            this.tsbCerrarSesion,
            this.tlslusuarioActual});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1332, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsbVentas
            // 
            this.tlsbVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbVentas.Image = ((System.Drawing.Image)(resources.GetObject("tlsbVentas.Image")));
            this.tlsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbVentas.Name = "tlsbVentas";
            this.tlsbVentas.Size = new System.Drawing.Size(29, 24);
            this.tlsbVentas.Text = "toolStripButton1";
            this.tlsbVentas.ToolTipText = "Ventas";
            this.tlsbVentas.Click += new System.EventHandler(this.tlsbVentas_Click);
            // 
            // tlsbinventario
            // 
            this.tlsbinventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbinventario.Image = ((System.Drawing.Image)(resources.GetObject("tlsbinventario.Image")));
            this.tlsbinventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbinventario.Name = "tlsbinventario";
            this.tlsbinventario.Size = new System.Drawing.Size(29, 24);
            this.tlsbinventario.Text = "toolStripButton2";
            this.tlsbinventario.ToolTipText = "Inventario";
            this.tlsbinventario.Click += new System.EventHandler(this.tlsbinventario_Click);
            // 
            // tlsbreportes
            // 
            this.tlsbreportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbreportes.Image = ((System.Drawing.Image)(resources.GetObject("tlsbreportes.Image")));
            this.tlsbreportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbreportes.Name = "tlsbreportes";
            this.tlsbreportes.Size = new System.Drawing.Size(29, 24);
            this.tlsbreportes.Text = "toolStripButton3";
            this.tlsbreportes.ToolTipText = "Reportes";
            this.tlsbreportes.Click += new System.EventHandler(this.tlsbreportes_Click);
            // 
            // tlsbusuarios
            // 
            this.tlsbusuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbusuarios.Image = ((System.Drawing.Image)(resources.GetObject("tlsbusuarios.Image")));
            this.tlsbusuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbusuarios.Name = "tlsbusuarios";
            this.tlsbusuarios.Size = new System.Drawing.Size(29, 24);
            this.tlsbusuarios.Text = "toolStripButton4";
            this.tlsbusuarios.ToolTipText = "Usuarios";
            this.tlsbusuarios.Click += new System.EventHandler(this.tlsbusuarios_Click);
            // 
            // tlsbconfiguracion
            // 
            this.tlsbconfiguracion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsbconfiguracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbconfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("tlsbconfiguracion.Image")));
            this.tlsbconfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbconfiguracion.Name = "tlsbconfiguracion";
            this.tlsbconfiguracion.Size = new System.Drawing.Size(29, 24);
            this.tlsbconfiguracion.ToolTipText = "Configuracion";
            this.tlsbconfiguracion.Click += new System.EventHandler(this.tlsbconfiguracion_Click);
            // 
            // tlslusuarioActual
            // 
            this.tlslusuarioActual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlslusuarioActual.Name = "tlslusuarioActual";
            this.tlslusuarioActual.Size = new System.Drawing.Size(108, 24);
            this.tlslusuarioActual.Text = "Usuario Actual:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Configuracion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.limpiarToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exportarToolStripMenuItem.Text = "Abrir";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem1
            // 
            this.limpiarToolStripMenuItem1.Name = "limpiarToolStripMenuItem1";
            this.limpiarToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.limpiarToolStripMenuItem1.Text = "Limpiar";
            this.limpiarToolStripMenuItem1.Click += new System.EventHandler(this.limpiarToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem2,
            this.limpiarToolStripMenuItem3});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // abrirToolStripMenuItem2
            // 
            this.abrirToolStripMenuItem2.Name = "abrirToolStripMenuItem2";
            this.abrirToolStripMenuItem2.Size = new System.Drawing.Size(142, 26);
            this.abrirToolStripMenuItem2.Text = "Abrir";
            this.abrirToolStripMenuItem2.Click += new System.EventHandler(this.abrirToolStripMenuItem2_Click);
            // 
            // limpiarToolStripMenuItem3
            // 
            this.limpiarToolStripMenuItem3.Name = "limpiarToolStripMenuItem3";
            this.limpiarToolStripMenuItem3.Size = new System.Drawing.Size(142, 26);
            this.limpiarToolStripMenuItem3.Text = "Limpiar";
            this.limpiarToolStripMenuItem3.Click += new System.EventHandler(this.limpiarToolStripMenuItem3_Click);
            // 
            // tmractualizaciondeDatos
            // 
            this.tmractualizaciondeDatos.Enabled = true;
            this.tmractualizaciondeDatos.Tick += new System.EventHandler(this.tmractualizaciondeDatos_Tick);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCerrarSesion.Image = global::PadreForm.Properties.Resources.imageedit_20_4595952962;
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(29, 24);
            this.tsbCerrarSesion.Text = "Cerrar Sesion";
            this.tsbCerrarSesion.Click += new System.EventHandler(this.tsbCerrarSesion_Click);
            // 
            // PadreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 574);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PadreForm";
            this.Text = "Mini Super Kokona";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PadreForm_FormClosed);
            this.Load += new System.EventHandler(this.PadreForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuarioActual;
        private System.Windows.Forms.ToolStripStatusLabel tlshora;
        private System.Windows.Forms.Timer tmractualizaciondeDatos;
        private System.Windows.Forms.ToolStripButton tlsbVentas;
        private System.Windows.Forms.ToolStripButton tlsbreportes;
        private System.Windows.Forms.ToolStripButton tlsbusuarios;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tlsbconfiguracion;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripLabel tlslusuarioActual;
        private System.Windows.Forms.ToolStripButton tlsbinventario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCerrarSesion;
    }
}

