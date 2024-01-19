using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Personal_biblioteca : IEquatable<Personal_biblioteca> {

        //Atributos
        private int num_Id;
        private string nombre;
        private string apellidos;
        private string nomUsuario;
        private string password;

        //Definicion de propiedades
        public int Num_Id
        {
            get { return this.num_Id; }
        }
        
        public string Nombre
        {
            get { return this.nombre; }
        }
        
        public string Apellidos
        {
            get { return this.apellidos; }
        }
        
        public string NomUsuario
        {
            get { return this.nomUsuario; }
        }
        public string Password
        {
             get { return this.password; }
        }



        /// <summary>
        ///     PRE: Todos los parametros tienen que estar inicializados
        ///     POST:Se crea un objeto Personal_biblioteca con los parametros
        /// </summary>
        /// <param name="num_id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        public Personal_biblioteca(int num_id, string nombre, string apellidos, string usuario, string password) {
            this.num_Id = num_id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nomUsuario = usuario;
            this.password = password;
        }

        /// <summary>
        ///     PRE: Personal_biblioteca tiene que estar inicializado previamente
        ///     POST:Devuelve true si el objeto actual tiene todos los atributos iguales al objeto pasado por parametro
        /// </summary>
		bool IEquatable<Personal_biblioteca>.Equals(Personal_biblioteca other) {
            return ((Num_Id.Equals(other.Num_Id)) &&(Nombre.Equals(other.Nombre)) &&(Apellidos.Equals(other.Apellidos)) &&(NomUsuario.Equals(other.NomUsuario)) &&(Password.Equals(other.Password)));
		}
	}
}
