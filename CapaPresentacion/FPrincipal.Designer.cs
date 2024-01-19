
namespace CapaPresentacion {
	partial class FPrincipal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.barraHerramientas = new System.Windows.Forms.MenuStrip();
            this.menuItemUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAltaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBajaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBusquedaEnLista = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoUnoAUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAltaLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBajaLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBusquedaLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoTodosLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLibrosUnoAUno = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAltaEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBajaEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListarEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEjemplaresDisponibles_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAltaPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBajaPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBusquedaPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.unoAUnoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.barraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraHerramientas
            // 
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUsuario,
            this.menuItemLibros,
            this.menuItemEjemplares,
            this.menuItemPrestamos});
            this.barraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.barraHerramientas.Name = "barraHerramientas";
            this.barraHerramientas.Size = new System.Drawing.Size(326, 24);
            this.barraHerramientas.TabIndex = 0;
            this.barraHerramientas.Text = "barraHerramientas";
            // 
            // menuItemUsuario
            // 
            this.menuItemUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAltaUsuarios,
            this.menuItemBajaUsuarios,
            this.listadoToolStripMenuItem,
            this.menuItemBusquedaEnLista,
            this.busquedaIDToolStripMenuItem,
            this.recorridoUnoAUnoToolStripMenuItem});
            this.menuItemUsuario.Name = "menuItemUsuario";
            this.menuItemUsuario.Size = new System.Drawing.Size(64, 20);
            this.menuItemUsuario.Text = "Usuarios";
            // 
            // menuItemAltaUsuarios
            // 
            this.menuItemAltaUsuarios.Name = "menuItemAltaUsuarios";
            this.menuItemAltaUsuarios.Size = new System.Drawing.Size(182, 22);
            this.menuItemAltaUsuarios.Text = "Alta";
            this.menuItemAltaUsuarios.Click += new System.EventHandler(this.menuItemAltaUsuarios_Click);
            // 
            // menuItemBajaUsuarios
            // 
            this.menuItemBajaUsuarios.Name = "menuItemBajaUsuarios";
            this.menuItemBajaUsuarios.Size = new System.Drawing.Size(182, 22);
            this.menuItemBajaUsuarios.Text = "Baja";
            this.menuItemBajaUsuarios.Click += new System.EventHandler(this.menuItemBajaUsuarios_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // menuItemBusquedaEnLista
            // 
            this.menuItemBusquedaEnLista.Name = "menuItemBusquedaEnLista";
            this.menuItemBusquedaEnLista.Size = new System.Drawing.Size(182, 22);
            this.menuItemBusquedaEnLista.Text = "Busqueda en lista";
            this.menuItemBusquedaEnLista.Click += new System.EventHandler(this.menuItemBusquedaEnLista_Click);
            // 
            // busquedaIDToolStripMenuItem
            // 
            this.busquedaIDToolStripMenuItem.Name = "busquedaIDToolStripMenuItem";
            this.busquedaIDToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.busquedaIDToolStripMenuItem.Text = "Busqueda por ID";
            this.busquedaIDToolStripMenuItem.Click += new System.EventHandler(this.busquedaIDToolStripMenuItem_Click);
            // 
            // recorridoUnoAUnoToolStripMenuItem
            // 
            this.recorridoUnoAUnoToolStripMenuItem.Name = "recorridoUnoAUnoToolStripMenuItem";
            this.recorridoUnoAUnoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.recorridoUnoAUnoToolStripMenuItem.Text = "Recorrido uno a uno";
            this.recorridoUnoAUnoToolStripMenuItem.Click += new System.EventHandler(this.recorridoUnoAUnoToolStripMenuItem_Click);
            // 
            // menuItemLibros
            // 
            this.menuItemLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAltaLibros,
            this.menuItemBajaLibros,
            this.menuItemBusquedaLibros,
            this.listadoTodosLibros,
            this.listarLibrosUnoAUno,
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem});
            this.menuItemLibros.Name = "menuItemLibros";
            this.menuItemLibros.Size = new System.Drawing.Size(51, 20);
            this.menuItemLibros.Text = "Libros";
            // 
            // menuItemAltaLibros
            // 
            this.menuItemAltaLibros.Name = "menuItemAltaLibros";
            this.menuItemAltaLibros.Size = new System.Drawing.Size(245, 22);
            this.menuItemAltaLibros.Text = "Alta";
            this.menuItemAltaLibros.Click += new System.EventHandler(this.menuItemAltaLibros_Click);
            // 
            // menuItemBajaLibros
            // 
            this.menuItemBajaLibros.Name = "menuItemBajaLibros";
            this.menuItemBajaLibros.Size = new System.Drawing.Size(245, 22);
            this.menuItemBajaLibros.Text = "Baja";
            this.menuItemBajaLibros.Click += new System.EventHandler(this.menuItemBajaLibros_Click);
            // 
            // menuItemBusquedaLibros
            // 
            this.menuItemBusquedaLibros.Name = "menuItemBusquedaLibros";
            this.menuItemBusquedaLibros.Size = new System.Drawing.Size(245, 22);
            this.menuItemBusquedaLibros.Text = "Busqueda";
            this.menuItemBusquedaLibros.Click += new System.EventHandler(this.menuItemBusquedaLibros_Click);
            // 
            // listadoTodosLibros
            // 
            this.listadoTodosLibros.Name = "listadoTodosLibros";
            this.listadoTodosLibros.Size = new System.Drawing.Size(245, 22);
            this.listadoTodosLibros.Text = "Listar libros disponibles";
            this.listadoTodosLibros.Click += new System.EventHandler(this.listadoTodosLibros_Click);
            // 
            // listarLibrosUnoAUno
            // 
            this.listarLibrosUnoAUno.Name = "listarLibrosUnoAUno";
            this.listarLibrosUnoAUno.Size = new System.Drawing.Size(245, 22);
            this.listarLibrosUnoAUno.Text = "Recorrido uno a uno";
            this.listarLibrosUnoAUno.Click += new System.EventHandler(this.listarLibrosUnoAUno_Click);
            // 
            // mostrarLibroMasLeidoEsteMesToolStripMenuItem
            // 
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem.Name = "mostrarLibroMasLeidoEsteMesToolStripMenuItem";
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem.Text = "Mostrar libro mas leido este mes";
            this.mostrarLibroMasLeidoEsteMesToolStripMenuItem.Click += new System.EventHandler(this.mostrarLibroMasLeidoEsteMesToolStripMenuItem_Click);
            // 
            // menuItemEjemplares
            // 
            this.menuItemEjemplares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAltaEjemplares,
            this.menuItemBajaEjemplares,
            this.menuItemListarEjemplares,
            this.listarEjemplaresDisponibles_MenuItem});
            this.menuItemEjemplares.Name = "menuItemEjemplares";
            this.menuItemEjemplares.Size = new System.Drawing.Size(76, 20);
            this.menuItemEjemplares.Text = "Ejemplares";
            // 
            // menuItemAltaEjemplares
            // 
            this.menuItemAltaEjemplares.Name = "menuItemAltaEjemplares";
            this.menuItemAltaEjemplares.Size = new System.Drawing.Size(285, 22);
            this.menuItemAltaEjemplares.Text = "Alta";
            this.menuItemAltaEjemplares.Click += new System.EventHandler(this.menuItemAltaEjemplares_Click);
            // 
            // menuItemBajaEjemplares
            // 
            this.menuItemBajaEjemplares.Name = "menuItemBajaEjemplares";
            this.menuItemBajaEjemplares.Size = new System.Drawing.Size(285, 22);
            this.menuItemBajaEjemplares.Text = "Baja";
            this.menuItemBajaEjemplares.Click += new System.EventHandler(this.menuItemBajaEjemplares_Click);
            // 
            // menuItemListarEjemplares
            // 
            this.menuItemListarEjemplares.Name = "menuItemListarEjemplares";
            this.menuItemListarEjemplares.Size = new System.Drawing.Size(285, 22);
            this.menuItemListarEjemplares.Text = "Listar ejemplares de un libro";
            this.menuItemListarEjemplares.Click += new System.EventHandler(this.menuItemListarEjemplares_Click);
            // 
            // listarEjemplaresDisponibles_MenuItem
            // 
            this.listarEjemplaresDisponibles_MenuItem.Name = "listarEjemplaresDisponibles_MenuItem";
            this.listarEjemplaresDisponibles_MenuItem.Size = new System.Drawing.Size(285, 22);
            this.listarEjemplaresDisponibles_MenuItem.Text = "Listar ejemplares disponibles de un libro";
            this.listarEjemplaresDisponibles_MenuItem.Click += new System.EventHandler(this.listarEjemplaresDisponibles_MenuItem_Click);
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAltaPrestamos,
            this.menuItemBajaPrestamos,
            this.menuItemBusquedaPrestamos,
            this.listadoToolStripMenuItem3,
            this.unoAUnoToolStripMenuItem3});
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.Size = new System.Drawing.Size(74, 20);
            this.menuItemPrestamos.Text = "Prestamos";
            // 
            // menuItemAltaPrestamos
            // 
            this.menuItemAltaPrestamos.Name = "menuItemAltaPrestamos";
            this.menuItemAltaPrestamos.Size = new System.Drawing.Size(180, 22);
            this.menuItemAltaPrestamos.Text = "Alta";
            this.menuItemAltaPrestamos.Click += new System.EventHandler(this.menuItemAltaPrestamos_Click);
            // 
            // menuItemBajaPrestamos
            // 
            this.menuItemBajaPrestamos.Name = "menuItemBajaPrestamos";
            this.menuItemBajaPrestamos.Size = new System.Drawing.Size(180, 22);
            this.menuItemBajaPrestamos.Text = "Baja";
            this.menuItemBajaPrestamos.Click += new System.EventHandler(this.menuItemBajaPrestamos_Click);
            // 
            // menuItemBusquedaPrestamos
            // 
            this.menuItemBusquedaPrestamos.Name = "menuItemBusquedaPrestamos";
            this.menuItemBusquedaPrestamos.Size = new System.Drawing.Size(180, 22);
            this.menuItemBusquedaPrestamos.Text = "Busqueda";
            this.menuItemBusquedaPrestamos.Click += new System.EventHandler(this.menuItemBusquedaPrestamos_Click);
            // 
            // listadoToolStripMenuItem3
            // 
            this.listadoToolStripMenuItem3.Name = "listadoToolStripMenuItem3";
            this.listadoToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem3.Text = "Listado";
            this.listadoToolStripMenuItem3.Click += new System.EventHandler(this.listadoPrestamos_Click);
            // 
            // unoAUnoToolStripMenuItem3
            // 
            this.unoAUnoToolStripMenuItem3.Name = "unoAUnoToolStripMenuItem3";
            this.unoAUnoToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.unoAUnoToolStripMenuItem3.Text = "Uno a uno";
            this.unoAUnoToolStripMenuItem3.Click += new System.EventHandler(this.listarPrestamosUnoAUno_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 177);
            this.Controls.Add(this.barraHerramientas);
            this.MainMenuStrip = this.barraHerramientas;
            this.Name = "FPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip barraHerramientas;
		private System.Windows.Forms.ToolStripMenuItem menuItemUsuario;
		private System.Windows.Forms.ToolStripMenuItem menuItemAltaUsuarios;
		private System.Windows.Forms.ToolStripMenuItem menuItemBajaUsuarios;
		private System.Windows.Forms.ToolStripMenuItem menuItemBusquedaEnLista;
		private System.Windows.Forms.ToolStripMenuItem menuItemLibros;
		private System.Windows.Forms.ToolStripMenuItem menuItemAltaLibros;
		private System.Windows.Forms.ToolStripMenuItem menuItemBajaLibros;
		private System.Windows.Forms.ToolStripMenuItem menuItemBusquedaLibros;
		private System.Windows.Forms.ToolStripMenuItem menuItemEjemplares;
		private System.Windows.Forms.ToolStripMenuItem menuItemAltaEjemplares;
		private System.Windows.Forms.ToolStripMenuItem menuItemBajaEjemplares;
		private System.Windows.Forms.ToolStripMenuItem menuItemPrestamos;
		private System.Windows.Forms.ToolStripMenuItem menuItemAltaPrestamos;
		private System.Windows.Forms.ToolStripMenuItem menuItemBusquedaPrestamos;
		private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem busquedaIDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoTodosLibros;
		private System.Windows.Forms.ToolStripMenuItem listarLibrosUnoAUno;
		private System.Windows.Forms.ToolStripMenuItem menuItemListarEjemplares;
		private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem unoAUnoToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mostrarLibroMasLeidoEsteMesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listarEjemplaresDisponibles_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoUnoAUnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemBajaPrestamos;
    }
}

