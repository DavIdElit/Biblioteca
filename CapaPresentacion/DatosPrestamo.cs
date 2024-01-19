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
    public partial class DatosPrestamo : UserControl
    {
        //Atributos
        private LogicaNegocio_PersonalSala lnSala;
        /// <summary>
		///		PRE:
		///		POST: Se devuelve un control de usuario DatosPrestamo inicializado
		/// </summary>
        public DatosPrestamo()
        {
            InitializeComponent();
        }
        /// <summary>
		///		PRE: value tiene que estar inicializado
		///		POST:Se asignan los valores de value a los TextBox de DatosPrestamo
		/// </summary>
        public Prestamo PrestamoActual
        {
            set {
                Prestamo p = value;
                this.clLibros.Enabled = false;
                this.tbCodPrestamo.ReadOnly = true;
                this.dtFechaRealizacion.Enabled = false;
                this.dtFechaDevolucion.Enabled = false;
                this.tbPrestador.Visible = true;
                this.tbEstado.Visible = true;
                this.lbPrestador.Visible = true;
                this.lbEstado.Visible = true;
                this.cbUsuario.Enabled = false;
                this.tbEstado.ReadOnly = true;
                this.tbPrestador.ReadOnly = true;
                this.tbCodPrestamo.Text = p.CodPrestamo;
                this.tbEstado.Text = p.Estado;
                this.dtFechaRealizacion.Value = p.FechaRealizacion;
                this.dtFechaDevolucion.Value = p.FechaFin;
                this.cbUsuario.Items.Add(p.Usuario.Id_usuario);
                this.cbUsuario.SelectedIndex = 0;
                this.tbPrestador.Text = p.Prestador.NomUsuario;
                this.clLibros.Items.Clear();
                foreach (Ejemplar e in p.EjemplarPrestado)
                {
                    this.clLibros.Items.Add("ID: " + e.CodigoLibro + " " + lnSala.getLibroFromISBN(e.CodigoLibro).NombreLibro + " Ejemplar: " + e.CodigoEjemplar);
                }
                for (int i = 0; i < this.clLibros.Items.Count; i++)
                {
                    this.clLibros.SetItemChecked(i, true);
                }
            }
        }
        //Propiedad
        public LogicaNegocio_PersonalSala LnSala
        {
            set
            {
                this.lnSala = value;
            }
        }
    }
}
