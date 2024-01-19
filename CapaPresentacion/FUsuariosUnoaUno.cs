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
	public partial class FUsuariosUnoaUno : Form {

        private LogicaNegocio_PersonalBiblioteca lnPers;

        /// <summary>
        ///   PRE: lnPersonal tiene que estar inicializado
        ///   POST: inicia los datos del formulario
        /// </summary>
        /// <param name="lnPersonal"></param>
        public FUsuariosUnoaUno(LogicaNegocio_PersonalBiblioteca lnPersonal) {
			InitializeComponent();
            lnPers = lnPersonal;
            BindingSource bs = new BindingSource();
			bs.DataSource = lnPersonal.getUsuarios();
			bindingNavigator1.BindingSource = bs;
            int i = 0;
            int.TryParse(bindingNavigator1.PositionItem.Text, out i);
            if (i != 0)
            {
                Usuario u = bs[i - 1] as Usuario;
                if (u != null)
                {
                    datosUsuario1.UsuarioActual = u;
                    LogicaNegocio_PersonalSala lnSala = lnPersonal as LogicaNegocio_PersonalSala;
                    if (lnSala != null)
                    {
                        List<Prestamo> list = lnSala.getPrestamosFromUsuario(u.Id_usuario);
                        int j = 0;
                        int k = 0;
                        foreach (Prestamo prestamo in list)
                        {
                            j=j+prestamo.EjemplarPrestado.Count();
                            if(prestamo.FechaFin < DateTime.UtcNow.Date)
                            {
                                k++;
                            }
                        }
                        datosUsuario1.Prestados = j.ToString();
                        datosUsuario1.Plazo = k.ToString();
                    }
                    else
                    {
                        datosUsuario1.Prestados = "Desconocido";
                    }
                    
                }
            }


        }
        /// <summary>
        ///   PRE:
        ///   POST: muestra los datos del usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(bindingNavigator1.PositionItem.Text, out i);
            if (i != 0)
            {
                Usuario u = bindingNavigator1.BindingSource[i - 1] as Usuario;
                if (u != null)
                {
                    datosUsuario1.UsuarioActual = u;
                    LogicaNegocio_PersonalSala lnSala = lnPers as LogicaNegocio_PersonalSala;
                    if (lnSala != null)
                    {
                        List<Prestamo> list = lnSala.getPrestamosFromUsuario(u.Id_usuario);
                        int j = 0;
                        int k = 0;
                        foreach (Prestamo prestamo in list)
                        {
                            j = j + prestamo.EjemplarPrestado.Count();
                            if (prestamo.FechaFin < DateTime.UtcNow.Date)
                            {
                                k++;
                            }
                        }
                        datosUsuario1.Prestados = j.ToString();
                        datosUsuario1.Plazo = k.ToString();
                    }
                    else
                    {
                        datosUsuario1.Prestados = "Desconocido";
                    }

                }
            }
        }
        /// <summary>
        ///   PRE:
        ///   POST: muestra los datos del usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(bindingNavigator1.PositionItem.Text, out i);
            if (i != 0)
            {
                Usuario u = bindingNavigator1.BindingSource[i - 1] as Usuario;
                if (u != null)
                {
                    datosUsuario1.UsuarioActual = u;
                    LogicaNegocio_PersonalSala lnSala = lnPers as LogicaNegocio_PersonalSala;
                    if (lnSala != null)
                    {
                        List<Prestamo> list = lnSala.getPrestamosFromUsuario(u.Id_usuario);
                        int j = 0;
                        int k = 0;
                        foreach (Prestamo prestamo in list)
                        {
                            j = j + prestamo.EjemplarPrestado.Count();
                            if (prestamo.FechaFin < DateTime.UtcNow.Date)
                            {
                                k++;
                            }
                        }
                        datosUsuario1.Prestados = j.ToString();
                        datosUsuario1.Plazo = k.ToString();
                    }
                    else
                    {
                        datosUsuario1.Prestados = "Desconocido";
                    }

                }
            }
        }
        /// <summary>
        ///   PRE:
        ///   POST: muestra los datos del usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(bindingNavigator1.PositionItem.Text, out i);
            if (i != 0)
            {
                Usuario u = bindingNavigator1.BindingSource[i - 1] as Usuario;
                if (u != null)
                {
                    datosUsuario1.UsuarioActual = u;
                    LogicaNegocio_PersonalSala lnSala = lnPers as LogicaNegocio_PersonalSala;
                    if (lnSala != null)
                    {
                        List<Prestamo> list = lnSala.getPrestamosFromUsuario(u.Id_usuario);
                        int j = 0;
                        int k = 0;
                        foreach (Prestamo prestamo in list)
                        {
                            j = j + prestamo.EjemplarPrestado.Count();
                            if (prestamo.FechaFin < DateTime.UtcNow.Date)
                            {
                                k++;
                            }
                        }
                        datosUsuario1.Prestados = j.ToString();
                        datosUsuario1.Plazo = k.ToString();
                    }
                    else
                    {
                        datosUsuario1.Prestados = "Desconocido";
                    }

                }
            }
        }
        /// <summary>
        ///   PRE:
        ///   POST: muestra los datos del usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(bindingNavigator1.PositionItem.Text, out i);
            if (i != 0)
            {
                Usuario u = bindingNavigator1.BindingSource[i - 1] as Usuario;
                if (u != null)
                {
                    datosUsuario1.UsuarioActual = u;
                    LogicaNegocio_PersonalSala lnSala = lnPers as LogicaNegocio_PersonalSala;
                    if (lnSala != null)
                    {
                        List<Prestamo> list = lnSala.getPrestamosFromUsuario(u.Id_usuario);
                        int j = 0;
                        int k = 0;
                        foreach (Prestamo prestamo in list)
                        {
                            j = j + prestamo.EjemplarPrestado.Count();
                            if (prestamo.FechaFin < DateTime.UtcNow.Date)
                            {
                                k++;
                            }
                        }
                        datosUsuario1.Prestados = j.ToString();
                        datosUsuario1.Plazo = k.ToString();
                    }
                    else
                    {
                        datosUsuario1.Prestados = "Desconocido";
                    }

                }
            }
        }
    }
}
