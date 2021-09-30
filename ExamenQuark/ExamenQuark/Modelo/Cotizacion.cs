using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    public class Cotizacion
    {
        #region Atributos
        private int id;
        private DateTime creadoDatetime;
        private int codigoVendedor;
        private Prenda prenda;
        private int cantidad;
        private decimal precioFinal;
        #endregion

        #region Propiedades
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public DateTime CreadoDateTime
        {
            get
            {
                return this.creadoDatetime;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public Prenda Prenda
        {
            get
            {
                return this.prenda;
            }
        }

        public decimal PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cotizacion.
        /// </summary>
        /// <param name="CodigoVendedor"></param>
        /// <param name="Prenda"></param>
        /// <param name="Cantidad"></param>
        public Cotizacion(int Id, int CodigoVendedor, Prenda Prenda, int Cantidad)
        {
            this.id = Id;
            this.creadoDatetime = DateTime.Now;
            this.codigoVendedor = CodigoVendedor;
            this.prenda = Prenda;
            this.cantidad = Cantidad;
            this.precioFinal = this.GetPrecioFinal();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que realiza el calculo del precio final de una cotización teniendo en cuenta los datos de la prenda y la cantidad de la misma.
        /// </summary>
        /// <param name="Prenda"></param>
        /// <param name="Cantidad"></param>
        /// <returns></returns>
        private decimal GetPrecioFinal()
        {
            decimal PrecioFinal = this.prenda.Precio;

            if (this.prenda.Calidad == ECalidad.Premium)
            {
                PrecioFinal *= (decimal)1.3;
            }

            if (this.prenda.GetType().Name == "Camisa")
            {
                Camisa camisa = this.prenda as Camisa;

                if (!camisa.MangaLarga)
                {
                    PrecioFinal *= (decimal)0.9;
                }

                if (camisa.CuelloMao)
                {
                    PrecioFinal *= (decimal)1.03;
                }
            }
            else
            {
                Pantalon pantalon = this.prenda as Pantalon;

                if (pantalon.EsChupin)
                {
                    PrecioFinal *= (decimal)0.88;
                }
            }

            return PrecioFinal * this.cantidad;
        }
        #endregion
    }
}
