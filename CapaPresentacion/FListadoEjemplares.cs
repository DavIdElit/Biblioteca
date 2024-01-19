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
	public partial class FListadoEjemplares : Form {
		/// <summary>
		///		Esta clase muestra una lista de los ejemplares de un libro concreto dentro del DataGridView del formulario
		///		
		///		PRE: lE tiene que estar inicializado con la lista de ejemplares del libro que se quiere mostrar
		///		POST:Se inicializa un FListadoEjemplares y el componente data_Ejemplares contiene los
		///			Ejemplar de la List pasada por parametro
		/// </summary>
		/// <param name="lE"></param>
		public FListadoEjemplares(List<Ejemplar> lE) {
			InitializeComponent();
			addEjemplar(lE);
		}

		/// <summary>
		///		PRE:lE tiene que estar inicializada previamente
		///		POST:Todos los Ejemplar que contiene la lista con añadidos a data_Ejemplares
		/// </summary>
		/// <param name="lE"></param>
		private void addEjemplar(List<Ejemplar> lE) {
			foreach(Ejemplar e in lE){
				string[] fila = { e.CodigoLibro, e.CodigoEjemplar};
				this.data_Ejemplares.Rows.Add(fila);
			}
		}
	}
}
