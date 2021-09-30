using ExamenQuark.Modelo;
using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Controladores
{
    public class PrendaController
    {
        /// <summary>
        /// Crea una Camisa con los datos pasados por parametro.
        /// </summary>
        /// <param name="CalidadStandard"></param>
        /// <param name="Precio"></param>
        /// <param name="Stock"></param>
        /// <param name="EsChupin"></param>
        /// <returns></returns>
        public Prenda CreatePrenda(bool CalidadStandard, string Precio, string Stock, bool EsChupin)
        {
            if (!CheckValue(Precio))
            {
                throw new Exception("Se debe ingresar el dato: " + nameof(Precio) + " de la prenda para poder realizar la cotización.");
            }

            if (!CheckValue(Stock))
            {
                throw new Exception("Se debe ingresar el dato: " + nameof(Stock) + " de la prenda para poder realizar la cotización.");
            }

            Pantalon prenda = new Pantalon((CalidadStandard ? ECalidad.Standard : ECalidad.Premium), decimal.Parse(Precio), Int32.Parse(Stock), EsChupin);
            return prenda;
        }

        /// <summary>
        /// Crea un Pantalón con los datos pasados por parametro.
        /// </summary>
        /// <param name="CalidadStandard"></param>
        /// <param name="Precio"></param>
        /// <param name="Stock"></param>
        /// <param name="MangaLarga"></param>
        /// <param name="CuelloMao"></param>
        /// <returns></returns>
        public Prenda CreatePrenda(bool CalidadStandard, string Precio, string Stock, bool MangaLarga, bool CuelloMao)
        {
            if(!CheckValue(Precio))
            {
                throw new Exception("Se debe ingresar el dato: " + nameof(Precio) + " de la prenda para poder realizar la cotización.");
            }

            if (!CheckValue(Stock))
            {
                throw new Exception("Se debe ingresar el dato: " + nameof(Stock) + " de la prenda para poder realizar la cotización.");
            }

            Camisa prenda = new Camisa((CalidadStandard ? ECalidad.Standard : ECalidad.Premium), decimal.Parse(Precio), Int32.Parse(Stock), MangaLarga, CuelloMao);
            return prenda;
        }

        /// <summary>
        /// Verifica que el valor pasado por parametro no sea vacío.
        /// </summary>
        public bool CheckValue(string Valor)
        {
            if (!String.IsNullOrEmpty(Valor))
            {
                return true;
            }

            return false;
        }
    }
}
