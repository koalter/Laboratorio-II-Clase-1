using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Calcula el área de un cuadrado.
        /// </summary>
        /// <param name="lado">Longitud del lado del cuadrado.</param>
        /// <returns></returns>
        public static double CalcularCuadrado(double lado)
        {
            double resultado = lado * lado;

            return resultado;
        }

        /// <summary>
        /// Calcula el área de un triángulo.
        /// </summary>
        /// <param name="laBase">La medida de la base del triángulo.</param>
        /// <param name="laAltura">La altura del triángulo.</param>
        /// <returns></returns>
        public static double CalcularTriangulo(double laBase, double laAltura)
        {
            double resultado = (laBase * laAltura) / 2;

            return resultado;
        }

        /// <summary>
        /// Calcula el área de un círculo.
        /// </summary>
        /// <param name="radio">Radio que posee el círculo, también es la mitad del diámetro.</param>
        /// <returns></returns>
        public static double CalcularCirculo(double radio)
        {
            double resultado = Math.PI * Math.Pow(radio, 2);

            return resultado;
        }
    }
}
