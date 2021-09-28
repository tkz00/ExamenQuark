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
        private bool mangaLarga;
        private bool cuelloMao;

        /// <summary>
        /// Constructor de la clase Camisa, llama al constructor de la clase base prenda para asignar los valores comunes, y asigna los propios dentro de su lógica.
        /// </summary>
        public Camisa(ECalidad Calidad, double Precio, int Stock, bool MangaLarga, bool CuelloMao) : base(Calidad, Precio, Stock)
        {
            this.mangaLarga = MangaLarga;
            this.cuelloMao = CuelloMao;
        }
    }
}
