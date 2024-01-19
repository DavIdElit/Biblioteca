namespace CapaPresentacion
{
    partial class FLogin
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
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbUsuario
			// 
			this.tbUsuario.Location = new System.Drawing.Point(61, 49);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(100, 20);
			this.tbUsuario.TabIndex = 0;
			// 
			// tbPassword
			// 
			this.tbPassword.HideSelection = false;
			this.tbPassword.Location = new System.Drawing.Point(61, 138);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(100, 20);
			this.tbPassword.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// bLogin
			// 
			this.bLogin.Location = new System.Drawing.Point(61, 197);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(90, 23);
			this.bLogin.TabIndex = 4;
			this.bLogin.Text = "Iniciar sesión";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// FLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 260);
			this.Controls.Add(this.bLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsuario);
			this.Name = "FLogin";
			this.Text = "Bienvenido";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FLogin_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLogin;
	}
}