using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClasesyHerencia
{
    class Circulo:Figura
    {

        private float radio=0;

        /// <summary>
        /// Longitud del radio del círculo.
        /// </summary>
        public float Radio
        {
            get
            {
                return radio;
            }
            set
            {
                radio = value;
            }
        }

        public override float Perimetro()
        {
            return (float)(2*Math.PI*radio);
        }

        public override float Area()
        {
            return (float)(Math.PI*radio*radio);
        }

    }
}
