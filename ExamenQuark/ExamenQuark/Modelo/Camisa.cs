using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Modelo
{
    class Camisa : Prenda
    {
        #region Atributos
        private bool mangaLarga;
        private bool cuelloMao;
        #endregion

        #region Propiedades
        public bool MangaLarga
        {
            get
            {
                return this.mangaLarga;
            }
        }

        public bool CuelloMao
        {
            get
            {
                return this.cuelloMao;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Camisa, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica.
        /// </summary>
        public Camisa(ECalidad Calidad, decimal Precio, int Stock, bool MangaLarga, bool CuelloMao) : base(Calidad, Stock, Precio)
        {
            this.mangaLarga = MangaLarga;
            this.cuelloMao = CuelloMao;
        }

        /// <summary>
        /// Constructor de la clase Camisa, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica, no tiene precio para la lista de prendas de la tienda.
        /// </summary>
        public Camisa(ECalidad Calidad, int Stock, bool MangaLarga, bool CuelloMao) : base(Calidad, Stock)
        {
            this.mangaLarga = MangaLarga;
            this.cuelloMao = CuelloMao;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Comparación entre dos camisas, primero compara ambos objetos como Prendas, y luego compara los atributos propios dela clase Camisa.
        /// </summary>
        public static bool operator ==(Camisa a, Camisa b)
        {
            if ((Prenda)a == (Prenda)b)
            {
                if (a.mangaLarga == b.mangaLarga && a.cuelloMao == b.cuelloMao)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Invierte el resultado de la sobrecarga de ==.
        /// </summary>
        public static bool operator !=(Camisa a, Camisa b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Construye un string con toda la información sobre la prenda.
        /// </summary>
        /// <returns>Devuelve un string con toda la información sobre la prenda concatenada.</returns>
        public override string ToString()
        {
            return "Calidad: " + base.Calidad + " - " + (this.mangaLarga ? "Manga larga" : "Manga corta") + " - " + (this.cuelloMao ? "Cuello mao" : "Cuello común");
        }
        #endregion
    }
}
