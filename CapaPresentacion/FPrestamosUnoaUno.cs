
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
    public partial class FPrestamosUnoaUno : Form
    {
        //Atributos
        private LogicaNegocio_PersonalSala ln_ps;
        /// <summary>
		///		PRE: prestamosBD y ln_ps tienen que estar inicializados previamente
		///		POST:Se crea un FPrestamosUnoaUno y se le asigna a bindingNavigator_Prestamos
		///			prestamosBD para que se puedam ver los datos de los prestamos de manera individual
		/// </summary>
		/// <param name="prestamosBD"></param>
		/// <param name="ln_ps"></param>
        public FPrestamosUnoaUno(List<Prestamo> prestamosBD, LogicaNegocio_PersonalSala ln_ps) {
            this.ln_ps = ln_ps;
            InitializeComponent();
            this.datosPrestamo.LnSala = ln_ps;
            BindingSource bindS = new BindingSource();
            bindS.DataSource = prestamosBD;
            bindingNavigator_Prestamos.BindingSource = bindS;
            int i = 0;
            int.TryParse(bindingNavigator_Prestamos.PositionItem.Text, out i);
            if (i != 0)
            {
                Prestamo p = bindS[i - 1] as Prestamo;
                if (p != null)
                {
                    this.datosPrestamo.PrestamoActual = p;
                }
            }

        }
        /// <summary>
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {
            int i = 0;
            int.TryParse(bindingNavigator_Prestamos.PositionItem.Text, out i);
            if (i != 0) {
                Prestamo p = bindingNavigator_Prestamos.BindingSource[i - 1] as Prestamo;
                if (p != null) {
                    this.datosPrestamo.PrestamoActual = p;
                }
            }
        }
    }
}
