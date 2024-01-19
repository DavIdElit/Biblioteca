using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<string>
    {
        //Atributos
        private string estado;
        public DateTime fechaPrestamo;
        public DateTime fechaDevolucion;
        private Personal_de_sala prestador;
        private List<Ejemplar> ejemplarPrestado;
        private Usuario usuario;

        //base(cod_prestamo) indica que en esta clase el equivalente a la clave de Entity es cod_prestamo
        /// <summary>
		///		PRE: cod_prestamo, estado, fechaPrestamo, fechaDevolucion, prestador, ejemplarPrestado  y usuario tienen que estar previamente inicializados
		///		POST:Crea un nuevo objeto PrestamoDato con los parametros pasados
		/// </summary>
		/// <param name="cod_prestamo"></param>
		/// <param name="estado"></param>
		/// <param name="fechaPrestamo"></param>
        /// <param name="fechaDevolucion"></param>
        /// <param name="prestador"></param>
        /// <param name="ejemplarPrestado"></param>
        /// <param name="usuario"></param>
        public PrestamoDato(string cod_prestamo, string estado, DateTime fechaPrestamo, DateTime fechaDevolucion, Personal_de_sala prestador, List<Ejemplar> ejemplarPrestado, Usuario usuario) : base(cod_prestamo)
        {
            this.estado = estado;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.prestador = prestador; 
            this.usuario = usuario;
            this.ejemplarPrestado = ejemplarPrestado;
        }


        //Propiedades
        public string CodPrestamo {
            get {
                return Id;
			}
		}
        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public DateTime FechaPrestamo
        {
            get { return this.fechaPrestamo; }
            set { this.fechaPrestamo = value; }
        }

        public DateTime FechaDevolucion
        {
            get
            {
                return this.fechaDevolucion;
            }
            set
            {
                this.fechaDevolucion = value;
            }
        }
        public Personal_de_sala Prestador
        {
            get
            {
                return this.prestador;
            }
            set
            {
                this.prestador = value;
            }
        }
        public List<Ejemplar> EjemplarPrestado
        {
            get
            {
                return this.ejemplarPrestado;
            }
            set
            {
                this.ejemplarPrestado = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }
        /// <summary>
        /// Sobreescritura del metodo ToString generico para que devuelva de forma legible
        ///     los atributos del objeto desde el q se ha invocado el metodo
        ///     
        ///     PRE: 
        ///     POST:Devuelve el objeto prestamo de forma legible en una string
        /// </summary>
        public override String ToString()
        {
            String prestamo = "Prestamo: ";
            if (this.Estado.Equals("prestado"))
            {
                prestamo = prestamo + "EnPrestamo " + this.FechaPrestamo + this.FechaDevolucion;
            }
            else
            {
                prestamo = prestamo + "Pendiente de prestamo.";
            }
            return prestamo;
        }
        /// <summary>
        ///     PRE: PrestamoDato tiene que estar inicializado previamente
        ///     POST:Devuelve true si el objeto actual tiene el mismo id al objeto pasado por parametro
        /// </summary>
        public override bool Equals(object obj)
        {
            PrestamoDato p=obj as PrestamoDato;
            return this.CodPrestamo.Equals(p.CodPrestamo);
        }
    }
}
