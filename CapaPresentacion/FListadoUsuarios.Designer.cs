
namespace CapaPresentacion {
	partial class FListadoUsuarios {
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
            this.lbDni = new System.Windows.Forms.ListBox();
            this.bOrdenarNombre = new System.Windows.Forms.Button();
            this.bOrdenarDNI = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.lbApellidos = new System.Windows.Forms.ListBox();
            this.lbId = new System.Windows.Forms.ListBox();
            this.bId = new System.Windows.Forms.Button();
            this.bApellidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.FormattingEnabled = true;
            this.lbDni.Location = new System.Drawing.Point(185, 75);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(120, 186);
            this.lbDni.TabIndex = 0;
            // 
            // bOrdenarNombre
            // 
            this.bOrdenarNombre.Location = new System.Drawing.Point(311, 46);
            this.bOrdenarNombre.Name = "bOrdenarNombre";
            this.bOrdenarNombre.Size = new System.Drawing.Size(75, 23);
            this.bOrdenarNombre.TabIndex = 2;
            this.bOrdenarNombre.Text = "Nombre";
            this.bOrdenarNombre.UseVisualStyleBackColor = true;
            this.bOrdenarNombre.Click += new System.EventHandler(this.bOrdenarNombre_Click);
            // 
            // bOrdenarDNI
            // 
            this.bOrdenarDNI.Location = new System.Drawing.Point(185, 46);
            this.bOrdenarDNI.Name = "bOrdenarDNI";
            this.bOrdenarDNI.Size = new System.Drawing.Size(75, 23);
            this.bOrdenarDNI.TabIndex = 3;
            this.bOrdenarDNI.Text = "DNI";
            this.bOrdenarDNI.UseVisualStyleBackColor = true;
            this.bOrdenarDNI.Click += new System.EventHandler(this.bOrdenarDNI_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.Location = new System.Drawing.Point(311, 75);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(120, 186);
            this.lbNombre.TabIndex = 6;
            // 
            // lbApellidos
            // 
            this.lbApellidos.FormattingEnabled = true;
            this.lbApellidos.Location = new System.Drawing.Point(437, 75);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(120, 186);
            this.lbApellidos.TabIndex = 7;
            // 
            // lbId
            // 
            this.lbId.FormattingEnabled = true;
            this.lbId.Location = new System.Drawing.Point(59, 75);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(120, 186);
            this.lbId.TabIndex = 8;
            // 
            // bId
            // 
            this.bId.Location = new System.Drawing.Point(59, 46);
            this.bId.Name = "bId";
            this.bId.Size = new System.Drawing.Size(75, 23);
            this.bId.TabIndex = 9;
            this.bId.Text = "ID";
            this.bId.UseVisualStyleBackColor = true;
            this.bId.Click += new System.EventHandler(this.bId_Click);
            // 
            // bApellidos
            // 
            this.bApellidos.Location = new System.Drawing.Point(437, 46);
            this.bApellidos.Name = "bApellidos";
            this.bApellidos.Size = new System.Drawing.Size(75, 23);
            this.bApellidos.TabIndex = 10;
            this.bApellidos.Text = "Apellidos";
            this.bApellidos.UseVisualStyleBackColor = true;
            this.bApellidos.Click += new System.EventHandler(this.bApellidos_Click);
            // 
            // FListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 338);
            this.Controls.Add(this.bApellidos);
            this.Controls.Add(this.bId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.bOrdenarDNI);
            this.Controls.Add(this.bOrdenarNombre);
            this.Controls.Add(this.lbDni);
            this.Name = "FListadoUsuarios";
            this.Text = "Listado de usuarios";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbDni;
		private System.Windows.Forms.Button bOrdenarNombre;
		private System.Windows.Forms.Button bOrdenarDNI;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.ListBox lbApellidos;
        private System.Windows.Forms.ListBox lbId;
        private System.Windows.Forms.Button bId;
        private System.Windows.Forms.Button bApellidos;
    }
}