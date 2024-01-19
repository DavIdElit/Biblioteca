using System;
using LogicaNegocio;
using ModeloDominio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
	static class ProgramaInicio {
		/// <summary>
		/// Punto de entrada a la aplicacion, ejecuta el formulario principal
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			FLogin fl = new FLogin(new LogicaNegocio_Login());
			fl.ShowDialog();
			if (fl.Personal != null)
			{
                Personal_de_sala pSala= fl.Personal as Personal_de_sala;
				Personal_adquisiciones pAdquisiciones= fl.Personal as Personal_adquisiciones;
				if( pAdquisiciones != null)
				{
					LogicaNegocio_PersonalAdquisiciones ln_pa = new LogicaNegocio_PersonalAdquisiciones(pAdquisiciones);
                    FPrincipal fp = new FPrincipal(ln_pa);
                    fp.Show();
                }else if (pSala != null)
                {
                    LogicaNegocio_PersonalSala ln_ps = new LogicaNegocio_PersonalSala(pSala);
                    FPrincipal fp = new FPrincipal(ln_ps);
                    fp.Show();
				}

            }
			Application.Run();
		}
	}
}