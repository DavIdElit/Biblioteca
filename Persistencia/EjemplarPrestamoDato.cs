using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	internal class EjemplarPrestamoDato : Entity<ClaveEjemplarPrestamo>{
		private ClaveEjemplarPrestamo clave;
		public EjemplarPrestamoDato(ClaveEjemplarPrestamo c) : base(c) {

			this.clave = c;

		}
		public ClaveEjemplarPrestamo Clave {
			get {
				return clave;
			}
			set {
				clave = value;
			}
		}
		public String getCodigoLibro() {
			return this.Clave.CodLibro;
		}
		public String getCodigoEjemplar() {
			return this.Clave.CodEjemplar;
		}
		public String getCodigoPrestamo() {
			return this.Clave.CodPrestamo;
		}
	}
}