
namespace CapaPresentacion {
	partial class DatosLibro {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tb_autor = new System.Windows.Forms.TextBox();
			this.tb_titulo = new System.Windows.Forms.TextBox();
			this.tb_ISBN = new System.Windows.Forms.TextBox();
			this.label_Autor = new System.Windows.Forms.Label();
			this.label_Titulo = new System.Windows.Forms.Label();
			this.label_ISBN = new System.Windows.Forms.Label();
			this.tb_NumEjemplares = new System.Windows.Forms.TextBox();
			this.label_NumEjemplares = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_autor
			// 
			this.tb_autor.Location = new System.Drawing.Point(127, 59);
			this.tb_autor.Name = "tb_autor";
			this.tb_autor.ReadOnly = true;
			this.tb_autor.Size = new System.Drawing.Size(100, 20);
			this.tb_autor.TabIndex = 12;
			// 
			// tb_titulo
			// 
			this.tb_titulo.Location = new System.Drawing.Point(127, 33);
			this.tb_titulo.Name = "tb_titulo";
			this.tb_titulo.ReadOnly = true;
			this.tb_titulo.Size = new System.Drawing.Size(100, 20);
			this.tb_titulo.TabIndex = 11;
			// 
			// tb_ISBN
			// 
			this.tb_ISBN.Location = new System.Drawing.Point(127, 7);
			this.tb_ISBN.Name = "tb_ISBN";
			this.tb_ISBN.ReadOnly = true;
			this.tb_ISBN.Size = new System.Drawing.Size(100, 20);
			this.tb_ISBN.TabIndex = 10;
			// 
			// label_Autor
			// 
			this.label_Autor.AutoSize = true;
			this.label_Autor.Location = new System.Drawing.Point(3, 62);
			this.label_Autor.Name = "label_Autor";
			this.label_Autor.Size = new System.Drawing.Size(38, 13);
			this.label_Autor.TabIndex = 9;
			this.label_Autor.Text = "Autor: ";
			// 
			// label_Titulo
			// 
			this.label_Titulo.AutoSize = true;
			this.label_Titulo.Location = new System.Drawing.Point(3, 36);
			this.label_Titulo.Name = "label_Titulo";
			this.label_Titulo.Size = new System.Drawing.Size(39, 13);
			this.label_Titulo.TabIndex = 8;
			this.label_Titulo.Text = "Titulo: ";
			// 
			// label_ISBN
			// 
			this.label_ISBN.AutoSize = true;
			this.label_ISBN.Location = new System.Drawing.Point(3, 10);
			this.label_ISBN.Name = "label_ISBN";
			this.label_ISBN.Size = new System.Drawing.Size(38, 13);
			this.label_ISBN.TabIndex = 7;
			this.label_ISBN.Text = "ISBN: ";
			// 
			// tb_NumEjemplares
			// 
			this.tb_NumEjemplares.Location = new System.Drawing.Point(127, 85);
			this.tb_NumEjemplares.Name = "tb_NumEjemplares";
			this.tb_NumEjemplares.ReadOnly = true;
			this.tb_NumEjemplares.Size = new System.Drawing.Size(100, 20);
			this.tb_NumEjemplares.TabIndex = 14;
			// 
			// label_NumEjemplares
			// 
			this.label_NumEjemplares.AutoSize = true;
			this.label_NumEjemplares.Location = new System.Drawing.Point(3, 88);
			this.label_NumEjemplares.Name = "label_NumEjemplares";
			this.label_NumEjemplares.Size = new System.Drawing.Size(118, 13);
			this.label_NumEjemplares.TabIndex = 13;
			this.label_NumEjemplares.Text = "Numero de ejemplares: ";
			// 
			// DatosLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tb_NumEjemplares);
			this.Controls.Add(this.label_NumEjemplares);
			this.Controls.Add(this.tb_autor);
			this.Controls.Add(this.tb_titulo);
			this.Controls.Add(this.tb_ISBN);
			this.Controls.Add(this.label_Autor);
			this.Controls.Add(this.label_Titulo);
			this.Controls.Add(this.label_ISBN);
			this.Name = "DatosLibro";
			this.Size = new System.Drawing.Size(234, 111);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_autor;
		private System.Windows.Forms.TextBox tb_titulo;
		private System.Windows.Forms.TextBox tb_ISBN;
		private System.Windows.Forms.Label label_Autor;
		private System.Windows.Forms.Label label_Titulo;
		private System.Windows.Forms.Label label_ISBN;
		private System.Windows.Forms.TextBox tb_NumEjemplares;
		private System.Windows.Forms.Label label_NumEjemplares;
	}
}
