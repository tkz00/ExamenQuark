using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Vendedor
    {
        #region Atributos
        private int codigo;
        private string nombre;
        private string apellido;
        private List<Cotizacion> cotizaciones;
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
        /// Sobrecarga del operador +, agrega a la lista de cotizaciones del vendedor la cotización envíada por parametro.
        /// </summary>
        /// <param name="vendedor">El vendedor al cual agregar la cotización.</param>
        /// <param name="cotizacion">La cotización a ser agregada.</param>
        /// <returns>El vendedor con la cotización ya agregada.</returns>
        public static Vendedor operator +(Vendedor vendedor, Cotizacion cotizacion)
        {
            vendedor.cotizaciones.Add(cotizacion);
            return vendedor;
        }
        #endregion
    }
}
