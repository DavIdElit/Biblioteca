
namespace CapaPresentacion {
	partial class FListadoEjemplares {
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
			this.data_Ejemplares = new System.Windows.Forms.DataGridView();
			this.colum_CodigoLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colum_codEj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.data_Ejemplares)).BeginInit();
			this.SuspendLayout();
			// 
			// data_Ejemplares
			// 
			this.data_Ejemplares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.data_Ejemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_Ejemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_CodigoLibro,
            this.colum_codEj});
			this.data_Ejemplares.Location = new System.Drawing.Point(12, 12);
			this.data_Ejemplares.Name = "data_Ejemplares";
			this.data_Ejemplares.Size = new System.Drawing.Size(776, 84);
			this.data_Ejemplares.TabIndex = 0;
			// 
			// colum_CodigoLibro
			// 
			this.colum_CodigoLibro.HeaderText = "Codigo del libro";
			this.colum_CodigoLibro.Name = "colum_CodigoLibro";
			this.colum_CodigoLibro.ReadOnly = true;
			this.colum_CodigoLibro.Width = 367;
			// 
			// colum_codEj
			// 
			this.colum_codEj.HeaderText = "Codigo del ejemplar";
			this.colum_codEj.Name = "colum_codEj";
			this.colum_codEj.ReadOnly = true;
			this.colum_codEj.Width = 366;
			// 
			// FListadoEjemplares
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.data_Ejemplares);
			this.Name = "FListadoEjemplares";
			this.Text = "Listado de ejemplares";
			((System.ComponentModel.ISupportInitialize)(this.data_Ejemplares)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView data_Ejemplares;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum_CodigoLibro;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum_codEj;
	}
}