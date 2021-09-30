using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    public class Prenda
    {
        #region Atributos
        private ECalidad calidad;
        private decimal precio;
        private int stock;
        #endregion

        #region Propiedades
        public decimal Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
        }

        public ECalidad Calidad
        {
            get
            {
                return this.calidad;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase prenda que asigna calidad y stock.
        /// </summary>
        public Prenda(ECalidad Calidad, int Stock)
        {
            this.calidad = Calidad;
            this.stock = Stock;
        }

        /// <summary>
        /// Constructor que asigna Calidad, stock y precio a la prenda, es sobrecarga del constructor original.
        /// </summary>
        public Prenda(ECalidad Calidad, int Stock, decimal Precio) : this(Calidad, Stock)
        {
            this.precio = Precio;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del operador +, aumenta la cantidad de stock de una prenda.
        /// </summary>
        /// <param name="prenda">La prenda a la que se le va a modificar el Stock.</param>
        /// <param name="cantidad">La cantidad de stock a ser modificado.</param>
        /// <returns>Retorna la prenda con el stock modificado.</returns>
        public static Prenda operator +(Prenda prenda, int cantidad)
        {
            prenda.stock += cantidad;
            return prenda;
        }

        /// <summary>
        /// Sobrecarga del operador -, resta la cantidad de stock de una prenda.
        /// </summary>
        /// <param name="prenda">La prenda a la que se le va a modificar el Stock.</param>
        /// <param name="cantidad">La cantidad de stock a ser modificado.</param>
        /// <returns>Retorna la prenda con el stock modificado.</returns>
        public static Prenda operator -(Prenda prenda, int cantidad)
        {
            if((prenda.stock - cantidad) < 0)
            {
                throw new Exception("El stock de una prenda nunca puede ser menor a 0");
            }
            return (prenda + (cantidad * -1));
        }

        /// <summary>
        /// Sobrecarga del operador de comparación, permite ver si dos prendas tienen la misma calidad, ya que pueden tener precio y stock distintos y ser la misma prenda.
        /// </summary>
        public static bool operator ==(Prenda a, Prenda b)
        {
            if(a.calidad == b.calidad)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de comparación, permite ver si dos prendas tienen distinta calidad, ya que pueden tener precio y stock distintos y ser la misma prenda.
        /// </summary>
        public static bool operator !=(Prenda a, Prenda b)
        {
            return !(a == b);
        }
        #endregion
    }
}
