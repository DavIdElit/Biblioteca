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
	public partial class FEjemplares : Form {
		private string accion;

		/// <summary>
		///		PRE: accion e isbn tienen que estar inicializados previamente
		///		POST:se crea un nuevo objeto FEjemplares con los parametros pasados
		/// </summary>
		/// <param name="accion"></param>
		/// <param name="isbn"></param>
		public FEjemplares(string accion, string isbn) {
			this.accion = accion;
			InitializeComponent();
			this.tb_ISBN.Text = isbn;
			if (accion.Equals("ver")) {
				this.buttonOK.Visible = false;
				this.tb_ISBN.ReadOnly = true;
				this.tb_CodigoEjemplar.ReadOnly = true;
				this.buttonCancelar.Text = "Salir";
			} else if (accion.Equals("baja")) {
				this.tb_ISBN.ReadOnly = true;
				this.Text = "Dar de baja";
				this.buttonOK.Text = "Dar de baja";
			} else if (accion.Equals("alta")) {
				this.tb_ISBN.ReadOnly = true;
				this.Text = "Dar de alta";
				this.buttonOK.Text = "Dar de alta";
			}
		}
		/// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:se devuelve un DialogResult.OK
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}

		/// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:se devuelve un DialogResult.Cancel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCancelar_Click(object sender, EventArgs e) {
			if (this.accion.Equals("ver")) {
				this.Close();
			} else {
				DialogResult = DialogResult.Cancel;
			}
		}

		/// <summary>
		///		PRE:
		///		POST:se devuelve un Ejemplar creado con los datos del Text de los TextBoxes del 
		///			formulario
		/// </summary>
		/// <returns></returns>
		public Ejemplar getEjemplar() {
			return (new Ejemplar(tb_ISBN.Text, tb_CodigoEjemplar.Text));
		}
	}
}