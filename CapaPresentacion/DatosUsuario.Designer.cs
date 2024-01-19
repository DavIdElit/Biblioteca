
namespace CapaPresentacion {
	partial class DatosUsuario {
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
            this.labelDNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrestados = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlazo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(3, 11);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(29, 13);
            this.labelDNI.TabIndex = 0;
            this.labelDNI.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº de libros prestados:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(139, 8);
            this.tbDni.Name = "tbDni";
            this.tbDni.ReadOnly = true;
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(139, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbPrestados
            // 
            this.tbPrestados.Location = new System.Drawing.Point(139, 117);
            this.tbPrestados.Name = "tbPrestados";
            this.tbPrestados.ReadOnly = true;
            this.tbPrestados.Size = new System.Drawing.Size(100, 20);
            this.tbPrestados.TabIndex = 5;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(139, 80);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Préstamos fuera de plazo";
            // 
            // tbPlazo
            // 
            this.tbPlazo.Location = new System.Drawing.Point(139, 154);
            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.ReadOnly = true;
            this.tbPlazo.Size = new System.Drawing.Size(100, 20);
            this.tbPlazo.TabIndex = 9;
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPlazo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbPrestados);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDNI);
            this.Name = "DatosUsuario";
            this.Size = new System.Drawing.Size(282, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDNI;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbDni;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.TextBox tbPrestados;
		private System.Windows.Forms.TextBox tbApellidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPlazo;
	}
}
