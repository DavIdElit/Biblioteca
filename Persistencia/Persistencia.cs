using System;
using ModeloDominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	public class persistencia {
		private Transformador transformador = new Transformador();

		/// <summary>
		///		Este metodo hace de constructor de la clase persistencia
		///		PRE:
		///		POST:Inicializa un objeto de la clase persistencia 
		/// </summary>
		public persistencia() {
			
			
			
		}

        /// <summary>
        ///		PRE:
        ///		POST: Añade los datos necesarios a la base de datos para 
        ///			poder realizar operaciones basicas sobre la misma
        /// </summary>
        public void rellenarBD()
		{
            //-------------------------------------------------------------------------------------------------------------//
            //Añadimos los dos usuarios a la base de datos para poder realizar operaciones con ellos
            Personal_adquisiciones pAdquisiciones = new Personal_adquisiciones(001, "Adquisiciones", "", "adquisiciones", "admin");
            Personal_de_sala pSala = new Personal_de_sala(002, "Sala", "", "sala", "admin");
            BD.INSERT(transformador.personalAdquisicionesToPersonalAdquisicionesDato(pAdquisiciones));
            BD.INSERT(transformador.personalSalaToPersonalSalaDato(pSala));

            //-------------------------------------------------------------------------------------------------------------//
            //Añado unos libros base
            BD.INSERT(transformador.libroToLibroDato(new Libro("1", "El quijote", "Miguel de Cervantes")));
            BD.INSERT(transformador.libroToLibroDato(new Libro("2", "Sherlock Holmes", "Arthur Conan Doyle")));
            BD.INSERT(transformador.libroToLibroDato(new Libro("3", "Mortadelo y Filemon: El sulfato atomico", "F. Ibañez")));
            BD.INSERT(transformador.libroToLibroDato(new Libro("4", "El señor de los anillos", "J.R.R. Tolkien")));
            BD.INSERT(transformador.libroToLibroDato(new Libro("5", "Racer", "Fernando Alonso")));
            //-------------------------------------------------------------------------------------------------------------//

            //-------------------------------------------------------------------------------------------------------------//
            //Añadimos ejemplares de estos libros a la base de datos
            //Para el quijote
            Ejemplar quijote1 = new Ejemplar("1", "1");
            Ejemplar quijote2 = new Ejemplar("1", "2");
            Ejemplar quijote3 = new Ejemplar("1", "3");
            Ejemplar quijote4 = new Ejemplar("1", "4");
            BD.INSERT(transformador.ejemplarToEjemplarDato(quijote1));
            BD.INSERT(transformador.ejemplarToEjemplarDato(quijote2));
            BD.INSERT(transformador.ejemplarToEjemplarDato(quijote3));
            BD.INSERT(transformador.ejemplarToEjemplarDato(quijote4));

            //Para Sherlock Holmes
            Ejemplar sherlock1 = new Ejemplar("2", "1");
            Ejemplar sherlock2 = new Ejemplar("2", "2");
            Ejemplar sherlock3 = new Ejemplar("2", "3");
            Ejemplar sherlock4 = new Ejemplar("2", "4");
            BD.INSERT(transformador.ejemplarToEjemplarDato(sherlock1));
            BD.INSERT(transformador.ejemplarToEjemplarDato(sherlock2));
            BD.INSERT(transformador.ejemplarToEjemplarDato(sherlock3));
            BD.INSERT(transformador.ejemplarToEjemplarDato(sherlock4));

            //Para Mortadelo y Filemon
            Ejemplar mortadelo1 = new Ejemplar("3", "1");
            Ejemplar mortadelo2 = new Ejemplar("3", "2");
            Ejemplar mortadelo3 = new Ejemplar("3", "3");
            Ejemplar mortadelo4 = new Ejemplar("3", "4");
            BD.INSERT(transformador.ejemplarToEjemplarDato(mortadelo1));
            BD.INSERT(transformador.ejemplarToEjemplarDato(mortadelo2));
            BD.INSERT(transformador.ejemplarToEjemplarDato(mortadelo3));
            BD.INSERT(transformador.ejemplarToEjemplarDato(mortadelo4));

            //El señor de los anillos
            Ejemplar lotr1 = new Ejemplar("4", "1");
            Ejemplar lotr2 = new Ejemplar("4", "2");
            Ejemplar lotr3 = new Ejemplar("4", "3");
            Ejemplar lotr4 = new Ejemplar("4", "3");
            BD.INSERT(transformador.ejemplarToEjemplarDato(lotr1));
            BD.INSERT(transformador.ejemplarToEjemplarDato(lotr2));
            BD.INSERT(transformador.ejemplarToEjemplarDato(lotr3));
            BD.INSERT(transformador.ejemplarToEjemplarDato(lotr4));

            //Racer
            Ejemplar racer1 = new Ejemplar("5", "1");
            Ejemplar racer2 = new Ejemplar("5", "2");
            Ejemplar racer3 = new Ejemplar("5", "3");
            Ejemplar racer4 = new Ejemplar("5", "4");
            BD.INSERT(transformador.ejemplarToEjemplarDato(racer1));
            BD.INSERT(transformador.ejemplarToEjemplarDato(racer2));
            BD.INSERT(transformador.ejemplarToEjemplarDato(racer3));
            BD.INSERT(transformador.ejemplarToEjemplarDato(racer4));
            //-------------------------------------------------------------------------------------------------------------//

            //-------------------------------------------------------------------------------------------------------------//
            Usuario jaime = new Usuario("1", "Jaime", "Cabal", "01234567J");
            Usuario david = new Usuario("2", "David", "De Pablo", "01234567D");
            Usuario samu = new Usuario("3", "Samuel", "Ruiz", "01234567S");
            BD.INSERT(transformador.UsuarioToUsuarioDato(jaime));
            BD.INSERT(transformador.UsuarioToUsuarioDato(david));
            BD.INSERT(transformador.UsuarioToUsuarioDato(samu));
            //-------------------------------------------------------------------------------------------------------------//

            //-------------------------------------------------------------------------------------------------------------//
            //Lista de ejemplares prestados:
            List<Ejemplar> prestamo1 = new List<Ejemplar>();
            prestamo1.Add(quijote1);
            prestamo1.Add(lotr1);

            List<Ejemplar> prestamo2 = new List<Ejemplar>();
            prestamo2.Add(quijote2);
            prestamo2.Add(mortadelo2);
            prestamo2.Add(lotr2);

            List<Ejemplar> prestamo3 = new List<Ejemplar>();
            prestamo3.Add(sherlock3);
            prestamo3.Add(lotr3);

            List<Ejemplar> prestamo4 = new List<Ejemplar>();
            prestamo4.Add(racer1);
            prestamo4.Add(racer2);
            prestamo4.Add(racer3);
            prestamo4.Add(racer4);
            //-------------------------------------------------------------------------------------------------------------//

            //-------------------------------------------------------------------------------------------------------------//
            //string cod_prestamo, string estado, DateTime fechaRealizacion, DateTime fechaFin, Personal_de_sala prestador, List<Ejemplar> ejemplarPrestado,Usuario usuario
            BD.INSERT(transformador.prestamoToPrestamoDato(new Prestamo("1", "prestado", DateTime.Today, DateTime.Today.AddMonths(1), pSala, prestamo1, jaime)));
            BD.INSERT(transformador.prestamoToPrestamoDato(new Prestamo("2", "prestado", DateTime.Today, DateTime.Today.AddMonths(-1), pSala, prestamo2, david)));
            BD.INSERT(transformador.prestamoToPrestamoDato(new Prestamo("3", "prestado", DateTime.Today, DateTime.Today.AddMonths(1), pSala, prestamo3, samu)));
            //-------------------------------------------------------------------------------------------------------------//

            //-------------------------------------------------------------------------------------------------------------//
            //Este sirve para comprobar si se devuelve correctamente la fecha de devolucion en caso de que un ejemplar
            BD.INSERT(transformador.prestamoToPrestamoDato(new Prestamo("4", "prestado", DateTime.Today, DateTime.Today.AddMonths(1), pSala, prestamo4, jaime)));
            //-------------------------------------------------------------------------------------------------------------//
        }

        #region LIBROS
        /// <summary>
        ///		Añade un objeto Libro a la base de datos de nuestra aplicacion
        ///		
        ///		PRE: Libro tiene que ser una variable que esta inicializada previamente
        ///		POST:El libro que se ha pasado como parametro es añadido a la base de datos
        /// </summary>
        /// <param name="l"></param>
        public void altaLibro(Libro l) {
			BD.INSERT(transformador.libroToLibroDato(l));
		}
		/// <summary>
		///		Da de baja un objeto Libro de la base de datos de nuestra aplicacion
		///		
		///		PRE: Libro tiene que ser una variable que esta inicializada previamente
		///		POST:El libro que se ha pasado como parametro es borrado de la base de datos
		/// </summary>
		/// <param name="l"></param>
		public void bajaLibro(Libro l) {
			BD.DELETE(transformador.libroToLibroDato(l));
		}
		/// <summary>
		///		Si el libro que se pasa por parametros existe en nuestra base de datos se devuelve y en caso
		///			de que este no exista se devuelve null
		///			
		///		PRE: Libro tiene que ser una variable que esta inicializada previamente
		///		POST:Si el objeto libro que se pasa por parametro esta en nuestra base de datos se devuelve y
		///			sino se devuelve null
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public Libro getLibro(Libro l) {
			LibroDato ld = BD.READ(transformador.libroToLibroDato(l));
			if (ld != null) {
				return transformador.libroDatoToLibro(ld);
			} else {
				return null;
			}
		}
		/// <summary>
		///		Busca en nuestra base de datos un libro que tenga el mismo ISBN y si lo encuentra lo devuelve,
		///			en caso contrario devuelve null
		///			
		///		PRE: isbn tiene que estar inicializada previamente
		///		POST:si en nuestra base de datos existe un libro con el mismo isbn este es devuelto y en caso contrario devuelve null
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns></returns>
		public Libro getLibroFromISBN(string isbn) {
			Libro l = null;
			foreach (LibroDato ld in BD.TLibro) {
				if (ld.Id.Equals(isbn)) {
					l = transformador.libroDatoToLibro(ld);
				}
			}
			return l;
		}
		/// <summary>
		///		Devuelve una lista con todos los libros disponibles en nuestra base de datos
		///		
		///		PRE: 
		///		POST: se devuelve una List<Libro> que esta inicializada con todos los libros que estan actualmente
		///			en nuestra base de datos
		/// </summary>
		/// <returns></returns>
		public List<Libro> getLibros() {
			List<Libro> ll = new List<Libro>();
			foreach (LibroDato ld in BD.TLibro) {
				ll.Add(transformador.libroDatoToLibro(ld));
			}
			return ll;
		}

		/// <summary>
		///		Devuelve el Libro de nuestra base de datos que mas veces aparece en nuestra tabla de prestamos
		///		
		///		PRE: 
		///		POST:Devuelve el libro de la base de datos que mas veces aparece en nuestra tabla de prestamos
		/// </summary>
		/// <returns></returns>
		public string getLibroMasLeido() {
			//Recorremos los prestamos y vamos contando el numero de veces que se ha prestado cada libro
			List<string> codigosLibro = new List<string>();
			List<Prestamo> prestamos = getPrestamos();
			foreach (Prestamo p in prestamos) {
				//La fecha tiene que ser de este mes
				if (DateTime.Now.Month == p.FechaRealizacion.Month && DateTime.Now.Year == p.FechaRealizacion.Year) {
					foreach (Ejemplar e in p.EjemplarPrestado) {
						codigosLibro.Add(e.CodigoLibro);
					}
				}
			}
			var masFrecuente = codigosLibro.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
			return (masFrecuente.ToString());
		}
		#endregion

		#region EJEMPLARES
		/// <summary>
		///		Da de alta un ejemplar en nuestra base de datos
		///		
		///		PRE: Ejemplar tiene que estar previamente inicializado 
		///		POST:El Ejemplar pasado por parametro se añade a nuestra base de datos
		/// </summary>
		/// <param name="e"></param>
		public void altaEjemplar(Ejemplar e) {
			BD.INSERT(transformador.ejemplarToEjemplarDato(e));
		}

		/// <summary>
		///		Da de baja un ejemplar en nuestra base de datos
		///		
		///		PRE: Ejemplar tiene que estar previamente inicializado
		///		POST:El ejemplar que se pasa por parametro se da de baja en nuestra base de datos
		/// </summary>
		/// <param name="e"></param>
		public void bajaEjemplar(Ejemplar e) {
			BD.DELETE(transformador.ejemplarToEjemplarDato(e));
		}

		/// <summary>
		///		Si el ejemplar que se pasa por parametro esta en nuestra base de datos se devuelve
		///		PRE: Ejemplar tiene que estar inicializado previamente
		///		POST:Si el ejemplar que se pasa por parametro tiene un equivalente en nuestra base de datos, el 
		///			de la base de datos se devuelve
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public Ejemplar getEjemplar(Ejemplar e) {
			EjemplarDato ejd = BD.READ(transformador.ejemplarToEjemplarDato(e));
			if (ejd!=null) {
				return transformador.ejemplarDatoToEjemplar(ejd);
			}
			else {
				return null;
			}
		}

		/// <summary>
		///		Devuelve la lista de ejemplares que tiene un libro
		///		
		///		PRE: Libro tiene que esta inicializado
		///		POST:Se devuelve una lista de los ejemplares que tiene ese libro en nuestra base de datos
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public List<Ejemplar> getEjemplaresLibro(Libro l) {
			List<Ejemplar> ejemplaresLibro = new List<Ejemplar>();
			foreach(EjemplarDato ej in BD.TEjemplar) {
				if (ej.getCodigoLibro().Equals(l.CodigoLibro)) {
					ejemplaresLibro.Add(transformador.ejemplarDatoToEjemplar(ej));
				}
			}
			return ejemplaresLibro;
		}

		/// <summary>
		///		Devuelve la lista de ejemplares que tiene un libro y que estan disponibles
		///		
		///		PRE: Libro tiene que estar previamente inicializado
		///		POST:Devuelve la lista de ejemplares que tiene un libro y que estan disponibles
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public List<Ejemplar> getEjemplaresDisponibles(Libro l) {
			List<EjemplarDato> ejemplaresTotal = new List<EjemplarDato>();
			foreach (EjemplarDato ejd in BD.TEjemplar) {
				if (l.CodigoLibro.Equals(ejd.getCodigoLibro())) {
					ejemplaresTotal.Add(ejd);
				}
			}
			List<Ejemplar> ejemplaresNoPrestados = new List<Ejemplar>();
			foreach (EjemplarPrestamoDato epd in BD.TEjemplarPrestamo) {
				if (l.CodigoLibro.Equals(epd.getCodigoLibro())) {
					//Ejemplares que tienen el mismo libro
					EjemplarDato ejemplarActual = new EjemplarDato(new ClaveEjemplar(epd.getCodigoLibro(),epd.getCodigoEjemplar()));
					if (ejemplaresTotal.Contains(ejemplarActual)) {
						ejemplaresTotal.Remove(ejemplarActual);
					}
				}
			}
			List<Ejemplar> ejemplaresPrestados = new List<Ejemplar>();
			foreach (EjemplarDato ejem in ejemplaresTotal) {
				ejemplaresPrestados.Add(transformador.ejemplarDatoToEjemplar(ejem));
			}
			return ejemplaresPrestados;
		}

		/// <summary>
		///		Devuelve la primera fecha en la que un ejemplar de un libro esta disponible para ser alquilado
		///		
		///		PRE: Libro tiene que estar previamente inicializado
		///		POST:Se devuelve la primera fecha en la que un ejemplar esta disponible
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public DateTime getFchaEjemplarDisponible(Libro l) {
			//Recorrer EjemplarPrestamoDato para sacar los libros prestados
			List<DateTime> fechasDevolucion = new List<DateTime>();
			List<Prestamo> prestamos = getPrestamos();
			foreach (Prestamo p in prestamos) {
				if (p.EjemplarPrestado.Any(ej => ej.CodigoLibro.Equals(l.CodigoLibro))) {
					fechasDevolucion.Add(p.FechaFin);
				}
			}
			var listaFechasOrdenada = from d in fechasDevolucion
						let val = Math.Abs(Convert.ToDouble((d - DateTime.Now).TotalMinutes.ToString()))
						orderby val
						select d;
			return (listaFechasOrdenada.FirstOrDefault().AddDays(1));
		}
        #endregion

        #region PRESTAMOS
        /// <summary>
        ///		Añade un objeto Prestamo a la base de datos de nuestra aplicacion
        ///		
        ///		PRE: Prestamo tiene que ser una variable que esta inicializada previamente
        ///		POST:El prestamo que se ha pasado como parametro es añadido a la base de datos
        /// </summary>
        /// <param name="p"></param>
        public void altaPrestamo(Prestamo p)
        {
            BD.INSERT(transformador.prestamoToPrestamoDato(p));
        }
        /// <summary>
		///		Si el prestamo que se pasa por parametros existe en nuestra base de datos se devuelve y en caso
		///			de que este no exista se devuelve null
		///			
		///		PRE: Prestamo tiene que ser una variable que esta inicializada previamente
		///		POST:Si el objeto prestamo que se pasa por parametro esta en nuestra base de datos se devuelve y
		///			sino se devuelve null
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
        public Prestamo getPrestamo(Prestamo p)
		{
			PrestamoDato pd = BD.READ(transformador.prestamoToPrestamoDato(p));
            if (pd != null)
            {
                return transformador.prestamoDatoToPrestamo(pd);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        ///		Busca en nuestra base de datos un prestamo que tenga el mismo cod_prestamo y si lo encuentra lo devuelve,
        ///			en caso contrario devuelve null
        ///			
        ///		PRE: cod_prestamo tiene que estar inicializada previamente
        ///		POST:si en nuestra base de datos existe un prestamo con el mismo cod_prestamo este es devuelto y en caso contrario devuelve null
        /// </summary>
        /// <param name="cod_prestamo"></param>
        /// <returns></returns>
        public Prestamo getPrestamoFromCod(string cod_prestamo)
		{
			Prestamo p = null;
            foreach (PrestamoDato pd in BD.TPrestamo)
            {
                if (pd.Id.Equals(cod_prestamo))
                {
                    p = transformador.prestamoDatoToPrestamo(pd);
                }
            }
            return p;
        }
        /// <summary>
        ///		Busca en nuestra base de datos los prestamos que haya hecho el Usuario con id_usuario,
        ///			en caso contrario devuelve null
        ///			
        ///		PRE: id_usuario tiene que estar inicializada previamente
        ///		POST: devuelve una lista con los prestamos que ha hecho dicho usuario y en caso contrario devuelve null
        /// </summary>
        /// <param name="id_usuario"></param>
        /// <returns></returns>
        public List<Prestamo> getPrestamosFromUsuario(string id_usuario)
        {
            List<Prestamo> l = new List<Prestamo>();
            foreach (PrestamoDato pd in BD.TPrestamo)
            {
                if (pd.Usuario.Id_usuario.Equals(id_usuario))
                {
                    l.Add(transformador.prestamoDatoToPrestamo(pd));
                }
            }
            return l;
        }
        /// <summary>
		///		Da de baja un objeto Prestamo de la base de datos de nuestra aplicacion
		///		
		///		PRE: Prestamo tiene que ser una variable que esta inicializada previamente
		///		POST:El prestamo que se ha pasado como parametro es borrado de la base de datos
		/// </summary>
		/// <param name="p"></param>
        public void bajaPrestamo(Prestamo p)
		{
            BD.DELETE(transformador.prestamoToPrestamoDato(p));
        }
        /// <summary>
		///		Devuelve una lista con todos los prestamos disponibles en nuestra base de datos
		///		
		///		PRE: 
		///		POST: se devuelve una List<Prestamo> que esta inicializada con todos los prestamos que estan actualmente
		///			en nuestra base de datos
		/// </summary>
		/// <returns></returns>
        public List<Prestamo> getPrestamos()
        {
            List<Prestamo> lp = new List<Prestamo>();
            foreach (PrestamoDato pd in BD.TPrestamo)
            {
                lp.Add(transformador.prestamoDatoToPrestamo(pd));
            }
            return lp;
        }

        #endregion

        #region USUARIOS

        /// <summary>
        ///		Da de alta un usuario en nuestra base de datos
        ///		
        ///		PRE: Usuario tiene que estar previamente inicializado 
        ///		POST:El Usuario pasado por parametro se añade a nuestra base de datos
        /// </summary>
        /// <param name="u"></param>
        public void altaUsuario(Usuario u)
        {
            BD.INSERT(transformador.UsuarioToUsuarioDato(u));
        }

        /// <summary>
        ///		Obtiene un usuario de la base de datos a partir de otro
        ///		
        ///		PRE: Usuario tiene que estar previamente inicializado 
        ///		POST: devuelve el usuario que coincide con el pasado por parrametros, o nulo si no lo encuentra
        /// </summary>
        /// <param name="u"></param>
        public Usuario getUsuario(Usuario u)
        {
            UsuarioDato ud = BD.READ(transformador.UsuarioToUsuarioDato(u));
            if (ud != null)
            {
                return transformador.UsuarioDatoToUsuario(ud);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        ///		Obtiene un usuario de la base de datos a partir de su id
        ///		
        ///		PRE: id_usuario tiene que estar previamente inicializado 
        ///		POST: devuelve el usuario que cuyo id coincide con id_usuario, o nulo si no lo encuentra
        /// </summary>
        /// <param name="id_usuario"></param>
        public Usuario getUsuarioFromId(string id_usuario)
        {
            Usuario u = null;
            foreach (UsuarioDato ud in BD.TUsuario)
            {
                if (ud.Id.Equals(id_usuario))
                {
                    u = transformador.UsuarioDatoToUsuario(ud);
                }
            }
            return u;
        }
        /// <summary>
        ///		Da de baja un usuario en nuestra base de datos
        ///		
        ///		PRE: Usuario tiene que estar previamente inicializado
        ///		POST:El usuario que se pasa por parametro se da de baja en nuestra base de datos
        /// </summary>
        /// <param name="u"></param>
        public void bajaUsuario(Usuario u)
        {
            BD.DELETE(transformador.UsuarioToUsuarioDato(u));
        }
        /// <summary>
		///		Devuelve una lista con todos los usuarios en nuestra base de datos
		///		
		///		PRE: 
		///		POST: se devuelve una List<Usuario> que esta inicializada con todos los usuarios que estan actualmente
		///			en nuestra base de datos
		/// </summary>
		/// <returns></returns>
        public List<Usuario> getUsuarios()
        {
            List<Usuario> lu = new List<Usuario>();
            foreach (UsuarioDato ud in BD.TUsuario)
            {
                lu.Add(transformador.UsuarioDatoToUsuario(ud));
            }
            return lu;
        }

        #endregion

        #region PERSONAL
        /// <summary>
        ///		Obtiene el personal cuyos credenciales coinciden con username y password
        ///		
        ///		PRE: username y password no pueden ser nulos
        ///		POST: si existe un personal con username y password como credenciales, lo devuelve, si no, devuelve nulo
        /// </summary>
        /// <param name="l"></param>
        public Personal_biblioteca getPersonal(string username, string password)
		{
			Personal_bibliotecaDato d = BD.READ(new Personal_bibliotecaDato(0, "", "", username, password));
			if (d != null)
			{
				Personal_adquisicionesDato pa= d as Personal_adquisicionesDato;
				Personal_de_salaDato ps = d as Personal_de_salaDato;
				if (pa != null)
				{
					return transformador.personalAdquisicionesDatoToPersonalAdquisiciones(pa);
				}else if(ps != null)
				{
					return transformador.personalSalaDatoToPersonalSala(ps);
				}
				else
				{
					return transformador.personalBiblioDatoToPersonalBiblio(d);
				}

            }
			else
			{
				return null;
			}
		}

        #endregion

    }
}