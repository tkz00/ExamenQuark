using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    public class Tienda
    {
        #region Atributos
        private string nombre;
        private string direccion;
        private List<Vendedor> vendedores;
        private List<Prenda> prendas;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
        }

        public List<Vendedor> Vendedores
        {
            get
            {
                return this.vendedores;
            }
        }

        public List<Prenda> Prendas
        {
            get
            {
                return this.prendas;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor para el objeto Tienda, guarda el nombre y la dirección e inicializa las listas de prendas y vendedores.
        /// </summary>
        public Tienda(string Nombre, string Direccion)
        {
            this.nombre = Nombre;
            this.direccion = Direccion;
            this.prendas = new List<Prenda>();
            this.vendedores = new List<Vendedor>();
        }

        /// <summary>
        /// Contructor del objeto Tienda, llama al constructor anterior, pero aparte le asgina una lista de prendas pasada por parametro.
        /// </summary>
        public Tienda(string Nombre, string Direccion, List<Prenda> Prendas) : this(Nombre, Direccion)
        {
            this.prendas = Prendas;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del operador +, permite agregar vendedores a la lista de la tienda.
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static Tienda operator +(Tienda tienda, Vendedor vendedor)
        {
            tienda.vendedores.Add(vendedor);
            return tienda;
        }
        #endregion
    }
}
