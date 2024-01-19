using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	internal class BD {
		private static Tabla<string, LibroDato> tLibro;
		private static Tabla<ClaveEjemplar, EjemplarDato> tEjemplar;
		private static Tabla<string,UsuarioDato> tUsuario;
		private static Tabla<int, Personal_bibliotecaDato> tPersonal;
        private static Tabla<string, PrestamoDato> tPrestamo;
        private static Tabla<ClaveEjemplarPrestamo, EjemplarPrestamoDato> tEjemplarPrestamo;

        /// <summary>
        ///     PRE: 
        ///     POST:Se crea un objeto BD
        /// </summary>
        
        private BD() {
            
        }

        #region TABLA LIBRO
        /// <summary>
        /// PRE:
        /// POST:Si la tabla no estaba inicializada previamente crea una nueva y la devuelve,
        ///     y si estaba ya inicializada entonces la devuelve
        /// </summary>
        public static Tabla<string, LibroDato> TLibro {
			get {
				if (tLibro == null) {
                    tLibro = new Tabla<string, LibroDato>();
                }
                return tLibro;
            }
		}
        
        /// <summary>
        ///     PRE: LibroDato tiene que estar inicializado previamente
        ///     POST:Se inserta el LibroDato en TLibro, si este no estaba ya insertado previamente
        ///         Devuelve true o false dependiendo de si se puede insertar o no
        /// </summary>
		public static bool INSERT (LibroDato l) {
			if (TLibro.Contains(l.Id)) {
				return false;
			} else {
				TLibro.Add(l);
				return true;
			}
		}
        /// <summary>
        ///     PRE: LibroDato tiene que estar inicializado previamente
        ///     POST:Si la tabla TLibro contiene el LibroDato pasado por parametro se devuelve, 
        ///         y sino, se devuelve null
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
		public static LibroDato READ (LibroDato l) {
			if (TLibro.Contains(l.Id)) {
				foreach (LibroDato ld in TLibro) {
					if (ld.Equals(l)) {
						return ld;
					}
				}
			}
			return null;
		}
        /// <summary>
        ///     PRE: LibroDato tiene que estar inicializado previamente
        ///     POST:Si TLibro contiene el LibroDato pasado por parametro, este se borra y se inserta con los nuevos datos
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
		public static bool UPDATE(LibroDato l) {
			if (TLibro.Contains(l.Id)) {
				DELETE(l);
				INSERT(l);
				return true;
			} else {
				return false;
			}
		}
        /// <summary>
        ///     PRE: LibroDato tiene que estar inicializado previamente
        ///     POST:Si TLibro contiene el LibroDato pasado por parametro, este se borra
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
		public static bool DELETE (LibroDato l) {
			if (TLibro.Contains(l.Id)) {
				TLibro.Remove(l.Id);
				return true;
			} else {
				return false;
			}
		}
        #endregion

        #region TABLA EJEMPLAR

        /// PRE:
        /// POST:Si la tabla no estaba inicializada previamente crea una nueva y la devuelve,
        ///     y si estaba ya inicializada entonces la devuelve
        public static Tabla<ClaveEjemplar,EjemplarDato> TEjemplar {
			get {
				if (tEjemplar == null) {
                    tEjemplar = new Tabla<ClaveEjemplar, EjemplarDato>();
				}
				return tEjemplar;
			}
		}
        /// <summary>
        ///     PRE: EjemplarDato tiene que estar inicializado previamente
        ///     POST:Si EjemplarDato no esta en TEjemplar se añade, 
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
		public static bool INSERT (EjemplarDato e) {
			if (TEjemplar.Any(ej => ej.Id.Equals(e.Id))) {
				return false;
			} else {
				TEjemplar.Add(e);
				return true;
			}
        }
        /// <summary>
        ///     PRE: EjemplarDato tiene que estar inicializado previamente
        ///     POST:Si EjemplarDato esta en TEjemplar, se devuelve. En caso contrario se devuelve null
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
		public static EjemplarDato READ(EjemplarDato e) {
			if (TEjemplar.Any(ej => ej.Id.Equals(e.Id))) {
				foreach(EjemplarDato ed in TEjemplar) {
					if (ed.Id.Equals(e.Id)) {
						return ed;
					}
				}
			}
			return null;
		}

        /// <summary>
        ///     PRE: EjemplarDato tiene que estar inicializada previamente
        ///     POST:Si EjemplarDato esta en TEjemplar entonces se borra y se vuelve a insertar,
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
		public static bool UPDATE(EjemplarDato e) {
			if (TEjemplar.Any(ej => ej.Id.Equals(e.Id))) {
				DELETE(e);
				INSERT(e);
				return true;
			}
			return false;
		}

        /// <summary>
        ///     PRE: EjemplarDato tiene que estar inicializada previamente
        ///     POST:Si EjemplarDato esta en TEjemplar entonces se borra,
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
		public static bool DELETE(EjemplarDato e) {
			if (TEjemplar.Any(ej => ej.Id.Equals(e.Id))) {
                EjemplarDato ed = READ(e);
                TEjemplar.Remove(ed);
                return true;
            } else {
                return false;
            }
		}
        #endregion

        #region TABLA USUARIO

        /// <summary>
        /// PRE:
        /// POST:Si la tabla no estaba inicializada previamente crea una nueva y la devuelve,
        ///     y si estaba ya inicializada entonces la devuelve
        /// </summary>
		public static Tabla<string, UsuarioDato> TUsuario
		{
            get {
                if (tUsuario == null) {
                    tUsuario = new Tabla<string, UsuarioDato>();
                }
                return tUsuario;
            }
        }

        /// <summary>
        ///     PRE: UsuarioDato tiene que estar inicializado previamente
        ///     POST:Se inserta el UsuarioDato en TUsuario, si este no estaba ya insertado previamente
        ///         Devuelve true o false dependiendo de si se puede insertar o no
        /// </summary>
        public static bool INSERT(UsuarioDato u)
		{
            if (TUsuario.Contains(u))
            {
                return false;
            }
            else
            {
                TUsuario.Add(u);
                return true;
            }
        }
        /// <summary>
        ///     PRE: UsuarioDato tiene que estar inicializado previamente
        ///     POST:Si la tabla TUsuario contiene el UsuarioDato pasado por parametro se devuelve, 
        ///         y sino, se devuelve null
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static UsuarioDato READ(UsuarioDato u)
		{
            if (TUsuario.Contains(u))
            {
                foreach (UsuarioDato ud in TUsuario)
                {
                    if (ud.Equals(u))
                    {
                        return ud;
                    }
                }
            }
            return null;
        }
        /// <summary>
        ///     PRE: UsuarioDato tiene que estar inicializado previamente
        ///     POST:Si TUsuario contiene el UsuarioDato pasado por parametro, este se borra y se inserta con los nuevos datos
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool UPDATE(UsuarioDato u)
		{
            if (TUsuario.Contains(u))
            {
                DELETE(u);
                INSERT(u);
                return true;
            }
            return false;
        }
        /// <summary>
        ///     PRE: UsuarioDato tiene que estar inicializado previamente
        ///     POST:Si TUsuario contiene el UsuarioDato pasado por parametro, este se borra
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool DELETE(UsuarioDato u)
		{
            if (TUsuario.Contains(u))
            {
                TUsuario.Remove(u);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region TABLA PERSONAL
        /// <summary>
        /// PRE:
        /// POST:Si la tabla no estaba inicializada previamente crea una nueva y la devuelve,
        ///     y si estaba ya inicializada entonces la devuelve
        /// </summary>
        public static Tabla<int, Personal_bibliotecaDato> TPersonal
        {
            get
            {
				if (tPersonal == null) {
                    tPersonal = new Tabla<int, Personal_bibliotecaDato>();

                }
                return tPersonal;
            }
        }
        /// <summary>
        ///     PRE: Personal_bibliotecaDato tiene que estar inicializado previamente
        ///     POST:Se inserta el Personal_bibliotecaDato en TPersonal, si este no estaba ya insertado previamente
        ///         Devuelve true o false dependiendo de si se puede insertar o no
        /// </summary>
        public static bool INSERT(Personal_bibliotecaDato p)
        {
            if (TPersonal.Contains(p))  {
                return false;
            }
            else
            {
                TPersonal.Add(p);
                return true;
            }
        }
        /// <summary>
        ///     PRE: Personal_bibliotecaDato tiene que estar inicializado previamente
        ///     POST:Si la tabla TPersonal contiene el Personal_bibliotecaDato pasado por parametro se devuelve, 
        ///         y sino, se devuelve null
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Personal_bibliotecaDato READ(Personal_bibliotecaDato p)
        {
            if (TPersonal.Contains(p))
            {
                foreach (Personal_bibliotecaDato pd in TPersonal)
                {
                    if (pd.Equals(p) || (pd.Usuario.Equals(p.Usuario) && pd.Password.Equals(p.Password)))
                    {
                        return pd;
                    }
                }
            }
            return null;
        }
        /// <summary>
        ///     PRE: Personal_bibliotecaDato tiene que estar inicializado previamente
        ///     POST:Si TPersonal contiene el Personal_bibliotecaDato pasado por parametro, este se borra y se inserta con los nuevos datos
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool UPDATE(Personal_bibliotecaDato p)
        {
            if (TPersonal.Contains(p))
            {
                DELETE(p);
                INSERT(p);
                return true;
            }
            return false;
        }
        /// <summary>
        ///     PRE: Personal_bibliotecaDato tiene que estar inicializado previamente
        ///     POST:Si TPersonal contiene el Personal_bibliotecaDato pasado por parametro, este se borra
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool DELETE(Personal_bibliotecaDato p)
        {
            if (TPersonal.Contains(p))
            {
                TPersonal.Remove(p);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TABLA PRESTAMO

        /// <summary>
        /// PRE:
        /// POST:Si la tabla no estaba inicializada previamente crea una nueva y la devuelve,
        ///     y si estaba ya inicializada entonces la devuelve
        /// </summary>
        public static Tabla<string, PrestamoDato> TPrestamo
        {
            get
            {
				if (tPrestamo == null) {
                    tPrestamo = new Tabla<string, PrestamoDato>();
				}
                return tPrestamo;
            }
        }
        /// <summary>
        ///     PRE: PrestamoDato tiene que estar inicializado previamente
        ///     POST:Se inserta el PrestamoDato en TPrestamo, si este no estaba ya insertado previamente
        ///         Devuelve true o false dependiendo de si se puede insertar o no
        /// </summary>
        /// /// <param name="u"></param>
        /// /// <returns></returns>
        public static bool INSERT(PrestamoDato u)
        {
            if (TPrestamo.Contains(u))
            {
                return false;
            }
            else
            {
                TPrestamo.Add(u);
                return true;
            }
        }
        /// <summary>
        ///     PRE: PrestamoDato tiene que estar inicializado previamente
        ///     POST:Si la tabla TPrestamo contiene el PrestamoDato pasado por parametro se devuelve, 
        ///         y sino, se devuelve null
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static PrestamoDato READ(PrestamoDato u)
        {
            if (TPrestamo.Contains(u))
            {
                foreach (PrestamoDato ud in TPrestamo)
                {
                    if (ud.Equals(u))
                    {
                        return ud;
                    }
                }
            }
            return null;
        }
        /// <summary>
        ///     PRE: PrestamoDato tiene que estar inicializado previamente
        ///     POST:Si TPrestamo contiene el PrestamoDato pasado por parametro, este se borra y se inserta con los nuevos datos
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool UPDATE(PrestamoDato u)
        {
            if (TPrestamo.Contains(u))
            {
                DELETE(u);
                INSERT(u);
                return true;
            }
            return false;
        }
        /// <summary>
        ///     PRE: PrestamoDato tiene que estar inicializado previamente
        ///     POST:Si TPrestamo contiene el PrestamoDato pasado por parametro, este se borra
        ///         devuelve true si se puede hacer la operacion y false en caso contrario
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool DELETE(PrestamoDato u)
        {
            if (TPrestamo.Contains(u))
            {
                TPrestamo.Remove(u);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TABLA EJEMPLAR_PRESTAMO

        public static Tabla<ClaveEjemplarPrestamo, EjemplarPrestamoDato> TEjemplarPrestamo
        {
            get
            {
				if (tEjemplarPrestamo == null) {
                    tEjemplarPrestamo = new Tabla<ClaveEjemplarPrestamo, EjemplarPrestamoDato>();
				}
                return tEjemplarPrestamo;
            }
        }

        public static bool INSERT(EjemplarPrestamoDato e)
        {
            if (TEjemplarPrestamo.Contains(e))
            {
                return false;
            }
            else
            {
                TEjemplarPrestamo.Add(e);
                return true;
            }
        }

        public static EjemplarPrestamoDato READ(EjemplarPrestamoDato e)
        {
            if (TEjemplarPrestamo.Contains(e))
            {
                foreach (EjemplarPrestamoDato ed in TEjemplarPrestamo)
                {
                    if (ed.Equals(e))
                    {
                        return ed;
                    }
                }
            }
            return null;
        }

        public static bool UPDATE(EjemplarPrestamoDato e)
        {
            if (TEjemplarPrestamo.Contains(e))
            {
                DELETE(e);
                INSERT(e);
                return true;
            }
            return false;
        }

        public static bool DELETE(EjemplarPrestamoDato e)
        {
            if (TEjemplarPrestamo.Contains(e))
            {
                TEjemplarPrestamo.Remove(e);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}