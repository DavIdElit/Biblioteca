using System;
using System.Collections;
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

namespace CapaPresentacion
{
    public partial class FPrestamo : Form
    {


        //Atributos
        private string accion;
        private LogicaNegocio_PersonalSala lnSala;
        private List<Ejemplar> ejemplares;

        /// <summary>
		///   PRE: accion, cod_prestamo y lnPersonal tienen que estar inicializadas previamente
		///   POST: inicia los datos del formulario y segun la accion que sea, realiza los cambios necesarios
		/// </summary>
		/// <param name="accion"></param>
		/// <param name="cod_prestamo"></param>
        /// <param name="lnPersonal"></param>
        public FPrestamo(string accion, string cod_prestamo, LogicaNegocio_PersonalBiblioteca lnPersonal)
        {
            this.accion = accion;
            this.lnSala = lnPersonal as LogicaNegocio_PersonalSala;
            InitializeComponent();
            this.tbCodPrestamo.Text = cod_prestamo;
            this.ejemplares = new List<Ejemplar>();

            



            //Dependiendo de la accion que se quiera realizar cambiamos las propiedades de los componentes del formulario
            if (this.accion.Equals("alta"))
            {
                this.Text = "Añadir prestamo";
                this.btOk.Text = "Añadir prestamo";
                this.btCancel.Text = "Cancelar";

                foreach (Libro l in lnSala.getLibros())
                {
                    foreach (Ejemplar e in lnSala.getEjemplaresDisponibles(l))
                    {
                        this.clLibros.Items.Add("ID: " + l.CodigoLibro + " " + l.NombreLibro + "           Ejemplar: " + e.CodigoEjemplar);
                    }

                }

                foreach (Usuario u in lnPersonal.getUsuarios())
                {
                    this.cbUsuario.Items.Add(u);
                    this.cbUsuario.DisplayMember = "id_usuario";
                }
            }
            else if (this.accion.Equals("ver"))
            {
                this.Text = "Ver prestamo";
                this.tbCodPrestamo.ReadOnly = true;  
                this.dtFechaRealizacion.Enabled = false;
                this.dtFechaDevolucion.Enabled = false;
                this.btOk.Visible = false;
                this.tbPrestador.Visible = true;
                this.tbEstado.Visible = true;
                this.lbPrestador.Visible = true;
                this.lbEstado.Visible = true;
                Prestamo p = lnSala.getPrestamoFromCod(cod_prestamo);
                foreach (Ejemplar e in p.EjemplarPrestado)
                {
                    this.clLibros.Items.Add("ID: " + e.CodigoLibro + " " + lnSala.getLibroFromISBN(e.CodigoLibro).NombreLibro + " Ejemplar: " + e.CodigoEjemplar);
                }
                for (int i = 0; i < this.clLibros.Items.Count; i++)
                {
                    this.clLibros.SetItemChecked(i, true);
                }
                this.clLibros.Enabled = false;
                this.cbUsuario.Items.Add(p.Usuario.Id_usuario);
                this.cbUsuario.SelectedIndex = 0;
                this.cbUsuario.Enabled = false;
                this.tbEstado.ReadOnly = true;
                this.tbPrestador.ReadOnly = true;
                this.tbPrestador.Text = lnPersonal.PersonalBiblioteca.Nombre;
                this.btCancel.Text = "Salir";
            }else if (this.accion.Equals("baja"))
            {
                this.Text = "Baja prestamo";
                this.tbCodPrestamo.ReadOnly = true;
                this.dtFechaRealizacion.Enabled = false;
                this.dtFechaDevolucion.Enabled = false;
                this.tbPrestador.Visible = true;
                this.tbEstado.Visible = true;
                this.lbPrestador.Visible = true;
                this.lbEstado.Visible = true;
                Prestamo p = lnSala.getPrestamoFromCod(cod_prestamo);
                foreach (Ejemplar e in p.EjemplarPrestado)
                {
                    this.clLibros.Items.Add("ID: " + e.CodigoLibro + " " + lnSala.getLibroFromISBN(e.CodigoLibro).NombreLibro + " Ejemplar: " + e.CodigoEjemplar);
                }
                for(int i = 0; i < this.clLibros.Items.Count; i++)
                {
                    this.clLibros.SetItemChecked(i, true);
                }
                this.clLibros.Enabled = false;
                this.cbUsuario.Items.Add(p.Usuario.Id_usuario);
                this.cbUsuario.SelectedIndex = 0;
                this.cbUsuario.Enabled = false;
                this.tbEstado.ReadOnly = true;
                this.tbPrestador.ReadOnly = true;
                this.tbPrestador.Text = lnPersonal.PersonalBiblioteca.Nombre;
                this.btCancel.Text = "Cancelar";
                this.btOk.Text = "Borrar";
            }
        }

        /// <summary>
		///	  PRE: 
		///	  POST: añade el cod_prestamo a su respectiva casilla
		/// </summary>
		/// <param name="codPrestamo"></param>
        public void set_CodPrestamo(string codPrestamo)
        {
            this.tbCodPrestamo.Text = codPrestamo;
        }
        /// <summary>
		///	  PRE: 
		///	  POST: añade el estado en el que se encuentra el prestamo a su respectiva casilla
		/// </summary>
		/// <param name="estado"></param>
        public void set_Estado(string estado)
        {
            this.tbEstado.Text = estado;
        }
        /// <summary>
		///	  PRE: 
		///	  POST: añade la fecha en la que se ha realizado el prestamo a su respectiva casilla
		/// </summary>
		/// <param name="fechaRealizacion"></param>
        public void set_FechaRealizacion(DateTime fechaRealizacion)
        {
            this.dtFechaRealizacion.Value = fechaRealizacion;
        }
        /// <summary>
		///	  PRE: 
		///	  POST: añade la fecha en la que se ha devuelto el prestamo a su respectiva casilla
		/// </summary>
		/// <param name="fechaDevolucion"></param>
        public void set_FechaDevolucion(DateTime fechaDevolucion)
        {
            this.dtFechaDevolucion.Value = fechaDevolucion;
        }

        /// <summary>
		/// Devuelve el contenido introducido en los TextBox en forma de Prestamo
		///		PRE: 
		///		POST:Devuelve un objeto Prestamo inicializado con los valores Text de los
		///			TextBox
		/// </summary>
        public Prestamo getPrestamo()
        {
            for (int i = 0; i < this.clLibros.CheckedItems.Count; i++)
            {
                string[] x = this.clLibros.CheckedItems[i].ToString().Split(' ');
                Ejemplar e = new Ejemplar(x[1], x[x.Length-1]);
                this.ejemplares.Add(e);

            }
                return (new Prestamo(this.tbCodPrestamo.Text, "En prestamo", this.dtFechaRealizacion.Value, this.dtFechaDevolucion.Value,lnSala.PersonalBiblioteca as Personal_de_sala, this.ejemplares,this.cbUsuario.SelectedItem as Usuario));
        }
        /// <summary>
		/// El boton de OK para las operaciones de alta y baja sirve para indicar que la accion
		///		se quiere realizar
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:devuelve un DialogResult.OK
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        /// <summary>
		/// El boton de cancelar se usa para cancelar las operaciones de alta y baja, y como boton
		///		de salir para la operacion de ver
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:devuelve un DialogResult.Cancel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
