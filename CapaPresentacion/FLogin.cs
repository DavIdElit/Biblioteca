using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FLogin : Form
    {

        private LogicaNegocio_Login login;

        private Personal_biblioteca personal;

        /// <summary>
        ///   PRE: login debe estar inicializado
        ///   POST: inicia el objeto FLogin
        /// </summary>
        /// <param name="login"></param>
        public FLogin(LogicaNegocio_Login login)
        {
            InitializeComponent();
            this.login = login;
            this.personal = null;
        }

        public Personal_biblioteca Personal
        {
            get { return personal; }
        }
        /// <summary>
        ///   PRE:
        ///   POST: comprueba si el usuario introducido existe en la base de datos y lo asigna al atributo personal. Si existe, se cierra el formulario. Si no, enseña un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            personal = this.login.login(tbUsuario.Text, tbPassword.Text);
            if (personal == null)
            {
                MessageBox.Show("Credenciales incorrectos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }
        /// <summary>
        ///   PRE:
        ///   POST: cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void FLogin_FormClosed(object sender, FormClosedEventArgs e) {
            this.Dispose();
		}
	}
}
