using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using ModeloDominio;

namespace CapaPresentacion {
	public partial class FListadoUsuarios : Form {

        private List<Usuario> usuarios;

        /// <summary>
        ///     PRE: lnPersonal tiene que estar inicializado
        ///     POST: crea el formulario añadiendole los datos necesarios apra mostrar todos los usuarios de la base de datos
        /// </summary>
        /// <param name="lnPersonal"></param>
        public FListadoUsuarios(LogicaNegocio_PersonalBiblioteca lnPersonal) {
            InitializeComponent();
            this.usuarios = lnPersonal.getUsuarios();
			BindingSource bs1=new BindingSource();
			bs1.DataSource = usuarios;
			lbId.DataSource = bs1;
            lbId.DisplayMember = "id_usuario";
            lbNombre.DataSource = bs1;
            lbNombre.DisplayMember = "nombre";
            lbApellidos.DataSource = bs1;
            lbApellidos.DisplayMember = "apellidos";
            lbDni.DataSource = bs1;
            lbDni.DisplayMember = "dni";
        }
        /// <summary>
        ///     PRE:
        ///     POST: ordena alfabéticamente los usuarios mostrados por su campo Id_usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bId_Click(object sender, EventArgs e)
		{
			usuarios.Sort((x,y)=>x.Id_usuario.CompareTo(y.Id_usuario));
            BindingSource bs = lbId.DataSource as BindingSource;
            bs.ResetBindings(false);
        }
        /// <summary>
        ///     PRE:
        ///     POST: ordena alfabéticamente los usuarios mostrados por su campo Dni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void bOrdenarDNI_Click(object sender, EventArgs e)
		{
            usuarios.Sort((x, y) => x.Dni.CompareTo(y.Dni));
            BindingSource bs = lbId.DataSource as BindingSource;
            bs.ResetBindings(false);
        }
        /// <summary>
        ///     PRE:
        ///     POST: ordena alfabéticamente los usuarios mostrados por su campo Nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void bOrdenarNombre_Click(object sender, EventArgs e)
		{
            usuarios.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            BindingSource bs = lbId.DataSource as BindingSource;
            bs.ResetBindings(false);
        }
        /// <summary>
        ///     PRE:
        ///     POST: ordena alfabéticamente los usuarios mostrados por su campo Apellidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void bApellidos_Click(object sender, EventArgs e)
		{
            usuarios.Sort((x, y) => x.Apellidos.CompareTo(y.Apellidos));
            BindingSource bs = lbId.DataSource as BindingSource;
            bs.ResetBindings(false);
        }
	}
}
