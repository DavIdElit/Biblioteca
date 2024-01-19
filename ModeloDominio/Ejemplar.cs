using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio {
	public class Ejemplar : IEquatable<Ejemplar> {
		//Atributos
		private string codigoLibro;
		private string codigoEjemplar;

		//Propiedades
		public string CodigoLibro {
			get {
				return this.codigoLibro;
			}
		}
		public string CodigoEjemplar {
			get {
				return this.codigoEjemplar;
			}
		}
		/// <summary>
		/// Constructor con parametros de la clase Ejemplar
		///		PRE: codL y codE tienen que estar iniciadas previamente
		///		POST:Se crea un nuevo objeto Ejemplar
		/// </summary>
		/// <param name="codL"></param>
		/// <param name="codE"></param>
		public Ejemplar(string codL, string codE) {
			this.codigoLibro = codL;
			this.codigoEjemplar = codE;
		}

		/// <summary>
		/// Sobreescritura del metodo Equals generico
		///		PRE: Ejemplar tiene que estar inicializado previamente
		///		POST:Devuelve True si el Ejemplar actual y el que se pasa por parametro tienen el mismo codigoEjemplar y codigoLibro
		/// </summary>
		/// <param name="ej"></param>
		public bool Equals(Ejemplar ej) {
			return ((this.codigoEjemplar == ej.CodigoEjemplar) && (this.codigoLibro== ej.CodigoLibro));
		}

		/// <summary>
		/// Sobreescritura del metodo ToString generico
		///		PRE: 
		///		POST:Una string legible de los atributos de esta clase
		/// </summary>
		public override string ToString() {
			return "Codigo del Libro: " + codigoLibro
				+"\r\nCodigo del Ejemplar: " + codigoEjemplar;
		}
	}
}
