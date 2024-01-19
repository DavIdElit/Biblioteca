using System;
using ModeloDominio;
using Persistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio {
	public abstract class LogicaNegocio_PersonalBiblioteca {
		private Personal_biblioteca personal_Biblioteca;
		private persistencia pers;

		#region PROPIEDADES
		public Personal_biblioteca PersonalBiblioteca {
			get {
				return personal_Biblioteca;
			}
			set {
				this.personal_Biblioteca = value;
			}
		}
		public persistencia Persistencia {
			get {
				return this.pers;
			}
			set {
				this.pers = value;
			}
		}
        #endregion

        #region METODOS USUARIO
        /// <summary>
        ///		Da de alta un usuario en nuestra base de datos
        ///		
        ///		PRE: Usuario tiene que estar previamente inicializado 
        ///		POST:El Usuario pasado por parametro se añade a nuestra base de datos
        /// </summary>
        /// <param name="u"></param>
        public void altaUsuario(Usuario u)
        {
            Persistencia.altaUsuario(u);
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
            Persistencia.bajaUsuario(u);
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
            return Persistencia.getUsuario(u);
        }
        /// <summary>
        ///		Obtiene un usuario de la base de datos a partir de su id
        ///		
        ///		PRE: id_usuario tiene que estar previamente inicializado 
        ///		POST: devuelve el usuario que cuyo id coincide con id_usuario, o nulo si no lo encuentra
        /// </summary>
        /// <param name="id_usuario"></param>
        public Usuario getUsuarioFromID(string id_usuario)
        {
            return Persistencia.getUsuarioFromId(id_usuario);
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
            return Persistencia.getUsuarios();
        }

        #endregion

        #region METODOS PRESTAMOS
        public List<Prestamo> getPrestamos() {
            return Persistencia.getPrestamos();
        }
        #endregion

        #region METODOS EJEMPLARES
        public List<Ejemplar> getEjemplaresDisponibles(Libro l)
        {
            return Persistencia.getEjemplaresDisponibles(l);
        }
        #endregion

        #region METODOS LIBROS
        /// <summary>
        ///     PRE: isbn tiene que estar previamente inicializado
        ///     POST:Devuelve el libro de nuestra base de datos que tiene ese isbn,
        ///         en caso de que no haya ningun libro con este isbn devuelve null
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        
        public Libro getLibroFromISBN(string isbn) {
            return Persistencia.getLibroFromISBN(isbn);
        }
        /// <summary>
        ///     PRE:
        ///     POST:Devuelve una lista de todos los Libro de nuestra base de datos
        /// </summary>
        /// <returns></returns>
        public List<Libro> getLibros() {
            return Persistencia.getLibros();
        }

        #endregion
    }
}