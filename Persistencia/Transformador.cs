using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	/// <summary>
	/// Esta clase se usa para convertir Objetos del modelo de negocio y pasarlos a LogicaNegocio, por ejemplo se convierte
	///		Libro a LibroDato
	/// </summary>
	class Transformador {
		#region LIBROS
		/// <summary>
		///		PRE: ld tiene que estar inicializado
		///		POST:se crea un nuevo Libro usando los datos de ld y se devuelve
		/// </summary>
		public Libro libroDatoToLibro(LibroDato ld) {
			return new Libro(ld.Id, ld.NombreLibro, ld.NombreAutor);
		}

		/// <summary>
		///		PRE: l tiene que estar inicializado
		///		POST:se crea un nuevo LibroDato usando los datos de l y se devuelve
		/// </summary>
		public LibroDato libroToLibroDato(Libro l) {
			return new LibroDato(l.CodigoLibro, l.NombreLibro,l.NombreAutor);
		}
		#endregion

		#region EJEMPLARES

		/// <summary>
		///		PRE: ejD tiene que estar inicializado
		///		POST:se crea un nuevo Ejemplar usando los datos de ejD y se devuelve
		/// </summary>
		public Ejemplar ejemplarDatoToEjemplar(EjemplarDato ejD) {
			return new Ejemplar(ejD.getCodigoLibro(), ejD.getCodigoEjemplar());
		}

		/// <summary>
		///		PRE: ej tiene que estar inicializado
		///		POST:se crea un nuevo EjemplarDato usando los datos de ej y se devuelve
		/// </summary>
		public EjemplarDato ejemplarToEjemplarDato(Ejemplar ej) {
			ClaveEjemplar clEj = new ClaveEjemplar(ej.CodigoEjemplar,ej.CodigoLibro);
			return new EjemplarDato(clEj);
		}
        #endregion

        #region PERSONAL
        /// <summary>
        ///		PRE: pb tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_bibliotecaDato usando los datos de pb y se devuelve
        /// </summary>
        public Personal_bibliotecaDato personalBiblioToPersonalBiblioDato(Personal_biblioteca pb) {
			return new Personal_bibliotecaDato(pb.Num_Id,pb.Nombre,pb.Apellidos,pb.NomUsuario,pb.Password);
		}
        /// <summary>
        ///		PRE: pa tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_adquisicionesDato usando los datos de pa y se devuelve
        /// </summary>
        public Personal_adquisicionesDato personalAdquisicionesToPersonalAdquisicionesDato(Personal_adquisiciones pa) {
			return new Personal_adquisicionesDato(pa.Num_Id,pa.Nombre,pa.Apellidos,pa.NomUsuario,pa.Password);
		}
        /// <summary>
        ///		PRE: ps tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_de_salaDato usando los datos de ps y se devuelve
        /// </summary>
        public Personal_de_salaDato personalSalaToPersonalSalaDato(Personal_de_sala ps) {
			return new Personal_de_salaDato(ps.Num_Id, ps.Nombre, ps.Apellidos, ps.NomUsuario, ps.Password);
		}
        /// <summary>
        ///		PRE: pb tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_biblioteca usando los datos de pb y se devuelve
        /// </summary>
        public Personal_biblioteca personalBiblioDatoToPersonalBiblio(Personal_bibliotecaDato pb)
		{
			return new Personal_biblioteca(pb.Id, pb.Nombre, pb.Apellidos, pb.Usuario, pb.Password);
		}
        /// <summary>
        ///		PRE: ps tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_de_sala usando los datos de ps y se devuelve
        /// </summary>
        public Personal_de_sala personalSalaDatoToPersonalSala(Personal_de_salaDato ps)
        {
            return new Personal_de_sala(ps.Id, ps.Nombre, ps.Apellidos, ps.Usuario, ps.Password);
        }
        /// <summary>
        ///		PRE: pa tiene que estar inicializado
        ///		POST:se crea un nuevo Personal_adquisiciones usando los datos de pa y se devuelve
        /// </summary>
        public Personal_adquisiciones personalAdquisicionesDatoToPersonalAdquisiciones(Personal_adquisicionesDato pa)
        {
            return new Personal_adquisiciones(pa.Id, pa.Nombre, pa.Apellidos, pa.Usuario, pa.Password);
        }
        #endregion

        #region PRESTAMO
        /// <summary>
		///		PRE: p tiene que estar inicializado
		///		POST:se crea un nuevo Prestamo usando los datos de p y se devuelve
		/// </summary>
        public Prestamo prestamoDatoToPrestamo(PrestamoDato p)
		{
            return new Prestamo(p.CodPrestamo, p.Estado, p.FechaPrestamo, p.FechaDevolucion, p.Prestador, p.EjemplarPrestado, p.Usuario);
        }
        /// <summary>
		///		PRE: p tiene que estar inicializado
		///		POST:se crea un nuevo PrestamoDato usando los datos de p y se devuelve
		/// </summary>
		public PrestamoDato prestamoToPrestamoDato(Prestamo p)
		{
			return new PrestamoDato(p.CodPrestamo,p.Estado, p.FechaRealizacion, p.FechaFin, p.Prestador, p.EjemplarPrestado, p.Usuario);
		}
        #endregion

        #region USUARIO
        /// <summary>
        ///		PRE: u tiene que estar inicializado
        ///		POST:se crea un nuevo Usuario usando los datos de u y se devuelve
        /// </summary>
        public Usuario UsuarioDatoToUsuario(UsuarioDato u)
		{
			return new Usuario(u.Id, u.Nombre, u.Apellidos, u.Dni);
		}
        /// <summary>
        ///		PRE: u tiene que estar inicializado
        ///		POST:se crea un nuevo UsuarioDato usando los datos de u y se devuelve
        /// </summary>
        public UsuarioDato UsuarioToUsuarioDato(Usuario u)
		{
            return new UsuarioDato(u.Id_usuario, u.Nombre, u.Apellidos, u.Dni);
        }
        #endregion
    }
}
