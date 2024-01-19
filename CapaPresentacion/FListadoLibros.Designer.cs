namespace CapaPresentacion {
	partial class FListadoLibros {
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
            this.data_Libros = new System.Windows.Forms.DataGridView();
            this.colum_CodigoLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_NombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Libros
            // 
            this.data_Libros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Libros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Libros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_CodigoLibro,
            this.colum_NombreAutor,
            this.colum_NombreLibro});
            this.data_Libros.Location = new System.Drawing.Point(12, 12);
            this.data_Libros.Name = "data_Libros";
            this.data_Libros.ReadOnly = true;
            this.data_Libros.Size = new System.Drawing.Size(776, 426);
            this.data_Libros.TabIndex = 0;
            // 
            // colum_CodigoLibro
            // 
            this.colum_CodigoLibro.HeaderText = "Codigo Libro";
            this.colum_CodigoLibro.Name = "colum_CodigoLibro";
            this.colum_CodigoLibro.ReadOnly = true;
            // 
            // colum_NombreAutor
            // 
            this.colum_NombreAutor.HeaderText = "Nombre del Autor";
            this.colum_NombreAutor.Name = "colum_NombreAutor";
            this.colum_NombreAutor.ReadOnly = true;
            // 
            // colum_NombreLibro
            // 
            this.colum_NombreLibro.HeaderText = "Nombre del libro";
            this.colum_NombreLibro.Name = "colum_NombreLibro";
            this.colum_NombreLibro.ReadOnly = true;
            // 
            // FListadoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_Libros);
            this.Name = "FListadoLibros";
            this.Text = "Listado de libros";
            ((System.ComponentModel.ISupportInitialize)(this.data_Libros)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView data_Libros;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum_CodigoLibro;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum_NombreAutor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum_NombreLibro;
	}
}