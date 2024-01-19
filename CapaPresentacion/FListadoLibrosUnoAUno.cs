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
using LogicaNegocio;

namespace CapaPresentacion {
	public partial class FListadoLibrosUnoAUno : Form {
		private LogicaNegocio_PersonalAdquisiciones ln_pa;

		/// <summary>
		///		PRE: librosBD y ln_pa tienen que estar inicializados previamente
		///		POST:Se crea un FListadoLibrosUnoAUno y se le asigna a bindingNavigator_Libros
		///			librosBD para que se puedam ver los datos de los libros de manera individual
		/// </summary>
		/// <param name="librosBD"></param>
		/// <param name="ln_pa"></param>
		public FListadoLibrosUnoAUno(List<Libro> librosBD,LogicaNegocio_PersonalAdquisiciones ln_pa) {
			this.ln_pa = ln_pa;
			InitializeComponent();
			BindingSource bindS = new BindingSource();
			bindS.DataSource = librosBD;
			bindingNavigator_Libros.BindingSource = bindS;
			int i = 0;
			int.TryParse(bindingNavigator_Libros.PositionItem.Text, out i);
			if (i != 0) {
				Libro l = bindS[i - 1] as Libro;
				if (l != null) {
					datosLibro.NumeroEjemplares = ln_pa.getEjemplaresLibro(l).Count;
					datosLibro.LibroActual= l;
				}
			}
		}

		/// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {
			int i = 0;
			int.TryParse(bindingNavigator_Libros.PositionItem.Text, out i);
			if (i != 0) {
				Libro l = bindingNavigator_Libros.BindingSource[i - 1] as Libro;
				if (l != null) {
					datosLibro.NumeroEjemplares = ln_pa.getEjemplaresLibro(l).Count;
					datosLibro.LibroActual = l;
				}
			}
		}
	}
}
