using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    public class Vendedor
    {
        #region Atributos
        private int codigo;
        private string nombre;
        private string apellido;
        private List<Cotizacion> cotizaciones;
        #endregion

        #region Propiedades
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public List<Cotizacion> Cotizaciones
        {
            get
            {
                return this.cotizaciones;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Vendedor, asigna todos sus atributos e inicializa la lista de cotizaciones.
        /// </summary>
        public Vendedor(string Nombre, string Apellido, int Codigo)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.codigo = Codigo;
            this.cotizaciones = new List<Cotizacion>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la información concatenada del vendedor.
        /// </summary>
        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " | " + this.codigo;
        }

        /// <summary>
        /// Metodo que permite conseguir el id más alto de las cotizaciones del vendedor.
        /// </summary>
        /// <returns>El id más alto o -1 en caso de que el vendedor no tenga cotizaciones.</returns>
        public int GetUltimaCotizacionId()
        {
            if (this.Cotizaciones.Count > 0)
            {
                return this.Cotizaciones.Max(x => x.Id);
            }
            return -1;
        }

        /// <summary>
        /// Método que permite agregar a la lista de cotizaciones del vendedor la cotización envíada por parametro.
        /// </summary>
        /// <param name="vendedor">El vendedor al cual agregar la cotización.</param>
        /// <param name="cotizacion">La cotización a ser agregada.</param>
        /// <returns>El vendedor con la cotización ya agregada.</returns>
        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            this.Cotizaciones.Add(cotizacion);
        }
        #endregion
    }
}
