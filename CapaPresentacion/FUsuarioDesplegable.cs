using LogicaNegocio;
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

namespace CapaPresentacion
{
    public partial class FUsuarioDesplegable : Form
    {
        /// <summary>
        ///   PRE:
        ///   POST: inicia el formulario añadiendo al desplegable los datos de los usuarios de la base de datos
        /// </summary>
        /// <param name="lnPersonal"></param>
        public FUsuarioDesplegable(LogicaNegocio_PersonalBiblioteca lnPersonal)
        {
            InitializeComponent();
            foreach(Usuario u in lnPersonal.getUsuarios()){
                this.cbId.Items.Add(u);
                this.cbId.DisplayMember = "id_usuario";
            }
        }

        /// <summary>
        ///   PRE:
        ///   POST: Asigna los datos del usuario seleccionado a sus respectivas casillas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u= this.cbId.SelectedItem as Usuario;
            this.tbNombre.Text = u.Nombre;
            this.tbApellidos.Text=u.Apellidos;
            this.tbDNI.Text = u.Dni;
        }
        /// <summary>
        ///   PRE:
        ///   POST: cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
