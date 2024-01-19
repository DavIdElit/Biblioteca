using System;

namespace Persistencia {
	internal class ClaveEjemplarPrestamo : IEquatable<ClaveEjemplarPrestamo> {
		private string codEjemplar;
		private string codLibro;
		private string codPrestamo;
		public ClaveEjemplarPrestamo(string codEjemplar, string codLibro, string codPrestamo) {
			this.codEjemplar = codEjemplar;
			this.codLibro = codLibro;
			this.codPrestamo = codPrestamo;
		}

		public String CodEjemplar {
			get {
				return this.codEjemplar;
			}
		}
		public String CodLibro {
			get {
				return this.codLibro;
			}
		}
		public String CodPrestamo {
			get {
				return this.codPrestamo;
			}
		}
		public bool Equals(ClaveEjemplarPrestamo other) {
			return (this.CodEjemplar.Equals(CodEjemplar)
				&& this.CodLibro.Equals(CodLibro)
				&& this.CodPrestamo.Equals(CodPrestamo));
		}
	}
}
