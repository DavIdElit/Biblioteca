using System;
using LogicaNegocio;
using ModeloDominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
	/// <summary>
	///		Este formulario es que se muestra al personal una vez que se ha autenticado
	/// </summary>
	public partial class FPrincipal : Form {
		protected LogicaNegocio_PersonalBiblioteca lnPersonal;
		/// <summary>
		///		PRE: Constructor principal del formulario, se necesita que LogicaNegocio_PersonalBiblioteca este inicializado previamente
		///		POST:Devuelve un FPrincipal inicializado y con el atributo lnPersonal asignado al parametro que se le pasa
		/// </summary>
		/// <param name="lnP"></param>
		public FPrincipal(LogicaNegocio_PersonalBiblioteca lnP) {
			this.lnPersonal = lnP;
			InitializeComponent();
			esconderCosas();
		}

		/// <summary>
		///		Metodo que sirve para solo mostrar los apartados que cada tipo de personal puede acceder
		///		
		///		PRE:
		///		POST: Si el parametro LogicaNegocio_PersonalBiblioteca es de tipo LogicaNegocio_PersonalAdquisiciones escondera el menu de prestamos
		///			y si el parametro LogicaNegocio_PersonalBiblioteca es de tipo LogicaNegocio_PersonalSala escondera los menus de libro y ejemplar
		/// </summary>
		public void esconderCosas() {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion == null) {
				this.menuItemLibros.Visible = false;
				this.menuItemEjemplares.Visible = false;
			}

			LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
			if (lnSala == null) {
				this.menuItemPrestamos.Visible = false;
			}
		}

		#region MENU USUARIOS
		/// <summary>
		///		Este metodo sirve para dar de alta un nuevo usuario en nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemAltaUsuarios_Click(object sender, EventArgs e) {

			FClave fC = new FClave("usuario", "");
			DialogResult result = fC.ShowDialog();
			if (result == DialogResult.Cancel) {
				fC.Close();
			}
			else {
				string id_usuario = fC.Clave;
				fC.Dispose();
				Usuario usuarioExiste = this.lnPersonal.getUsuarioFromID(id_usuario);
				if (usuarioExiste == null) {
					FUsuario fU = new FUsuario("alta", id_usuario);
					DialogResult res = fU.ShowDialog();
					if (res == DialogResult.OK) {
						Usuario usuarioAnadir = fU.GetUsuario();
						if (usuarioAnadir.Id_usuario.Equals("") || usuarioAnadir.Nombre.Equals("") || usuarioAnadir.Apellidos.Equals("") || usuarioAnadir.Dni.Equals("")) {
							MessageBox.Show("Debes introducir datos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else {
							this.lnPersonal.altaUsuario(usuarioAnadir);
							MessageBox.Show("Usuario añadido.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

					}
					else {
						MessageBox.Show("Acción cancelada");
					}
				}
				else {
					DialogResult r = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un usuario con este ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (r == DialogResult.Yes) menuItemAltaUsuarios_Click(sender, e);
				}
			}
		}
		/// <summary>
		///		Este metodo sirve para dar de baja un usuario en nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemBajaUsuarios_Click(object sender, EventArgs e) {
			FClave fC = new FClave("usuario", "");
			DialogResult result = fC.ShowDialog();
			if (result == DialogResult.Cancel) {
				fC.Close();
			}
			else {
				string id_usuario = fC.Clave;
				fC.Dispose();
				Usuario usuarioEliminar = lnPersonal.getUsuarioFromID(id_usuario);
				if (usuarioEliminar != null) {
					FUsuario fU = new FUsuario("baja", id_usuario);
					fU.setNombre(usuarioEliminar.Nombre);
					fU.setApellidos(usuarioEliminar.Apellidos);
					fU.setDNI(usuarioEliminar.Dni);
					DialogResult res = fU.ShowDialog();
					if (res == DialogResult.OK) {
						DialogResult r = MessageBox.Show("¿Está seguro que desea dar de baja al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (r == DialogResult.Yes) {
							lnPersonal.bajaUsuario(usuarioEliminar);
							MessageBox.Show("Usuario eliminado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else MessageBox.Show("Acción cancelada");
				}
				else {
					DialogResult r = MessageBox.Show("¿Quieres introducir otro?", "El usuario no se ha encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (r == DialogResult.Yes) menuItemBajaUsuarios_Click(sender, e);
				}
			}
		}
		/// <summary>
		///		Este metodo sirve para mostrar los datos de un usuario a partir de su id
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void busquedaIDToolStripMenuItem_Click(object sender, EventArgs e) {
			FClave fC = new FClave("usuario", "");
			DialogResult result = fC.ShowDialog();
			if (result == DialogResult.Cancel) {
				fC.Close();
			}
			else {
				string id_usuario = fC.Clave;
				fC.Dispose();
				Usuario usuarioMostrar = lnPersonal.getUsuarioFromID(id_usuario);
				if (usuarioMostrar != null) {
					FUsuario fU = new FUsuario("ver", id_usuario);
					fU.setNombre(usuarioMostrar.Nombre);
					fU.setApellidos(usuarioMostrar.Apellidos);
					fU.setDNI(usuarioMostrar.Dni);
					DialogResult res = fU.ShowDialog();
				}
				else {
					DialogResult r = MessageBox.Show("¿Quieres introducir otro?", "El usuario no se ha encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (r == DialogResult.Yes) busquedaIDToolStripMenuItem_Click(sender, e);
				}
			}
		}
		/// <summary>
		///		Este metodo sirve para mostrar los usuarios y poder ordenarlos por distintos criterios
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listadoToolStripMenuItem_Click(object sender, EventArgs e) {
			FListadoUsuarios fL = new FListadoUsuarios(this.lnPersonal);
			fL.ShowDialog();
		}
		/// <summary>
		///		Este metodo sirve para mostrar los datos de los usuarios, pudiendo recorrerlos uno a uno
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e) {
			FUsuariosUnoaUno fU = new FUsuariosUnoaUno(lnPersonal);
			fU.ShowDialog();
		}
		/// <summary>
		///		Este metodo sirve para mostrar los datos de los usuarios, pudiendo escoger el usuario mediante su id en un desplegable
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemBusquedaEnLista_Click(object sender, EventArgs e) {
			FUsuarioDesplegable fU = new FUsuarioDesplegable(this.lnPersonal);
			fU.ShowDialog();
		}
		#endregion

		#region MENU LIBROS
		/// <summary>
		///		Este metodo sirve para crear un formularo FListadoLibros el 
		///			cual muestra por pantalla todos los libros que contiene
		///			nuestra BD
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:se muestra un formulario FListadoLibros que contiene todos los libros de nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listadoTodosLibros_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FListadoLibros fLL = new FListadoLibros(lnAdquisicion.getLibros());
				DialogResult d = fLL.ShowDialog();
				fLL.Dispose();
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
		/// <summary>
		///		Este metodo sirve para dar de alta un nuevo libro en nuestra base de datos
		///		
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:si todos los datos son correctos, se añade un nuevo libro a nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemAltaLibros_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("libro", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codLibro = fC.Clave;
					fC.Dispose();
					//Creamos un libro con la clave introducida y si no existe mostramos el formulario de añadir libro
					FLibro fLibro = new FLibro("alta", codLibro);
					DialogResult resultLibro = fLibro.ShowDialog();
					if (resultLibro == DialogResult.Cancel) {
						MessageBox.Show("Accion cancelada");
					}
					else {
						Libro libroToAdd = fLibro.getLibro();
						if (lnAdquisicion.getLibro(libroToAdd) != null) {
							//Si no es nulo significa que ya esta este libro en la base de datos
							MessageBox.Show("Este libro ya esta en la base de datos");
						}
						else {
							lnAdquisicion.altaLibro(libroToAdd);
						}
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}

		/// <summary>
		///		Este metodo sirve para dar de baja un libro de nuestra base de datos
		///		
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:si todos los datos son correctos, se da de baja un libro de nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemBajaLibros_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("libro", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codLibro = fC.Clave;
					fC.Dispose();
					Libro libroBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (libroBuscado != null) {
						FLibro fLibro = new FLibro("baja", codLibro);
						fLibro.set_Titulo(libroBuscado.NombreLibro);
						fLibro.set_Autor(libroBuscado.NombreAutor);
						DialogResult resultLibro = fLibro.ShowDialog();
						if (resultLibro == DialogResult.Cancel) {
							MessageBox.Show("Accion cancelada");
						}
						else {
							lnAdquisicion.bajaLibro(libroBuscado);

							// Borramos ahora los ejemplares de este libro
							List<Ejemplar> lEjem = lnAdquisicion.getEjemplaresLibro(libroBuscado);
							foreach(Ejemplar ej in lEjem) {
								lnAdquisicion.bajaEjemplar(ej);
							}
							MessageBox.Show("Libro borrado");
						}
					}
					else {
						MessageBox.Show("Este libro no esta en nuestra biblioteca");
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
		/// <summary>
		///		Este metodo sirve para buscar un libro de nuestra base de datos
		///		
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:si todos los datos son correctos y ese libro esta en nuestra base de datos se muestra por pantalla
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemBusquedaLibros_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("libro", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codLibro = fC.Clave;
					fC.Dispose();
					Libro libroBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (libroBuscado != null) {
						FLibro fLibro = new FLibro("ver", codLibro);
						fLibro.set_Titulo(libroBuscado.NombreLibro);
						fLibro.set_Autor(libroBuscado.NombreAutor);
						fLibro.ShowDialog();
						fLibro.Dispose();
					}
					else {
						MessageBox.Show("Este libro no esta en nuestra biblioteca");
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
		/// <summary>
		///		Este metodo muestra un listado de los libros mas leidos este mes
		///		
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:se muestra por pantalla aquel libro que este en el mayor numero de prestamos del ultimo mes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mostrarLibroMasLeidoEsteMesToolStripMenuItem_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				string codLibro = lnAdquisicion.getLibroMasLeido();
				Libro libroBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
				if (libroBuscado != null) {
					FLibro fLibro = new FLibro("ver", codLibro);
					fLibro.set_Titulo(libroBuscado.NombreLibro);
					fLibro.set_Autor(libroBuscado.NombreAutor);
					fLibro.ShowDialog();
					fLibro.Dispose();
				} else {
					MessageBox.Show("El libro mas leido del mes pasado, ya no se encuentra en nuestra biblioteca");
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
		/// <summary>
		///		Este metodo lista los libros de la base de datos uno a uno
		///		
		///		PRE: sender y e tiene que estar inicializados previamente
		///		POST:se muestra un formulario FListadoLibrosUnoAUno que contiene todos los libros de nuestra base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listarLibrosUnoAUno_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FListadoLibrosUnoAUno fListadoLibrosUno = new FListadoLibrosUnoAUno(lnAdquisicion.getLibros(), lnAdquisicion);
				fListadoLibrosUno.ShowDialog();
				fListadoLibrosUno.Dispose();
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
		#endregion

		#region MENU EJEMPLARES

		/// <summary>
		///		Metodo que se ejecuta cuando se realiza el evento Click sobre el menu de alta de ejemplares
		///		
		///		PRE: sender y e tienen que estar inicializados
		///		POST:si todos los datos se añaden correctamente se tiene que añadir un ejemplar nuevo a la base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemAltaEjemplares_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("ejemplar", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codLibro = fC.Clave;
					fC.Dispose();
					Libro libroBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (libroBuscado != null) {
						FEjemplares fEjemplar = new FEjemplares("alta", codLibro);
						DialogResult resultEjemplar = fEjemplar.ShowDialog();
						if (resultEjemplar == DialogResult.Cancel) {
							MessageBox.Show("Accion cancelada");
						} else {
							Ejemplar ejemplarToAdd = fEjemplar.getEjemplar();
							if (lnAdquisicion.getEjemplar(ejemplarToAdd) != null) {
								//Si no es nulo significa que ya esta este libro en la base de datos
								MessageBox.Show("Este ejemplar ya esta en la base de datos");
							} else {
								lnAdquisicion.altaEjemplar(ejemplarToAdd);
							}
						}
					} else {
						MessageBox.Show("Este libro no esta en nuestra base de datos");
					}
				}
			} else {
				MessageBox.Show("Accion no autorizada");
			}
		}

		/// <summary>
		///		Metodo que se ejecuta cuando se realiza el evento Click sobre el menu de baja de ejemplares
		///		
		///		PRE: sender y e tienen que estar inicializados
		///		POST:si todos los datos se escriben correctamente se quita el ejemplar indicado de la base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemBajaEjemplares_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("ejemplar", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				} else {
					string codLibro = fC.Clave;
					fC.Dispose();
					Libro libroBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (libroBuscado != null) {
						FEjemplares fE = new FEjemplares("baja", codLibro);
						DialogResult dialogoFE = fE.ShowDialog();
						if (dialogoFE == DialogResult.Cancel) {
							MessageBox.Show("Accion cancelada");
						} else {
							Ejemplar ejemplarBuscado = fE.getEjemplar();
							lnAdquisicion.bajaEjemplar(ejemplarBuscado);
							MessageBox.Show("Ejemplar borrado");
						}
					} else {
						MessageBox.Show("Este libro no esta en nuestra base de datos");
					}
				}
			} else {
				MessageBox.Show("Accion no autorizada");
			}
		}

		/// <summary>
		///		Metodo que se ejecuta cuando se realiza el evento Click sobre el menu de listar de ejemplares
		///		
		///		PRE: sender y e tienen que estar inicializados
		///		POST:se muestra un formulario FListadoEjemplares con todos los ejemplares que tenemos actualmente en la base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemListarEjemplares_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("ejemplar", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				} else {
					string codLibro = fC.Clave;
					fC.Dispose();
					Libro lBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (lBuscado != null) {
						FListadoEjemplares fLE = new FListadoEjemplares(lnAdquisicion.getEjemplaresLibro(lBuscado));
						DialogResult d = fLE.ShowDialog();
						fLE.Dispose();
					} else {
						MessageBox.Show("El libro asociado a este ISBN no esta asociado a nuestra base de datos");
					}
				}
			} else {
				MessageBox.Show("Accion no autorizada");
			}
		}

		/// <summary>
		///		PRE: sender y e tienen q estar iniciadas previamente
		///		POST:se recoge el codigo del libro que el usuario ha introducido y muestra la lista de ejemplares que no estan actualmente en un prestamo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listarEjemplaresDisponibles_MenuItem_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalAdquisiciones lnAdquisicion = this.lnPersonal as LogicaNegocio_PersonalAdquisiciones;
			if (lnAdquisicion != null) {
				FClave fC = new FClave("ejemplar", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				} else {
					string codLibro = fC.Clave;
					fC.Dispose();

					Libro lBuscado = lnAdquisicion.getLibroFromISBN(codLibro);
					if (lBuscado != null) {
						List<Ejemplar> todosEjemplares = lnAdquisicion.getEjemplaresLibro(lBuscado);
						List<Ejemplar> ejemplaresPrestados = new List<Ejemplar>();
						//Sacamos todos los ejemplares de la base de datos con ese libro
						List<Prestamo> prestamos = lnAdquisicion.getPrestamos();
						//Borramos los que no esten en un prestamo "prestado"
						foreach (Prestamo p in prestamos) {
							if (p.Estado.Equals("prestado")) {
								foreach (Ejemplar ej in p.EjemplarPrestado) {
									if (ej.CodigoLibro.Equals(codLibro)) {
										ejemplaresPrestados.Add(ej);
									}
								}
							}
						}

						todosEjemplares.RemoveAll(ej => ejemplaresPrestados.Contains(ej));
						if (todosEjemplares.Count > 0) {
							//Si hay ejemplares disponibles entonces mostramos el listado de los ejemplares disponibles
							FListadoEjemplares fLE = new FListadoEjemplares(todosEjemplares);
							DialogResult = fLE.ShowDialog();
							fLE.Dispose();
						}
						else {
							//Si no hay ejemplares disponibles se tiene que mostrar la fecha en la que se devuelve el mas temprano
							MessageBox.Show("No hay ejemplares disponibles actualmente, la fecha mas reciente donde habra uno disponible es el: " + lnAdquisicion.getFchaEjemplarDisponible(lnAdquisicion.getLibroFromISBN(codLibro)));
						}
					} else {
						MessageBox.Show("El libro asociado a este ISBN no esta asociado a nuestra base de datos");
					}
				}
			} else {
				MessageBox.Show("Accion no autorizada");
			}
		}
        #endregion

        #region MENU PRESTAMOS
        /// <summary>
        ///		Este metodo sirve para dar de alta un nuevo prestamo en nuestra base de datos
        ///		
        ///		PRE: sender y e tienen que estar inicializados previamente
        ///		POST:si todos los datos son correctos, se añade un nuevo prestamo a nuestra base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemAltaPrestamos_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
			if (lnSala != null) {
				FClave fC = new FClave("prestamo", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codPrestamo = fC.Clave;
					fC.Dispose();
					//Creamos un prestamo con la clave introducida y si no existe mostramos el formulario de añadir prestamo
					FPrestamo fPrestamo = new FPrestamo("alta", codPrestamo, lnSala);
					DialogResult resultPrestamo = fPrestamo.ShowDialog();
					if (resultPrestamo == DialogResult.Cancel) {
						MessageBox.Show("Accion cancelada");
					}
					else {
						Prestamo prestamoToAdd = fPrestamo.getPrestamo();
						if (prestamoToAdd != null && prestamoToAdd.Usuario != null) {
							prestamoToAdd.Prestador = lnSala.PersonalBiblioteca as Personal_de_sala;
							if (lnSala.getPrestamo(prestamoToAdd) != null) {
								MessageBox.Show("Este prestamo ya esta en la base de datos");
							}
							else {
								lnSala.altaPrestamo(prestamoToAdd);
                                MessageBox.Show("Prestamo añadido");
                            }
						}
						else {

							MessageBox.Show("Falta información");
						}
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}

		}
        /// <summary>
        ///		Este metodo sirve para dar de baja un prestamo de nuestra base de datos
        ///		
        ///		PRE: sender y e tienen que estar inicializados previamente
        ///		POST:si todos los datos son correctos, se da de baja un prestamo de nuestra base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemBajaPrestamos_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
			if (lnSala != null) {
				FClave fC = new FClave("prestamo", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codPrestamo = fC.Clave;
					fC.Dispose();
					Prestamo prestamoBuscado = lnSala.getPrestamoFromCod(codPrestamo);
					if (prestamoBuscado != null) {
						FPrestamo fPrestamo = new FPrestamo("baja", codPrestamo, lnSala);
                        fPrestamo.set_CodPrestamo(prestamoBuscado.CodPrestamo);
                        fPrestamo.set_Estado(prestamoBuscado.Estado);
                        fPrestamo.set_FechaRealizacion(prestamoBuscado.FechaRealizacion);
                        fPrestamo.set_FechaDevolucion(prestamoBuscado.FechaFin);

                        DialogResult resultLibro = fPrestamo.ShowDialog();
						if (resultLibro == DialogResult.Cancel) {
							MessageBox.Show("Accion cancelada");
						}
						else {
							lnSala.bajaPrestamo(prestamoBuscado);
							MessageBox.Show("Prestamo borrado");
						}
					}
					else {
						MessageBox.Show("Este prestamo no esta en nuestra biblioteca");
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
        /// <summary>
        ///		Este metodo sirve para buscar un prestamo de nuestra base de datos
        ///		
        ///		PRE: sender y e tienen que estar inicializados previamente
        ///		POST:si todos los datos son correctos y ese libro esta en nuestra base de datos se muestra por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemBusquedaPrestamos_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
			if (lnSala != null) {
				FClave fC = new FClave("prestamo", "");
				DialogResult dr = fC.ShowDialog();
				if (dr == DialogResult.Cancel) {
					fC.Close();
				}
				else {
					string codPrestamo = fC.Clave;
					fC.Dispose();
					Prestamo prestamoBuscado = lnSala.getPrestamoFromCod(codPrestamo);
					if (prestamoBuscado != null) {
						FPrestamo fPrestamo = new FPrestamo("ver", codPrestamo, lnSala);
						fPrestamo.set_CodPrestamo(prestamoBuscado.CodPrestamo);
						fPrestamo.set_Estado(prestamoBuscado.Estado);
						fPrestamo.set_FechaRealizacion(prestamoBuscado.FechaRealizacion);
						fPrestamo.set_FechaDevolucion(prestamoBuscado.FechaFin);
						fPrestamo.ShowDialog();
						fPrestamo.Dispose();
					}
					else {
						MessageBox.Show("Este libro no esta en nuestra biblioteca");
					}
				}
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
        /// <summary>
        ///		Este metodo lista los prestamos de la base de datos uno a uno
        ///		
        ///		PRE: sender y e tiene que estar inicializados previamente
        ///		POST:se muestra un formulario FPrestamosUnoaUno que contiene todos los prestamos de nuestra base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarPrestamosUnoAUno_Click(object sender, EventArgs e) {
			LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
			if (lnSala != null) {
				FPrestamosUnoaUno fPrestamosUnoaUno = new FPrestamosUnoaUno(lnSala.getPrestamos(), lnSala);
				fPrestamosUnoaUno.ShowDialog();
				fPrestamosUnoaUno.Dispose();
			}
			else {
				MessageBox.Show("Accion no autorizada");
			}
		}
        /// <summary>
        ///		Este metodo muestra un listado de los prestamos de la BD
        ///		
        ///		PRE: sender y e tienen que estar inicializados previamente
        ///		POST:se muestra por pantalla un listado donde están registrados todos los prestamos de la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoPrestamos_Click(object sender, EventArgs e)
		{
            LogicaNegocio_PersonalSala lnSala = this.lnPersonal as LogicaNegocio_PersonalSala;
            if (lnSala != null)
            {
                FListadoPrestamos fPrestamos = new FListadoPrestamos(lnSala.getPrestamos(), lnSala);
                fPrestamos.ShowDialog();
                fPrestamos.Dispose();
            }
            else
            {
                MessageBox.Show("Accion no autorizada");
            }


        }
		#endregion

		/// <summary>
		///		Cierra la aplicacion entera si se cierra el formulario principal
		///		PRE: sender y e tienen que estar inicializados previamente
		///		POST:La aplicacion se cierra
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
	}
}