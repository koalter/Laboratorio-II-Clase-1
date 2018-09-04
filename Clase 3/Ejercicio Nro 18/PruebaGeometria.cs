using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Rectangulo prueba = new Rectangulo(new Punto(4, 10), new Punto(9, 3));

            Console.WriteLine("Área del rectangulo: {0}", prueba.Area());
            Console.WriteLine("Perímetro del rectangulo: {0}", prueba.Perimetro());
            Console.ReadKey();
        }
    }
}
