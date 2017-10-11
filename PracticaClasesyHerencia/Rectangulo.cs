using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClasesyHerencia
{
    class Rectangulo:Figura
    {

        private float baseRectangulo=0;
        private float alturaRectangulo=0;

        /// <summary>
        /// Longitud de la base del rectángulo.
        /// </summary>
        public float BaseRectangulo
        {
            get
            {
                return baseRectangulo;
            }
            set
            {
                baseRectangulo = value;
            }
        }

        /// <summary>
        /// Longitud de la altura del rectángulo.
        /// </summary>
        public float AlturaRectangulo
        {
            get
            {
                return alturaRectangulo;
            }
            set
            {
                alturaRectangulo = value;
            }
        }

        public override float Perimetro()
        {
            return alturaRectangulo * 2 + baseRectangulo * 2;
        }

        public override float Area()
        {
            return alturaRectangulo * baseRectangulo;
        }

    }
}
