using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado = lado * lado;

            return resultado;
        }

        public static double CalcularTriangulo(double laBase, double laAltura)
        {
            double resultado = (laBase * laAltura) / 2;

            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado = Math.PI * Math.Pow(radio, 2);

            return resultado;
        }
    }
}
