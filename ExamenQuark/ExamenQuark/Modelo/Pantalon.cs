using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Pantalon : Prenda
    {
        #region Atributos
        private bool esChupin;
        #endregion

        #region Propiedades
        public bool EsChupin
        {
            get
            {
                return this.esChupin;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Pantalon, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica.
        /// </summary>
        public Pantalon(ECalidad Calidad, decimal Precio, int Stock, bool EsChupin) : base(Calidad, Stock, Precio)
        {
            this.esChupin = EsChupin;
        }

        /// <summary>
        /// Constructor de la clase Pantalon, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica, no tiene precio para la lista de productos de la tienda.
        /// </summary>
        public Pantalon(ECalidad Calidad, int Stock, bool EsChupin) : base(Calidad, Stock)
        {
            this.esChupin = EsChupin;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Comparación entre dos pantalones, primero compara ambos objetos como Prendas, y luego compara el atributo propio de la clase Pantalón.
        /// </summary>
        public static bool operator ==(Pantalon a, Pantalon b)
        {
            if ((Prenda)a == (Prenda)b)
            {
                if (a.esChupin == b.esChupin)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Invierte el resultado de la sobrecarga de ==.
        /// </summary>
        public static bool operator !=(Pantalon a, Pantalon b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Construye un string con toda la información sobre la prenda.
        /// </summary>
        /// <returns>Devuelve un string con toda la información sobre la prenda concatenada.</returns>
        public override string ToString()
        {
            return "Calidad: " + base.Calidad + " - " + (this.esChupin ? "Chupin" : "Común");
        }
        #endregion
    }
}
