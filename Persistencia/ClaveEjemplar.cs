using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	internal class ClaveEjemplar : IEquatable<ClaveEjemplar> {
		private string cod_ejemplar;
		private string cod_libro;
		/// <summary>
		///		PRE: cod_E y cod_L tienen que estar previamente inicializados con los datos respectivos
		///		POST:se devuelve un ClaveEjemplar iniciada con los parametros indicados
		/// </summary>
		/// <param name="cod_E"></param>
		/// <param name="cod_L"></param>
		public ClaveEjemplar(string cod_E, string cod_L)	{
			this.cod_ejemplar = cod_E;
			this.cod_libro = cod_L;
		}
		/// <summary>
		///		Propiedad para el atributo cod_ejemplar
		/// </summary>
		public string CodEjemplar{
			get {
				return this.cod_ejemplar;
			}
			set {
				this.cod_ejemplar = value;
			}
		}
		/// <summary>
		///		Propiedad para el atributo cod_ejemplar
		/// </summary>
		public string CodLibro {
			get {
				return this.cod_libro;
			}
			set {
				this.cod_libro = value;
			}
		}
		/// <summary>
		///		Sobreescritura del metodo equals
		///		PRE: ce tienen que estar iniciado previamente con el objeto al que se quiere comparar el objeto actual
		///		POST:Devuelve true si los atributos del ClaveEjemplar actual y del ClaveEjemplar al que se quiere comparar son iguales
		///				y false en caso contrario
		/// </summary>
		/// <param name="ce"></param>
		/// <returns></returns>
		public bool Equals(ClaveEjemplar ce) {
			return ((this.cod_ejemplar.Equals(ce.CodEjemplar)) && (this.cod_libro.Equals(ce.CodLibro)));
		}
	}
}
