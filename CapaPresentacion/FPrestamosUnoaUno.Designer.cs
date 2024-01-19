namespace CapaPresentacion
{
    partial class FPrestamosUnoaUno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrestamosUnoaUno));
            this.bindingNavigator_Prestamos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.botonAnterior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.datosPrestamo = new CapaPresentacion.DatosPrestamo();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Prestamos)).BeginInit();
            this.bindingNavigator_Prestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator_Prestamos
            // 
            this.bindingNavigator_Prestamos.AddNewItem = null;
            this.bindingNavigator_Prestamos.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_Prestamos.DeleteItem = null;
            this.bindingNavigator_Prestamos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonAnterior,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator_Prestamos.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_Prestamos.MoveFirstItem = null;
            this.bindingNavigator_Prestamos.MoveLastItem = null;
            this.bindingNavigator_Prestamos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_Prestamos.MovePreviousItem = this.botonAnterior;
            this.bindingNavigator_Prestamos.Name = "bindingNavigator_Prestamos";
            this.bindingNavigator_Prestamos.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_Prestamos.Size = new System.Drawing.Size(431, 25);
            this.bindingNavigator_Prestamos.TabIndex = 1;
            this.bindingNavigator_Prestamos.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // botonAnterior
            // 
            this.botonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonAnterior.Enabled = false;
            this.botonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("botonAnterior.Image")));
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.RightToLeftAutoMirrorImage = true;
            this.botonAnterior.Size = new System.Drawing.Size(23, 22);
            this.botonAnterior.Text = "Move previous";
            this.botonAnterior.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // datosPrestamo
            // 
            this.datosPrestamo.Location = new System.Drawing.Point(12, 28);
            this.datosPrestamo.Name = "datosPrestamo";
            this.datosPrestamo.Size = new System.Drawing.Size(407, 268);
            this.datosPrestamo.TabIndex = 2;
            // 
            // FPrestamosUnoaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 296);
            this.Controls.Add(this.datosPrestamo);
            this.Controls.Add(this.bindingNavigator_Prestamos);
            this.Name = "FPrestamosUnoaUno";
            this.Text = "Listado de prestamos uno a uno";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Prestamos)).EndInit();
            this.bindingNavigator_Prestamos.ResumeLayout(false);
            this.bindingNavigator_Prestamos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator_Prestamos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton botonAnterior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DatosPrestamo datosPrestamo;
    }
}