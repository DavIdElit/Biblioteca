using System;
using ModeloDominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class FListadoLibros : Form {
		/// <summary>
		///		PRE:lL tiene que estar inicializada previamente
		///		POST:Se crea un FListadoLibros y se le asigna a data_Libros todos
		///			los Libro que contiene lL
		/// </summary>
		/// <param name="lL"></param>
		public FListadoLibros(List<Libro> lL) {
			InitializeComponent();
			addLibros(lL);
		}

		/// <summary>
		///		PRE: lL tiene que estar inicializada previamente
		///		POST:Todos los Libro de lL son añadidos a data_Libros
		/// </summary>
		/// <param name="lL"></param>
		public void addLibros(List<Libro> lL) {
			foreach (Libro l in lL) {
				string[] fila = { l.CodigoLibro, l.NombreAutor, l.NombreLibro };
				this.data_Libros.Rows.Add(fila);
			}
		}
	}
}