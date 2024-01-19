
namespace CapaPresentacion {
	partial class FLibro {
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
			this.tb_ISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Titulo = new System.Windows.Forms.TextBox();
			this.labelAutor = new System.Windows.Forms.Label();
			this.tb_Autor = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_ISBN
			// 
			this.tb_ISBN.Location = new System.Drawing.Point(120, 6);
			this.tb_ISBN.Name = "tb_ISBN";
			this.tb_ISBN.ReadOnly = true;
			this.tb_ISBN.Size = new System.Drawing.Size(100, 20);
			this.tb_ISBN.TabIndex = 0;
			// 
			// labelISBN
			// 
			this.labelISBN.AutoSize = true;
			this.labelISBN.Location = new System.Drawing.Point(12, 9);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(35, 13);
			this.labelISBN.TabIndex = 1;
			this.labelISBN.Text = "ISBN:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Titulo:";
			// 
			// tb_Titulo
			// 
			this.tb_Titulo.Location = new System.Drawing.Point(120, 35);
			this.tb_Titulo.Name = "tb_Titulo";
			this.tb_Titulo.Size = new System.Drawing.Size(100, 20);
			this.tb_Titulo.TabIndex = 2;
			// 
			// labelAutor
			// 
			this.labelAutor.AutoSize = true;
			this.labelAutor.Location = new System.Drawing.Point(12, 61);
			this.labelAutor.Name = "labelAutor";
			this.labelAutor.Size = new System.Drawing.Size(35, 13);
			this.labelAutor.TabIndex = 5;
			this.labelAutor.Text = "Autor:";
			// 
			// tb_Autor
			// 
			this.tb_Autor.Location = new System.Drawing.Point(120, 61);
			this.tb_Autor.Name = "tb_Autor";
			this.tb_Autor.Size = new System.Drawing.Size(100, 20);
			this.tb_Autor.TabIndex = 4;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(12, 87);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(120, 87);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancelar";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(238, 158);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelAutor);
			this.Controls.Add(this.tb_Autor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Titulo);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.tb_ISBN);
			this.Name = "FLibro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_ISBN;
		private System.Windows.Forms.Label labelISBN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Titulo;
		private System.Windows.Forms.Label labelAutor;
		private System.Windows.Forms.TextBox tb_Autor;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}