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
	/// <summary>
	///		Formulario que sirve como el primero paso para las busquedas, bajas y altas de los distintos objetos de la aplicacion
	/// </summary>
	public partial class FClave : Form {
		/// <summary>
		/// "tipo" sirve para cambiar los textos que se muestran al personal dependiendo del tipo del que se han invocado el formulario
		/// "clave" sirve para indicar la clave por la que se quiere realizar las operaciones, se usa para pasar a los formularios de
		///		operaciones
		/// </summary>
		private string tipo;
		private string clave;
		/// <summary>
		///		PRE: tipo y clave tienen que estar inicializados previamente
		///		POST:Se crea un nuevo objeto FClave en el que los elementos que se muestran son
		///			los que se han indicado mediante el parametro tipo
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="clave"></param>
		public FClave(string tipo, string clave) {
			InitializeComponent();
			this.tipo = tipo;
			this.clave = clave;
			if (this.tipo.Equals("libro")) {
				this.Text = "Introducir ISBN";
				this.labelTipo.Text = "ISBN";
			} else if (this.tipo.Equals("ejemplar")) {
				this.Text = "Introducir ISBN";
				this.labelTipo.Text = "ISBN";
			} else if(this.tipo.Equals("prestamo")){
				this.Text = "Introducir código prestamo";
				this.labelTipo.Text = "Código";
			} else if (this.tipo.Equals("usuario"))
			{
                this.Text = "Introducir id del usuario";
                this.labelTipo.Text = "Id";
            }
		}
		public string Tipo {
			get {
				return this.tipo;
			}
		}
		public string Clave {
			get {
				return this.clave;
			}
		}

		/// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:se llama al metodo validarDatos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOK_Click(object sender, EventArgs e) {
			this.validarDatos();
		}

		/// <summary>
		///		PRE: 
		///		POST: Se devuelve un DialogResult.OK si los datos introducidos no son 
		///			la cadena vacia
		/// </summary>
		private void validarDatos() {
			this.clave = this.textBox1.Text;
			if (this.clave.Equals("")) {
				MessageBox.Show("Introduce un "+this.tipo+" valido");
			} else {
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:Se devuelve un DialogResult.Cancel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCancelar_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}
	}
}
