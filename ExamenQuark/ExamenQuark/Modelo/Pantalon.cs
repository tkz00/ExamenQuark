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
        private bool esChupin;

        /// <summary>
        /// Constructor de la clase Pantalon, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica.
        /// </summary>
        public Pantalon(ECalidad Calidad, double Precio, int Stock, bool EsChupin) : base(Calidad, Precio, Stock)
        {
            this.esChupin = EsChupin;
        }
    }
}
