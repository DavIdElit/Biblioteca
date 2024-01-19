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

namespace CapaPresentacion {
	public partial class FUsuario : Form {

		private string accion;

		/// <summary>
		///   PRE:
		///   POST: inicia los datos del formulario y segun la accion que sea, realiza los cambios necesarios
		/// </summary>
		/// <param name="accion"></param>
		/// <param name="clave"></param>
		public FUsuario(string accion,string clave) {
			this.accion = accion;
			InitializeComponent();
			this.tbId.Text = clave;
			if (accion.Equals("alta"))
			{
				bAceptar.Text = "Añadir usuario";
				tbId.Text = clave;
				this.Text = "Añadir usuario";
			}else if (accion.Equals("baja"))
			{
				bAceptar.Text = "Eliminar usuario";
				this.Text = "Eliminar usuario";
				this.tbNombre.ReadOnly = true;
				this.tbApellidos.ReadOnly = true;
				this.tbDNI.ReadOnly = true;
				this.tbId.ReadOnly = true;
            }else if (accion.Equals("ver"))
			{
				bAceptar.Visible = false;
				this.Text = "Ver usuario";
                this.tbId.ReadOnly = true;
                this.tbNombre.ReadOnly = true;
                this.tbApellidos.ReadOnly = true;
                this.tbDNI.ReadOnly = true;
				this.bAceptar.Visible = false;
				this.bCancelar.Text = "Salir";
            }

		}
		/// <summary>
		///	  PRE:
		///	  POST: añade el nombre a su respectiva casilla
		/// </summary>
		/// <param name="nombre"></param>
		public void setNombre(string nombre)
		{
			this.tbNombre.Text = nombre;
		}
        /// <summary>
        ///   PRE:
        ///	  POST: añade los apellidos a su respectiva casilla
        /// </summary>
        /// <param name="apellidos"></param>
        public void setApellidos(string apellidos)
        {
            this.tbApellidos.Text = apellidos;
        }
        /// <summary>
        ///   PRE:
        ///	  POST: añade el dni a su respectiva casilla
        /// </summary>
        /// <param name="dni"></param>
        public void setDNI(string dni)
		{
			this.tbDNI.Text = dni;
		}

		/// <summary>
		///   PRE:
		///   POST: devuelve un usuario creado a partir de los datos en el formulario
		/// </summary>
		/// <returns></returns>
        public Usuario GetUsuario()
		{
			return new Usuario(this.tbId.Text, this.tbNombre.Text, this.tbApellidos.Text, this.tbDNI.Text);
		}
		/// <summary>
		///   PRE:
		///   POST: establece el resultado como OK y cierra el formulario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bAceptar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
        /// <summary>
        ///   PRE:
        ///   POST: establece el resultado como Cancel y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			this.Close();
		}
	}
}
