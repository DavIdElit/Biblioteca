using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Libro :IEquatable<Libro> {

        //Atributos
        private string codigoLibro;
        private string nombreLibro;
        private string nombreAutor;


        //Propiedades

        /// <summary>
        ///     PRE:
        ///     POST: Devuelve el codigoLibro de este objeto
        /// </summary>
        public string CodigoLibro {
            get {
                return this.codigoLibro;
			}
		}

        /// <summary>
        ///     GET
        ///     PRE:
        ///     POST: Devuelve el nombreLibro de este objeto
        ///     
        ///     SET
        ///     PRE: value tiene que estar incialiado
        ///     POST:Asigna a nombreLibro el valor de value
        /// </summary>
        public string NombreLibro {
			get {
                return this.nombreLibro;
			}
			set {
                this.nombreLibro= value;
			}
		}


        /// <summary>
        ///     GET
        ///     PRE:
        ///     POST: Devuelve el nombreAutor de este objeto
        ///     
        ///     SET
        ///     PRE: value tiene que estar incialiado
        ///     POST:Asigna a nombreAutor el valor de value
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
        /// Constructor con parametros de la clase Libro
        ///     PRE: cod, nomLibro y nomAut tienen que estar inicializadas previamente
        ///     POST:Devuelve un objeto Libro con los parametros que se han pasado
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomLibro"></param>
        /// <param name="nomAut"></param>
        public Libro(string cod, string nomLibro, string nomAut) {
            this.codigoLibro = cod;
            this.nombreLibro = nomLibro;
            this.nombreAutor = nomAut;
		}
        

        /// <summary>
        /// Sobreescritura del metodo ToString generico para que devuelva de forma legible
        ///     los atributos del objeto desde el q se ha invocado el metodo
        ///     
        ///     PRE: 
        ///     POST:Devuelve el objeto actual de forma legible en una string
        /// </summary>
		public override string ToString() {
			return "Codigo del Libro: " + codigoLibro
                +"\r\nNombre del Libro: " + nombreLibro
                +"\r\nNombre del Autor: " + nombreAutor;
		}
        /// <summary>
        ///     Sobreescritura del metodo Equals generico para comprobar si dos objeto Libro son iguales
        ///     
        ///     PRE: Libro tiene que estar inicializada previamente
        ///     POST:Devuelve un String con los atributos del objeto mas una linea de texto que indican lo que son
        /// </summary>
        /// <param name="l"></param>
		public bool Equals(Libro l) {
			return (this.codigoLibro == l.CodigoLibro)&&(this.nombreLibro == l.NombreLibro) && (this.nombreAutor == l.NombreAutor);
		}
	}
}
