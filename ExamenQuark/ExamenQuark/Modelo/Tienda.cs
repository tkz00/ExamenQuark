using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Tienda
    {
        #region Atributos
        private string nombre;
        private string direccion;
        private List<Prenda> prendas;
        #endregion

        public Tienda(string Nombre, string Direccion)
        {
            this.nombre = Nombre;
            this.direccion = Direccion;
            this.prendas = new List<Prenda>();
        }

        public Tienda(string Nombre, string Direccion, List<Prenda> Prendas) : this(Nombre, Direccion)
        {
            this.prendas = Prendas;
        }
    }
}
