using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado = 4;
            Console.WriteLine("Area Cuadrado ({0} cm): {1} cm2", lado, CalculoDeArea.CalcularCuadrado(lado));

            int laBase = 3;
            int laAltura = 4;
            Console.WriteLine("Area Triangulo ({0} * {1}): {2} cm2", laBase, laAltura, CalculoDeArea.CalcularTriangulo(laBase, laAltura));

            int radio = 6;
            Console.WriteLine("Area Circulo (R: {0}): {1:#.00} cm2", radio, CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey();
        }
    }
}
