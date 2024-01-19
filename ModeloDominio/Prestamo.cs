using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Prestamo    {

        //Atributos
        private string cod_prestamo;
        private string estado;
        private DateTime fechaRealizacion;
        private DateTime fechaFin;
        private Personal_de_sala prestador;
        private List<Ejemplar> ejemplarPrestado;
        private Usuario usuario;

        //Propiedades
        public string CodPrestamo
        {
            get { return cod_prestamo; }
        }

        public string Estado {
            get { return estado; } 
        }

        public DateTime FechaRealizacion
        {
            get { return fechaRealizacion; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        public Personal_de_sala Prestador
        {
            get { return prestador; }
            set { this.prestador = value; } 
        }

        public List<Ejemplar> EjemplarPrestado
        {
            get { return ejemplarPrestado; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
        }

        /// <summary>
        /// Constructor con parametros de la clase Prestamo
        ///     PRE: cod_prestamo, estado, fechaRealizacion, fechaFin, prestados, ejemplarPrestado y usuario tienen que estar inicializadas previamente
        ///     POST:Devuelve un objeto Prestamo con los parametros que se han pasado
        /// </summary>
        /// <param name="cod_prestamo"></param>
        /// <param name="estado"></param>
        /// <param name="fechaRealizacion"></param>
        /// <param name="fechaRealizacion"></param>
        /// <param name="fechaFin"></param>
        /// <param name="prestador"></param>
        /// <param name="ejemplarPrestado"></param>
        /// <param name="usuario"></param>
        public Prestamo(string cod_prestamo, string estado, DateTime fechaRealizacion, DateTime fechaFin, Personal_de_sala prestador, List<Ejemplar> ejemplarPrestado,Usuario usuario)
        {
            this.cod_prestamo = cod_prestamo;
            this.estado = estado;
            this.fechaRealizacion = fechaRealizacion;
            this.fechaFin = fechaFin;
            this.prestador = prestador;
            this.ejemplarPrestado = ejemplarPrestado;
            this.usuario = usuario;
        }
    }
}
