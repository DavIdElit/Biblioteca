using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    /// <summary>
	///		Esta clase hereda de la clase base de la logica de 
	///			negocio que es la clase LogicaNegocio_PersonalBiblioteca, y 
	///			añade los metodos propios de lo que tiene que hacer 
	///			el personal de sala.
	/// </summary>
    public class LogicaNegocio_PersonalSala : LogicaNegocio_PersonalBiblioteca
    {
        /// <summary>
		///		Constructor de LogicaNegocio_PersonalSala, inicializa un objeto LogicaNegocio_PersonalSala a partir
		///			de un Personal_de_sala
		///			
		///		PRE: Personal_de_sala tiene que estar previamente inicializado
		///		POST:Se devuelve un objeto LogicaNegocio_PersonalSala inicializado con el Personal_de_sala pasado
		///			y una persistencia nueva
		/// </summary>
		/// <param name="pa"></param>
        public LogicaNegocio_PersonalSala(Personal_de_sala pa)
        {
            base.Persistencia = new persistencia();
            base.PersonalBiblioteca = pa;
        }


        #region OPERACIONES PRESTAMOS
        /// <summary>
		///		PRE: Prestamo tiene que estar inicializado
		///		POST:Se añade el prestamo pasado por parametro a la base de datos
		/// </summary>
		/// <param name="l"></param>
        public void altaPrestamo(Prestamo p)
        {
            Persistencia.altaPrestamo(p);
        }
        /// <summary>
		///		PRE: Prestamo tiene que estar inicializado previamente
		///		POST:Se devuelve el prestamo equivalente en nuestra base de datos
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
        public Prestamo getPrestamo(Prestamo p)
        {
            return Persistencia.getPrestamo(p);
        }
        /// <summary>
		///		PRE: cod_prestamo tiene que estar inicializado previamente
		///		POST:se devuelve el prestamo de nuestra base de datos que tiene ese cod_prestamo
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns></returns>
        public Prestamo getPrestamoFromCod(string cod_prestamo)
        {
            return Persistencia.getPrestamoFromCod(cod_prestamo);
        }
        /// <summary>
		///		PRE: Prestamo tiene que estar inicializado
		///		POST:Se da de baja en la base de datos el prestamo que ha pasado por parametro
		/// </summary>
		/// <param name="l"></param>
        public void bajaPrestamo(Prestamo p)
        {
            Persistencia.bajaPrestamo(p);
        }
        /// <summary>
		///		PRE: id_usuario tiene que estar inicializado previamente
		///		POST:se devuelve el listado de prestamos que ha realizado el usuario con id_usuario
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns></returns>
        public List<Prestamo> getPrestamosFromUsuario(string id_usuario)
        {
            return Persistencia.getPrestamosFromUsuario(id_usuario);
        }

        #endregion
    }
}
