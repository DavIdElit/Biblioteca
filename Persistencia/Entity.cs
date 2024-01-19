using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia {
	public class Entity<T> : IEquatable<Entity<T>> {
		private T id;

		public T Id {
			get {
				return this.id;
			}
		}

		public Entity(T id) {
			this.id = id;
		}

		public bool Equals(Entity<T> other) {
			if(other == null) {
				return this == null;
			} else {
				return this.id.Equals(other.id);
			}
		}

		public override string ToString() {
			return "" + this.id.ToString();
		}
	}
}