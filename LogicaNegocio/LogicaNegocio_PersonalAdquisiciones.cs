using System;
using Persistencia;
using ModeloDominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio {
	/// <summary>
	///		Esta clase hereda de la clase base de la logica de 
	///			negocio que es la clase LogicaNegocio_PersonalBiblioteca, y 
	///			añade los metodos propios de lo que tiene que hacer 
	///			el personal de adquisiciones.
	/// </summary>
	public class LogicaNegocio_PersonalAdquisiciones : LogicaNegocio_PersonalBiblioteca {
		/// <summary>
		///		Constructor de LogicaNegocio_PersonalAdquisiciones, inicializa un objeto LogicaNegocio_PersonalAdquisiciones a partir
		///			de un Personal_adquisiciones
		///			
		///		PRE: Personal_adquisiciones tiene que estar previamente inicializado
		///		POST:Se devuelve un objeto LogicaNegocio_PersonalAdquisiciones inicializado con el Personal_adquisiciones pasado
		///			y una persistencia nueva
		/// </summary>
		/// <param name="pa"></param>
		public LogicaNegocio_PersonalAdquisiciones(Personal_adquisiciones pa) {
			base.Persistencia = new persistencia();
			base.PersonalBiblioteca = pa;
		}

		#region OPERACIONES LIBROS
		/// <summary>
		///		PRE: Libro tiene que estar inicializado
		///		POST:Se añade el libro pasado por parametro a la base de datos
		/// </summary>
		/// <param name="l"></param>
		public void altaLibro(Libro l) {
			Persistencia.altaLibro(l);
		}

		/// <summary>
		///		PRE: Libro tiene que estar inicializado
		///		POST:Se da de baja en la base de datos el libro que ha pasado por parametro
		/// </summary>
		/// <param name="l"></param>
		public void bajaLibro(Libro l) {
			Persistencia.bajaLibro(l);
		}

		/// <summary>
		///		PRE: Libro tiene que estar inicializado previamente
		///		POST:Se devuelve el libro equivalente al pasado por parametro
		///			en nuestra base de datos
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public Libro getLibro(Libro l) {
			return Persistencia.getLibro(l);
		}

		/// <summary>
		///		PRE: isbn tiene que estar inicializado previamente
		///		POST:se devuelve el libro de nuestra base de datos que tiene ese isbn
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns></returns>
		public Libro getLibroFromISBN(string isbn) {
			return Persistencia.getLibroFromISBN(isbn);
		}

		/// <summary>
		///		PRE:
		///		POST:Devuelve el libro que mas veces se ha leido en el ultimo mes
		/// </summary>
		/// <returns></returns>
		public string getLibroMasLeido() {
			return Persistencia.getLibroMasLeido();
		}
		#endregion

		#region OPERACIONES EJEMPLARES

		/// <summary>
		///		PRE: Ejemplar tiene que estar inicializada previamente
		///		POST:Da de alta en nuestra base de datos el ejemplar que se pasa por parametro
		/// </summary>
		/// <param name="e"></param>
		public void altaEjemplar(Ejemplar e) {
			Persistencia.altaEjemplar(e);
		}
		/// <summary>
		///		PRE: Ejemplar tiene que star inicializado previamente
		///		POST:Da de baja en nuestra base de datos el objeto ejemplar que se ha pasado por parametro
		/// </summary>
		/// <param name="e"></param>
		public void bajaEjemplar(Ejemplar e) {
			Persistencia.bajaEjemplar(e);
		}

		/// <summary>
		///		PRE: Ejemplar tiene que estar inicializado previamente
		///		POST:Devuelve el ejemplar de nuestra base de datos que es el equivalente al ejemplar que se pasa por parametro
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public Ejemplar getEjemplar(Ejemplar e) {
			return Persistencia.getEjemplar(e);
		}

		/// <summary>
		///		PRE: Libro tiene que estar inicializado previamente
		///		POST:Devuelve una lista con los ejemplares que tiene ese libro en nuestra base de datos
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public List<Ejemplar> getEjemplaresLibro(Libro l) {
			return Persistencia.getEjemplaresLibro(l);
		}
		/// <summary>
		///		PRE: Libro tiene que estar iniciado previamente
		///		POST:Devuelve la primera fecha en la que un ejemplar del libro que se pasa por pantalla esta disponible
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public DateTime getFchaEjemplarDisponible(Libro l) {
			return Persistencia.getFchaEjemplarDisponible(l);
		}
		#endregion

	}
}