namespace Compra_y_venta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.achivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPersonalCtrlMayusAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDelPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaAlPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaAlPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actuaizarDatosDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corregirDescripcionDeLaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corregirDescripcionDeLaSubcategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reasignarSubcategoriaDeUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 78);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 75);
            this.toolStripButton1.Text = "Nuevo personal";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achivoToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // achivoToolStripMenuItem
            // 
            this.achivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveDeUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.achivoToolStripMenuItem.Name = "achivoToolStripMenuItem";
            this.achivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.achivoToolStripMenuItem.Text = "Achivo";
            //this.achivoToolStripMenuItem.Click += new System.EventHandler(this.achivoToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPersonalCtrlMayusAToolStripMenuItem,
            this.actualizarDatosDelPersonalToolStripMenuItem,
            this.darDeBajaAlPersonalToolStripMenuItem,
            this.darDeAltaAlPersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.actuaizarDatosDelProductoToolStripMenuItem,
            this.corregirDescripcionDeLaCategoriaToolStripMenuItem,
            this.corregirDescripcionDeLaSubcategoriaToolStripMenuItem,
            this.reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem,
            this.reasignarSubcategoriaDeUnProductoToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cambiarClaveDeUsuarioToolStripMenuItem
            // 
            this.cambiarClaveDeUsuarioToolStripMenuItem.Name = "cambiarClaveDeUsuarioToolStripMenuItem";
            this.cambiarClaveDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cambiarClaveDeUsuarioToolStripMenuItem.Text = "Cambiar Clave de usuario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.salirToolStripMenuItem.Text = "Salir";
           // this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // nuevoPersonalCtrlMayusAToolStripMenuItem
            // 
            this.nuevoPersonalCtrlMayusAToolStripMenuItem.Name = "nuevoPersonalCtrlMayusAToolStripMenuItem";
            this.nuevoPersonalCtrlMayusAToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.nuevoPersonalCtrlMayusAToolStripMenuItem.Text = "Nuevo personal  Ctrl+Mayus.+A";
            this.nuevoPersonalCtrlMayusAToolStripMenuItem.Click += new System.EventHandler(this.nuevoPersonalCtrlMayusAToolStripMenuItem_Click);
            // 
            // actualizarDatosDelPersonalToolStripMenuItem
            // 
            this.actualizarDatosDelPersonalToolStripMenuItem.Name = "actualizarDatosDelPersonalToolStripMenuItem";
            this.actualizarDatosDelPersonalToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.actualizarDatosDelPersonalToolStripMenuItem.Text = "Actualizar datos del personal";
            // 
            // darDeBajaAlPersonalToolStripMenuItem
            // 
            this.darDeBajaAlPersonalToolStripMenuItem.Name = "darDeBajaAlPersonalToolStripMenuItem";
            this.darDeBajaAlPersonalToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.darDeBajaAlPersonalToolStripMenuItem.Text = "Dar de baja al personal";
            // 
            // darDeAltaAlPersonalToolStripMenuItem
            // 
            this.darDeAltaAlPersonalToolStripMenuItem.Name = "darDeAltaAlPersonalToolStripMenuItem";
            this.darDeAltaAlPersonalToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.darDeAltaAlPersonalToolStripMenuItem.Text = "Dar de alta al personal";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo producto";
            // 
            // actuaizarDatosDelProductoToolStripMenuItem
            // 
            this.actuaizarDatosDelProductoToolStripMenuItem.Name = "actuaizarDatosDelProductoToolStripMenuItem";
            this.actuaizarDatosDelProductoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.actuaizarDatosDelProductoToolStripMenuItem.Text = "Actuaizar datos del producto";
            // 
            // corregirDescripcionDeLaCategoriaToolStripMenuItem
            // 
            this.corregirDescripcionDeLaCategoriaToolStripMenuItem.Name = "corregirDescripcionDeLaCategoriaToolStripMenuItem";
            this.corregirDescripcionDeLaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.corregirDescripcionDeLaCategoriaToolStripMenuItem.Text = "Corregir descripcion de la categoria";
            // 
            // corregirDescripcionDeLaSubcategoriaToolStripMenuItem
            // 
            this.corregirDescripcionDeLaSubcategoriaToolStripMenuItem.Name = "corregirDescripcionDeLaSubcategoriaToolStripMenuItem";
            this.corregirDescripcionDeLaSubcategoriaToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.corregirDescripcionDeLaSubcategoriaToolStripMenuItem.Text = "Corregir descripcion de la subcategoria";
            // 
            // reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem
            // 
            this.reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem.Name = "reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem";
            this.reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem.Text = "Reasignar categoria de una subcategoria";
            // 
            // reasignarSubcategoriaDeUnProductoToolStripMenuItem
            // 
            this.reasignarSubcategoriaDeUnProductoToolStripMenuItem.Name = "reasignarSubcategoriaDeUnProductoToolStripMenuItem";
            this.reasignarSubcategoriaDeUnProductoToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.reasignarSubcategoriaDeUnProductoToolStripMenuItem.Text = "Reasignar subcategoria de un producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem achivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPersonalCtrlMayusAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosDelPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaAlPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaAlPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actuaizarDatosDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corregirDescripcionDeLaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corregirDescripcionDeLaSubcategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reasignarCategoriaDeUnaSubcategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reasignarSubcategoriaDeUnProductoToolStripMenuItem;
    }
}

