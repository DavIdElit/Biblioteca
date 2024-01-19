using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	internal class LibroDato : Entity<string> {
		private string nombreLibro;
		private string nombreAutor;

		//base(cl) indica que en esta clase el equivalente al id de Entity es cl
		/// <summary>
		///		PRE: cod_libro, nl y na tienen que estar previamente inicializador
		///		POST:Crea un nuevo objeto LibroDato con los parametros pasados
		/// </summary>
		/// <param name="cod_libro"></param>
		/// <param name="nl"></param>
		/// <param name="na"></param>
		public LibroDato(string cod_libro, string nl, string na) : base(cod_libro) { 
			this.nombreLibro = nl;
			this.nombreAutor = na;
		}

		/// <summary>
		///		GET
		///		PRE:
		///		POST: devuelve el valor de nombreLibro
		///		
		///		SET
		///		PRE: value tiene que estar inicializado
		///		POST:devuelve el valor de nombreLibro
		/// </summary>
		public string NombreLibro {
			get {
				return this.nombreLibro;
			}
			set {
				this.nombreLibro = value;
			}
		}

		/// <summary>
		///		GET
		///		PRE:
		///		POST: devuelve el valor de nombreAutor
		///		
		///		SET
		///		PRE: value tiene que estar inicializado
		///		POST:devuelve el valor de nombreAutor
		/// </summary>
		public string NombreAutor {
			get {
				return this.nombreAutor;
			}
			set {
				this.nombreAutor = value;
			}
		}

		/// <summary>
		///		PRE: 
		///		POST:Devuelve el contenido de este LibroDato de forma legible en un string
		/// </summary>
		/// <returns></returns>
		public override String ToString() {
			return "Libro: "+NombreLibro+ "\r\nAutor: " + NombreAutor;
		}
	}
}
