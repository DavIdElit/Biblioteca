
namespace CapaPresentacion {
	partial class FEjemplares {
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelISBN = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_ISBN = new System.Windows.Forms.TextBox();
			this.tb_CodigoEjemplar = new System.Windows.Forms.TextBox();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(13, 71);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelISBN
			// 
			this.labelISBN.AutoSize = true;
			this.labelISBN.Location = new System.Drawing.Point(13, 15);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(35, 13);
			this.labelISBN.TabIndex = 1;
			this.labelISBN.Text = "ISBN:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Codigo de ejemplar:";
			// 
			// tb_ISBN
			// 
			this.tb_ISBN.Location = new System.Drawing.Point(145, 12);
			this.tb_ISBN.Name = "tb_ISBN";
			this.tb_ISBN.ReadOnly = true;
			this.tb_ISBN.Size = new System.Drawing.Size(100, 20);
			this.tb_ISBN.TabIndex = 3;
			// 
			// tb_CodigoEjemplar
			// 
			this.tb_CodigoEjemplar.Location = new System.Drawing.Point(145, 38);
			this.tb_CodigoEjemplar.Name = "tb_CodigoEjemplar";
			this.tb_CodigoEjemplar.Size = new System.Drawing.Size(100, 20);
			this.tb_CodigoEjemplar.TabIndex = 4;
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(145, 71);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 5;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
			// 
			// FEjemplares
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 109);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.tb_CodigoEjemplar);
			this.Controls.Add(this.tb_ISBN);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.buttonOK);
			this.Name = "FEjemplares";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelISBN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_ISBN;
		private System.Windows.Forms.TextBox tb_CodigoEjemplar;
		private System.Windows.Forms.Button buttonCancelar;
	}
}