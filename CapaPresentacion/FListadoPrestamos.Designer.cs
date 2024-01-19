
namespace CapaPresentacion {
	partial class FListadoPrestamos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_Prestamos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLibrosPrestados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrestamoCalculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_Prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Prestamos
            // 
            this.data_Prestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Prestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Prestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_Prestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Prestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cLibrosPrestados,
            this.cPrestamoCalculado});
            this.data_Prestamos.Location = new System.Drawing.Point(3, 12);
            this.data_Prestamos.Name = "data_Prestamos";
            this.data_Prestamos.Size = new System.Drawing.Size(1129, 312);
            this.data_Prestamos.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo Prestamo ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI Usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cLibrosPrestados
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cLibrosPrestados.DefaultCellStyle = dataGridViewCellStyle6;
            this.cLibrosPrestados.HeaderText = "Libros prestados";
            this.cLibrosPrestados.Name = "cLibrosPrestados";
            this.cLibrosPrestados.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cPrestamoCalculado
            // 
            this.cPrestamoCalculado.HeaderText = "Préstamo calculado";
            this.cPrestamoCalculado.Name = "cPrestamoCalculado";
            // 
            // FListadoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 336);
            this.Controls.Add(this.data_Prestamos);
            this.Name = "FListadoPrestamos";
            this.Text = "Listado de prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.data_Prestamos)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView data_Prestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLibrosPrestados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrestamoCalculado;
    }
}