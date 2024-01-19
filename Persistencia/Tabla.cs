using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
	public class Tabla<T, U> : KeyedCollection<T, U> where U : Entity<T> {
		/// <summary>
		///		PRE: item tiene que estar inicializado previamente
		///		POST:Devuelve el id asociado al item pasado por parametro
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		protected override T GetKeyForItem(U item) {
			return item.Id;
		}
	}
}