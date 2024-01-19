using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class Personal_bibliotecaDato: Entity<int>
    {
        private string nombre;
        private string apellidos;
        private string usuario;
        private string password;

        /// <summary>
        ///     PRE: num_id, nombre, apellidos, usuario, password tienen que estar inicializados previamente
        ///     POST:Se crea un nuevo objeto Personal_bibliotecaDato con los datos pasados por parametro
        /// </summary>
        public Personal_bibliotecaDato(int num_id, string nombre, string apellidos, string usuario, string password):base(num_id) {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.password = password;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }


        /// <summary>
		///		PRE: 
		///		POST:Devuelve el contenido de este Personal_bibliotecaDato de forma legible en un string
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return "Nombre: "+this.nombre+" Apellidos: "+this.apellidos+" Usuario: "+this.usuario+ "Password: "+this.password;
        }

        /// <summary>
		///		PRE: 
		///		POST:Devuelve true si obj es de tipo Personal_bibliotecaDato y además tiene el mismo id o el mismo nombre y la misma constraseña que el objeto sobre el que se llama la función
		/// </summary>
		/// 
        public override bool Equals(object obj)
        {
            Personal_bibliotecaDato d=obj as Personal_bibliotecaDato;
            return (this.Id.Equals(d.Id) || (this.usuario.Equals(d.usuario) && this.password.Equals(d.password)));
        }
    }
}
