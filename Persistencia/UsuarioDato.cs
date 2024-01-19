using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class UsuarioDato: Entity<string>
    {

        private string nombre;
        private string apellidos;
        private string dni;

        /// <summary>
        /// Constructor con parametros de la clase UsuarioDato
        ///     PRE: id_usuario, nombre, apellidos y dni tienen que estar inicializadas previamente
        ///     POST:Devuelve un objeto UsuarioDato con los parametros que se han pasado
        /// </summary>
        /// <param name="id_usuario"></param>
        /// <param name="apellidos"></param>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        public UsuarioDato(string id_usuario, string nombre, string apellidos, string dni):base(id_usuario)
        {
            this.nombre=nombre;
            this.apellidos=apellidos;
            this.dni=dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
		///		PRE: 
		///		POST:Devuelve el contenido de este UsuarioDato de forma legible en un string
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " Apellidos: " + this.apellidos + " DNI: " + this.dni;
        }

        /// <summary>
        ///     PRE: UsuarioDato tiene que estar inicializado previamente
        ///     POST:Devuelve true si el objeto actual tiene el mismo id al objeto pasado por parametro
        /// </summary>
        public override bool Equals(Object o)
        {
            UsuarioDato u= (UsuarioDato)o;
            return u.Id.Equals(this.Id);
        }
    }
}
