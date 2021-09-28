using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Prenda
    {
        #region Atributos
        private ECalidad calidad;
        private double precio;
        private int stock;
        #endregion

        #region Propiedades
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        #endregion

        #region Constructores
        public Prenda(ECalidad Calidad, double Precio, int Stock)
        {
            this.calidad = Calidad;
            this.precio = Precio;
            this.stock = Stock;
        }
        #endregion

        #region Metodos
        public static Prenda operator +(Prenda prenda, int cantidad)
        {
            prenda.stock += cantidad;
            return prenda;
        }

        public static Prenda operator -(Prenda prenda, int cantidad)
        {
            if((prenda.stock - cantidad) < 0)
            {
                throw new Exception("El stock de una prenda nunca puede ser menor a 0");
            }
            return (prenda + (cantidad * -1));
        }
        #endregion
    }
}
