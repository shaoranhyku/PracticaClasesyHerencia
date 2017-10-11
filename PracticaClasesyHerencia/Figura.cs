using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClasesyHerencia
{
    class Figura
    {
        /// <summary>
        /// Permite calcular el perímetro de una figura.
        /// </summary>
        /// <returns>Devuelve el perímetro de la figura.</returns>
        public virtual float Perimetro()
        {
            return 0;
        }

        /// <summary>
        /// Permite calcular el área de una figura.
        /// </summary>
        /// <returns>Devuelve el área de la figura.</returns>
        public virtual float Area()
        {
            return 0;
        }

    }
}
