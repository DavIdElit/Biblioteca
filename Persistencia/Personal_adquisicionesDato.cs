using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
    internal class Personal_adquisicionesDato:Personal_bibliotecaDato {
        /// <summary>
        ///     PRE: num_id, nombre, apellidos, usuario, password tienen que estar inicializados previamente
        ///     POST:Se crea un nuevo objeto Personal_adquisicionesDato con los datos pasados por parametro
        /// </summary>
        public Personal_adquisicionesDato(int num_id, string nombre, string apellidos, string usuario, string password) : base(num_id, nombre, apellidos, usuario, password) {
        }
    }
}