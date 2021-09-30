using ExamenQuark.Modelo;
using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Controladores
{
    public class CotizacionController
    {
        /// <summary>
        /// Crea y retorna una cotización, asigna el ID en base a la ultima cotización del vendedor.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <param name="prenda"></param>
        /// <returns></returns>
        public Cotizacion CreateCotizacion(Vendedor vendedor, Prenda prenda)
        {
            return(new Cotizacion(vendedor.GetUltimaCotizacionId() + 1, vendedor.Codigo, prenda, prenda.Stock));
        }

        /// <summary>
        /// Devuelve un string con todas las cotizaciones de la lista pasada por parametro, imrpimiendo todos sus datos y los de su producto.
        /// </summary>
        /// <param name="cotizaciones"></param>
        /// <returns></returns>
        public string MostrarCotizaciones(List<Cotizacion> cotizaciones)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Cotizacion cotizacion in cotizaciones)
            {
                if (cotizacion.Prenda.GetType().Name == "Camisa")
                {
                    sb.AppendFormat("ID: {0} - Creado: {1} - Camisa - {2} - Cantidad: {3} - Precio Final: {4}", cotizacion.Id, cotizacion.CreadoDateTime.ToString(), ((Camisa)cotizacion.Prenda).ToString(), cotizacion.Cantidad, cotizacion.PrecioFinal.ToString("c2")).AppendLine().AppendLine();
                }
                else
                {
                    sb.AppendFormat("ID: {0} - Creado: {1} - Pantalón - {2} - Cantidad: {3} - Precio Final: {4}", cotizacion.Id, cotizacion.CreadoDateTime.ToString(), ((Pantalon)cotizacion.Prenda).ToString(), cotizacion.Cantidad, cotizacion.PrecioFinal.ToString("c2")).AppendLine().AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
