namespace CapaPresentacion
{
    partial class FPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCodPrestamo = new System.Windows.Forms.Label();
            this.tbCodPrestamo = new System.Windows.Forms.TextBox();
            this.lbCodUsuario = new System.Windows.Forms.Label();
            this.lbFechaRealizacion = new System.Windows.Forms.Label();
            this.dtFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lbFechaDevolucion = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lbLibros = new System.Windows.Forms.Label();
            this.clLibros = new System.Windows.Forms.CheckedListBox();
            this.tbPrestador = new System.Windows.Forms.TextBox();
            this.lbPrestador = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCodPrestamo
            // 
            this.lbCodPrestamo.AutoSize = true;
            this.lbCodPrestamo.Location = new System.Drawing.Point(21, 12);
            this.lbCodPrestamo.Name = "lbCodPrestamo";
            this.lbCodPrestamo.Size = new System.Drawing.Size(87, 13);
            this.lbCodPrestamo.TabIndex = 0;
            this.lbCodPrestamo.Text = "Código Préstamo";
            // 
            // tbCodPrestamo
            // 
            this.tbCodPrestamo.Location = new System.Drawing.Point(127, 9);
            this.tbCodPrestamo.Name = "tbCodPrestamo";
            this.tbCodPrestamo.Size = new System.Drawing.Size(297, 20);
            this.tbCodPrestamo.TabIndex = 1;
            // 
            // lbCodUsuario
            // 
            this.lbCodUsuario.AutoSize = true;
            this.lbCodUsuario.Location = new System.Drawing.Point(22, 110);
            this.lbCodUsuario.Name = "lbCodUsuario";
            this.lbCodUsuario.Size = new System.Drawing.Size(57, 13);
            this.lbCodUsuario.TabIndex = 2;
            this.lbCodUsuario.Text = "ID Usuario";
            // 
            // lbFechaRealizacion
            // 
            this.lbFechaRealizacion.AutoSize = true;
            this.lbFechaRealizacion.Location = new System.Drawing.Point(21, 47);
            this.lbFechaRealizacion.Name = "lbFechaRealizacion";
            this.lbFechaRealizacion.Size = new System.Drawing.Size(95, 13);
            this.lbFechaRealizacion.TabIndex = 6;
            this.lbFechaRealizacion.Text = "Fecha Realizacion";
            // 
            // dtFechaRealizacion
            // 
            this.dtFechaRealizacion.Location = new System.Drawing.Point(127, 47);
            this.dtFechaRealizacion.Name = "dtFechaRealizacion";
            this.dtFechaRealizacion.Size = new System.Drawing.Size(297, 20);
            this.dtFechaRealizacion.TabIndex = 7;
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Location = new System.Drawing.Point(127, 73);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(297, 20);
            this.dtFechaDevolucion.TabIndex = 8;
            // 
            // lbFechaDevolucion
            // 
            this.lbFechaDevolucion.AutoSize = true;
            this.lbFechaDevolucion.Location = new System.Drawing.Point(22, 79);
            this.lbFechaDevolucion.Name = "lbFechaDevolucion";
            this.lbFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lbFechaDevolucion.TabIndex = 9;
            this.lbFechaDevolucion.Text = "Fecha Devolución";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(75, 291);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(245, 291);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(127, 107);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(297, 21);
            this.cbUsuario.TabIndex = 16;
            // 
            // lbLibros
            // 
            this.lbLibros.AutoSize = true;
            this.lbLibros.Location = new System.Drawing.Point(27, 144);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(35, 13);
            this.lbLibros.TabIndex = 17;
            this.lbLibros.Text = "Libros";
            // 
            // clLibros
            // 
            this.clLibros.CheckOnClick = true;
            this.clLibros.FormattingEnabled = true;
            this.clLibros.HorizontalScrollbar = true;
            this.clLibros.Location = new System.Drawing.Point(127, 144);
            this.clLibros.Name = "clLibros";
            this.clLibros.Size = new System.Drawing.Size(297, 64);
            this.clLibros.TabIndex = 18;
            // 
            // tbPrestador
            // 
            this.tbPrestador.Location = new System.Drawing.Point(127, 254);
            this.tbPrestador.Name = "tbPrestador";
            this.tbPrestador.Size = new System.Drawing.Size(297, 20);
            this.tbPrestador.TabIndex = 22;
            this.tbPrestador.Visible = false;
            // 
            // lbPrestador
            // 
            this.lbPrestador.AutoSize = true;
            this.lbPrestador.Location = new System.Drawing.Point(22, 257);
            this.lbPrestador.Name = "lbPrestador";
            this.lbPrestador.Size = new System.Drawing.Size(52, 13);
            this.lbPrestador.TabIndex = 21;
            this.lbPrestador.Text = "Prestador";
            this.lbPrestador.Visible = false;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(127, 219);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(297, 20);
            this.tbEstado.TabIndex = 20;
            this.tbEstado.Visible = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(22, 222);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 19;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Visible = false;
            // 
            // FPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 395);
            this.Controls.Add(this.tbPrestador);
            this.Controls.Add(this.lbPrestador);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.clLibros);
            this.Controls.Add(this.lbLibros);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbFechaDevolucion);
            this.Controls.Add(this.dtFechaDevolucion);
            this.Controls.Add(this.dtFechaRealizacion);
            this.Controls.Add(this.lbFechaRealizacion);
            this.Controls.Add(this.lbCodUsuario);
            this.Controls.Add(this.tbCodPrestamo);
            this.Controls.Add(this.lbCodPrestamo);
            this.Name = "FPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodPrestamo;
        private System.Windows.Forms.TextBox tbCodPrestamo;
        private System.Windows.Forms.Label lbCodUsuario;
        private System.Windows.Forms.Label lbFechaRealizacion;
        private System.Windows.Forms.DateTimePicker dtFechaRealizacion;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.Windows.Forms.Label lbFechaDevolucion;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lbLibros;
        private System.Windows.Forms.TextBox tbPrestador;
        private System.Windows.Forms.Label lbPrestador;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.CheckedListBox clLibros;
    }
}