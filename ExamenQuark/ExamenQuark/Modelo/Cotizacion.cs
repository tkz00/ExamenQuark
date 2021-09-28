using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Cotizacion
    {
        #region Atributos
        private int id;
        private DateTime creadoDatetime;
        private int codigoVendedor;
        private Prenda prenda;
        private int cantidad;
        private decimal precioFinal;
        #endregion

        /// <summary>
        /// Constructor de la clase Cotizacion.
        /// </summary>
        /// <param name="CodigoVendedor"></param>
        /// <param name="Prenda"></param>
        /// <param name="Cantidad"></param>
        public Cotizacion(int CodigoVendedor, Prenda Prenda, int Cantidad)
        {
            this.creadoDatetime = DateTime.Now;
            this.codigoVendedor = CodigoVendedor;
            this.prenda = Prenda;
            this.cantidad = Cantidad;
            this.precioFinal = (decimal)(Prenda.Precio * Cantidad);
        }
    }
}
