using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LogicaNegocio_Login {
        private persistencia pers;

        /// <summary>
        ///     PRE:
        ///     POST: rellena la base de datos a la que referencia el atributo persistencia
        /// </summary>
        public LogicaNegocio_Login() {
            pers = new persistencia();
            pers.rellenarBD();
        }

        /// <summary>
        ///     PRE: username y password no pueden ser nulos
        ///     POST: devuelve el personal que coincide con username y password, o nulo si no lo ha encontrado en la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Personal_biblioteca login(string username, string password) {
            return pers.getPersonal(username, password);
        }
    }
}
