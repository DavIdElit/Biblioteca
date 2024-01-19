using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDominio;

namespace CapaPresentacion {
	public partial class FLibro : Form {
		private string accion;
		/// <summary>
		///		Constructor de FLibro
		///		
		///		PRE: accion e isbn tienen que estar inicializadas previamente
		///		POST:Se devuelve un formulario creado con los parametros especificados y 
		///			dependiendo del valor de accion se deja como ReadOnly unos parametros y otros
		/// </summary>
		public FLibro(string accion, string isbn) {
			this.accion = accion;
			InitializeComponent();
			this.tb_ISBN.Text = isbn;
			//Dependiendo de la accion que se quiera realizar cambiamos las propiedades de los componentes del formulario
			if (accion.Equals("ver")) {
				this.Text = "Ver libro";
				this.tb_Titulo.ReadOnly = true;
				this.tb_Autor.ReadOnly = true;
				this.buttonOK.Visible = false;
				this.buttonCancel.Text = "Salir";
			} else if (accion.Equals("alta")) {
				this.Text = "Añadir libro";
				this.buttonOK.Text = "Añadir libro";
			} else if (accion.Equals("baja")) {
				this.Text = "Borrar libro";
				this.tb_Titulo.ReadOnly = true;
				this.tb_Autor.ReadOnly = true;
				this.buttonOK.Text = "Borrar libro";
			}
		}
		public void set_Titulo(string libro) {
			this.tb_Titulo.Text = libro;
		}
		public void set_Autor(string autor) {
			this.tb_Autor.Text = autor;
		}
		/// <summary>
		/// El boton de OK para las operaciones de alta y baja sirve para indicar que la accion
		///		se quiere realizar
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:devuelve un DialogResult.OK
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// El boton de cancelar se usa para cancelar las operaciones de alta y baja, y como boton
		///		de salir para la operacion de ver
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:devuelve un DialogResult.Cancel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}

		/// <summary>
		/// Devuelve el contenido introducido en los TextBox en forma de Libro
		///		PRE: 
		///		POST:Devuelve un objeto Libro inicializado con los valores Text de los
		///			TextBox
		/// </summary>
		public Libro getLibro() {
			return (new Libro(tb_ISBN.Text, tb_Titulo.Text, tb_Autor.Text));
		}
	}
}
