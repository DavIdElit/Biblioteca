using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class DatosUsuario : UserControl {
		public DatosUsuario() {
			InitializeComponent();
		}

		public Usuario UsuarioActual
		{
			set
			{
				this.tbDni.Text = value.Dni;
				this.tbNombre.Text = value.Nombre;
				this.tbApellidos.Text=value.Apellidos;
			}
		}

		public string Prestados
		{
			set
			{
				this.tbPrestados.Text = value;
			}
		}

		public string Plazo
		{
			set
			{
				this.tbPlazo.Text = value;
			}
		}
	}
}
