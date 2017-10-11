using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClasesyHerencia
{
    public partial class Form1 : Form
    {

        Rectangulo rectangulo = new Rectangulo();
        Triangulo triangulo = new Triangulo();
        Circulo circulo = new Circulo();

        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Calcula el perímetro del cuadrado según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularPerimetroRectangulo_Click(object sender, EventArgs e)
        {

            rectangulo.BaseRectangulo = (float) txtRectanguloBase.Value;
            rectangulo.AlturaRectangulo = (float)txtRectanguloAltura.Value;

            txtResultadoRectangulo.Text = rectangulo.Perimetro().ToString();

        }

        /// <summary>
        /// Calcula el área del cuadrado según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularAreaRectangulo_Click(object sender, EventArgs e)
        {

            rectangulo.BaseRectangulo = (float)txtRectanguloBase.Value;
            rectangulo.AlturaRectangulo = (float)txtRectanguloAltura.Value;

            txtResultadoRectangulo.Text = rectangulo.Area().ToString();
        }

        /// <summary>
        /// Calcula el perímetro del triángulo según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularPerimetroTriangulo_Click(object sender, EventArgs e)
        {
            triangulo.BaseTriangulo = (float)txtTrianguloBase.Value;
            triangulo.AlturaTriangulo = (float)txtTrianguloAltura.Value;

            txtResultadoTriangulo.Text = triangulo.Perimetro().ToString();
        }

        /// <summary> área del triángulo según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularAreaTriangulo_Click(object sender, EventArgs e)
        {
            triangulo.BaseTriangulo = (float)txtTrianguloBase.Value;
            triangulo.AlturaTriangulo = (float)txtTrianguloAltura.Value;

            txtResultadoTriangulo.Text = triangulo.Area().ToString();
        }

        /// <summary>
        /// Calcula el perímetro del círculo según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularPerimetroCirculo_Click(object sender, EventArgs e)
        {
            circulo.Radio = (float)txtCirculoRadio.Value;

            txtResultadoCirculo.Text = circulo.Perimetro().ToString();
        }


        /// <summary>
        /// Calcula el área del círculo según la base y la altura introducida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnCalcularAreaCirculo_Click(object sender, EventArgs e)
        {
            circulo.Radio = (float)txtCirculoRadio.Value;

            txtResultadoCirculo.Text = circulo.Area().ToString();
        }
    }
}
