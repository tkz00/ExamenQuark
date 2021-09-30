using ExamenQuark.Modelo;
using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Controladores
{
    public class TiendaController
    {
        /// <summary>
        /// Devuelve una lista de prendas hardcodeada para prruebas del programa.
        /// </summary>
        public List<Prenda> HardcodePrendas()
        {
            List<Prenda> prendas = new List<Prenda>();

            prendas.Add(new Camisa(ECalidad.Standard, 100, false, true));
            prendas.Add(new Camisa(ECalidad.Premium, 100, false, true));
            prendas.Add(new Camisa(ECalidad.Standard, 150, false, false));
            prendas.Add(new Camisa(ECalidad.Premium, 150, false, false));
            prendas.Add(new Camisa(ECalidad.Standard, 75, true, true));
            prendas.Add(new Camisa(ECalidad.Premium, 75, true, true));
            prendas.Add(new Camisa(ECalidad.Standard, 175, true, false));
            prendas.Add(new Camisa(ECalidad.Premium, 175, true, false));

            prendas.Add(new Pantalon(ECalidad.Standard, 750, true));
            prendas.Add(new Pantalon(ECalidad.Premium, 750, true));
            prendas.Add(new Pantalon(ECalidad.Standard, 250, false));
            prendas.Add(new Pantalon(ECalidad.Premium, 250, false));

            return prendas;
        }

        /// <summary>
        /// Busca una prenda especifica en una lista y en el caso de encontrarlla devuelve el stock.
        /// </summary>
        /// <returns>Devuelve el stock de la prenda en la lista o -1 en caso de que la prenda no se encuentre en la lisma</returns>
        internal int GetStock(Prenda prenda, List<Prenda> Prendas)
        {
            foreach(Prenda aux in Prendas)
            {
                if (prenda.GetType() == aux.GetType())
                {
                    if (prenda.GetType().Name == "Camisa")
                    {
                        if ((Camisa)aux == (Camisa)prenda)
                        {
                            return aux.Stock;
                        }
                    }
                    else
                    {
                        if ((Pantalon)aux == (Pantalon)prenda)
                        {
                            return aux.Stock;
                        }
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Resta la cantidad de stock de la prenda en  la cotización a la prenda en la lista de prendas de la tienda.
        /// </summary>
        /// <returns>Devuelve la tienda con las modificaciones hechas.</returns>
        internal Tienda RestarStock(Tienda tienda, Cotizacion newCotizacion)
        {
            for (int i = 0; i < tienda.Prendas.Count; i++)
            {
                if (newCotizacion.Prenda.GetType() == tienda.Prendas[i].GetType())
                {
                    if (newCotizacion.Prenda.GetType().Name == "Camisa")
                    {
                        if ((Camisa)tienda.Prendas[i] == (Camisa)newCotizacion.Prenda)
                        {
                            tienda.Prendas[i] -= newCotizacion.Prenda.Stock;
                        }
                    }
                    else
                    {
                        if ((Pantalon)tienda.Prendas[i] == (Pantalon)newCotizacion.Prenda)
                        {
                            tienda.Prendas[i] -= newCotizacion.Prenda.Stock;
                        }
                    }
                }
            }

            return tienda;
        }
    }
}
