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

namespace CapaPresentacion {
	public partial class FListadoPrestamos : Form {

        //Atributos
        private List<Prestamo> prestamos;
        LogicaNegocio_PersonalSala lnSala;


        /// <summary>
		///		PRE:prestamos y lnSala tienen que estar inicializados previamente
		///		POST:Se crea un FListadoPrestamos y se le asigna a data_Prestamos todos
		///			los Prestamos que contiene prestamos
		/// </summary>
		/// <param name="prestamos"></param>
        /// /// <param name="lnSala"></param>
        public FListadoPrestamos(List<Prestamo> prestamos, LogicaNegocio_PersonalSala lnSala) {
            this.lnSala = lnSala;
            this.prestamos = prestamos;
			InitializeComponent(); 
            addPrestamo(prestamos);
        }
        public void addPrestamo(List<Prestamo> lP)
        {
            foreach (Prestamo p in lP)
            {
                string ejemplares = "";
                foreach (Ejemplar e in p.EjemplarPrestado)
                {
                    ejemplares = ejemplares + lnSala.getLibroFromISBN(e.CodigoLibro).NombreLibro + "(" + e.CodigoEjemplar + ")" + "\r\n";
                }
                string[] fila = { p.CodPrestamo, p.Usuario.Dni, p.FechaRealizacion.ToString(), ejemplares, p.Estado.ToString() };
                this.data_Prestamos.Rows.Add(fila);
            }
        }
    }
}
