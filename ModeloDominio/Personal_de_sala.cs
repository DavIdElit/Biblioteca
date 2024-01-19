using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{

	public class Personal_de_sala : Personal_biblioteca {
        /// <summary>
        ///		PRE: todos los parametros tienen que estar inicializado
        ///		POST:crea un nuevo objeto Personal_de_sala
        /// </summary>
        /// <param name="num_id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        public Personal_de_sala(int num_id, string nombre, string apellidos, string usuario, string password) : base(num_id, nombre, apellidos, usuario, password) {
		}
	}
}
