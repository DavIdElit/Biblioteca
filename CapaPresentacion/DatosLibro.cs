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
	public partial class DatosLibro : UserControl {
		/// <summary>
		///		PRE:
		///		POST: Se devuelve un control de usuario DatosLibro inicializado
		/// </summary>
		public DatosLibro() {
			InitializeComponent();
		}

		/// <summary>
		///		PRE: value tiene que estar inicializado
		///		POST:Se asignan los valores de value a los TextBox de DatosLibro
		/// </summary>
		public Libro LibroActual {
			set {
				Libro l = value;
				this.tb_ISBN.Text = l.CodigoLibro;
				this.tb_titulo.Text = l.NombreLibro;
				this.tb_autor.Text = l.NombreAutor;
			}
		}

		/// <summary>
		///		PRE: value tiene que estar inicializado
		///		POST:se asigna el valor de value a tb_NumEjemplares
		/// </summary>
		public int NumeroEjemplares {
			set {
				this.tb_NumEjemplares.Text = value.ToString();
			}
		}
	}
}
