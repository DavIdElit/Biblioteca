using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario
    {
        private string id_usuario;
        private string nombre;
        private string apellidos;
        private string dni;


        /// <summary>
        /// Constructor con parametros de la clase Usuario
        ///     PRE: id_usuario, nombre, apellidos y dni tienen que estar inicializadas previamente
        ///     POST:Devuelve un objeto Usuario con los parametros que se han pasado
        /// </summary>
        /// <param name="id_usuario"></param>
        /// <param name="apellidos"></param>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        public Usuario(string id_usuario, string nombre, string apellidos, string dni)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
        }

        public string Id_usuario
        {
            get { return id_usuario; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellidos
        {
            get { return apellidos; }
        }

        public string Dni
        {
            get { return dni; }
        }

    }
}
