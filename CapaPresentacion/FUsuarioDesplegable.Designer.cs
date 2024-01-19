namespace CapaPresentacion
{
    partial class FUsuarioDesplegable
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
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(59, 124);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(29, 13);
            this.lbDNI.TabIndex = 15;
            this.lbDNI.Text = "DNI:";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(59, 98);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(52, 13);
            this.lbApellidos.TabIndex = 14;
            this.lbApellidos.Text = "Apellidos:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(59, 72);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 46);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(75, 13);
            this.lbId.TabIndex = 12;
            this.lbId.Text = "ID del usuario:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(148, 121);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.ReadOnly = true;
            this.tbDNI.Size = new System.Drawing.Size(121, 20);
            this.tbDNI.TabIndex = 11;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(148, 95);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(121, 20);
            this.tbApellidos.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(148, 69);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(130, 185);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 16;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(148, 43);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(121, 21);
            this.cbId.TabIndex = 17;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // FUsuarioDesplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Name = "FUsuarioDesplegable";
            this.Text = "Datos de un usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.ComboBox cbId;
    }
}