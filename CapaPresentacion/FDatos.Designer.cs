
namespace CapaPresentacion {
	partial class Datos {
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
			this.textBoxClave = new System.Windows.Forms.TextBox();
			this.labelClave = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxClave
			// 
			this.textBoxClave.Location = new System.Drawing.Point(53, 12);
			this.textBoxClave.Name = "textBoxClave";
			this.textBoxClave.Size = new System.Drawing.Size(174, 20);
			this.textBoxClave.TabIndex = 0;
			// 
			// labelClave
			// 
			this.labelClave.AutoSize = true;
			this.labelClave.Location = new System.Drawing.Point(12, 16);
			this.labelClave.Name = "labelClave";
			this.labelClave.Size = new System.Drawing.Size(34, 13);
			this.labelClave.TabIndex = 2;
			this.labelClave.Text = "Clave";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 38);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Aceptar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Datos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 83);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelClave);
			this.Controls.Add(this.textBoxClave);
			this.Name = "Datos";
			this.Text = "Introduce los datos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxClave;
		private System.Windows.Forms.Label labelClave;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}