using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClasesyHerencia
{
    class Triangulo:Figura
    {

        private float baseTriangulo=0;
        private float alturaTriangulo=0;

        /// <summary>
        /// Longitud de la base del triángulo.
        /// </summary>
        public float BaseTriangulo
        {
            get
            {
                return baseTriangulo;
            }
            set
            {
                baseTriangulo = value;
            }
        }

        /// <summary>
        /// Longitud de la altura del triángulo.
        /// </summary>
        public float AlturaTriangulo
        {
            get
            {
                return alturaTriangulo;
            }
            set
            {
                alturaTriangulo = value;
            }
        }

        public override float Perimetro()
        {
            return baseTriangulo*3;
        }

        public override float Area()
        {
            return (alturaTriangulo * baseTriangulo) / 2;
        }

    }
}
