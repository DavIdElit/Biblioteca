namespace CapaPresentacion
{
    partial class DatosPrestamo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrestador = new System.Windows.Forms.TextBox();
            this.lbPrestador = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.clLibros = new System.Windows.Forms.CheckedListBox();
            this.lbLibros = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lbFechaDevolucion = new System.Windows.Forms.Label();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.lbFechaRealizacion = new System.Windows.Forms.Label();
            this.lbCodUsuario = new System.Windows.Forms.Label();
            this.tbCodPrestamo = new System.Windows.Forms.TextBox();
            this.lbCodPrestamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPrestador
            // 
            this.tbPrestador.Location = new System.Drawing.Point(108, 246);
            this.tbPrestador.Name = "tbPrestador";
            this.tbPrestador.Size = new System.Drawing.Size(297, 20);
            this.tbPrestador.TabIndex = 36;
            // 
            // lbPrestador
            // 
            this.lbPrestador.AutoSize = true;
            this.lbPrestador.Location = new System.Drawing.Point(3, 249);
            this.lbPrestador.Name = "lbPrestador";
            this.lbPrestador.Size = new System.Drawing.Size(52, 13);
            this.lbPrestador.TabIndex = 35;
            this.lbPrestador.Text = "Prestador";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(108, 211);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(297, 20);
            this.tbEstado.TabIndex = 34;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(3, 214);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 33;
            this.lbEstado.Text = "Estado";
            // 
            // clLibros
            // 
            this.clLibros.CheckOnClick = true;
            this.clLibros.FormattingEnabled = true;
            this.clLibros.HorizontalScrollbar = true;
            this.clLibros.Location = new System.Drawing.Point(108, 136);
            this.clLibros.Name = "clLibros";
            this.clLibros.Size = new System.Drawing.Size(297, 64);
            this.clLibros.TabIndex = 32;
            // 
            // lbLibros
            // 
            this.lbLibros.AutoSize = true;
            this.lbLibros.Location = new System.Drawing.Point(8, 136);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(35, 13);
            this.lbLibros.TabIndex = 31;
            this.lbLibros.Text = "Libros";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(108, 99);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(297, 21);
            this.cbUsuario.TabIndex = 30;
            // 
            // lbFechaDevolucion
            // 
            this.lbFechaDevolucion.AutoSize = true;
            this.lbFechaDevolucion.Location = new System.Drawing.Point(3, 71);
            this.lbFechaDevolucion.Name = "lbFechaDevolucion";
            this.lbFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lbFechaDevolucion.TabIndex = 29;
            this.lbFechaDevolucion.Text = "Fecha Devolución";
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Location = new System.Drawing.Point(108, 65);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(297, 20);
            this.dtFechaDevolucion.TabIndex = 28;
            // 
            // dtFechaRealizacion
            // 
            this.dtFechaRealizacion.Location = new System.Drawing.Point(108, 39);
            this.dtFechaRealizacion.Name = "dtFechaRealizacion";
            this.dtFechaRealizacion.Size = new System.Drawing.Size(297, 20);
            this.dtFechaRealizacion.TabIndex = 27;
            // 
            // lbFechaRealizacion
            // 
            this.lbFechaRealizacion.AutoSize = true;
            this.lbFechaRealizacion.Location = new System.Drawing.Point(2, 39);
            this.lbFechaRealizacion.Name = "lbFechaRealizacion";
            this.lbFechaRealizacion.Size = new System.Drawing.Size(95, 13);
            this.lbFechaRealizacion.TabIndex = 26;
            this.lbFechaRealizacion.Text = "Fecha Realizacion";
            // 
            // lbCodUsuario
            // 
            this.lbCodUsuario.AutoSize = true;
            this.lbCodUsuario.Location = new System.Drawing.Point(3, 102);
            this.lbCodUsuario.Name = "lbCodUsuario";
            this.lbCodUsuario.Size = new System.Drawing.Size(57, 13);
            this.lbCodUsuario.TabIndex = 25;
            this.lbCodUsuario.Text = "ID Usuario";
            // 
            // tbCodPrestamo
            // 
            this.tbCodPrestamo.Location = new System.Drawing.Point(108, 1);
            this.tbCodPrestamo.Name = "tbCodPrestamo";
            this.tbCodPrestamo.Size = new System.Drawing.Size(297, 20);
            this.tbCodPrestamo.TabIndex = 24;
            // 
            // lbCodPrestamo
            // 
            this.lbCodPrestamo.AutoSize = true;
            this.lbCodPrestamo.Location = new System.Drawing.Point(2, 4);
            this.lbCodPrestamo.Name = "lbCodPrestamo";
            this.lbCodPrestamo.Size = new System.Drawing.Size(87, 13);
            this.lbCodPrestamo.TabIndex = 23;
            this.lbCodPrestamo.Text = "Código Préstamo";
            // 
            // DatosPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPrestador);
            this.Controls.Add(this.lbPrestador);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.clLibros);
            this.Controls.Add(this.lbLibros);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.lbFechaDevolucion);
            this.Controls.Add(this.dtFechaDevolucion);
            this.Controls.Add(this.dtFechaRealizacion);
            this.Controls.Add(this.lbFechaRealizacion);
            this.Controls.Add(this.lbCodUsuario);
            this.Controls.Add(this.tbCodPrestamo);
            this.Controls.Add(this.lbCodPrestamo);
            this.Name = "DatosPrestamo";
            this.Size = new System.Drawing.Size(407, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrestador;
        private System.Windows.Forms.Label lbPrestador;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.CheckedListBox clLibros;
        private System.Windows.Forms.Label lbLibros;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lbFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtFechaRealizacion;
        private System.Windows.Forms.Label lbFechaRealizacion;
        private System.Windows.Forms.Label lbCodUsuario;
        private System.Windows.Forms.TextBox tbCodPrestamo;
        private System.Windows.Forms.Label lbCodPrestamo;
    }
}
