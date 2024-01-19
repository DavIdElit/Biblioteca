using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	internal class EjemplarDato : Entity<ClaveEjemplar>{

		//private ClaveEjemplar clave;
		/// <summary>
		///		Constructor principal de la clave, crea un objeto EjemplarDato
		///		
		///		PRE: clave tiene que estar iniciado previamente
		///		POST:se crea un nuevo EjemplarDato con el valor de la clave
		/// </summary>
		/// <param name="clave"></param>
		public EjemplarDato(ClaveEjemplar clave) : base(clave) {
			
		}
		/// <summary>
		///		PRE:
		///		POST:devuelve un string con el CodLibro de el objeto
		/// </summary>
		public string getCodigoLibro() {
			return base.Id.CodLibro;
		}


		/// <summary>
		///		PRE:
		///		POST:devuelve un string con el CodEjemplar de el objeto
		/// </summary>
		public string getCodigoEjemplar() {
			return this.Id.CodEjemplar;
		}
	}
}
