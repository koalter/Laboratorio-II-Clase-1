using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de sobrecarga de operador +
            Console.WriteLine((new Metro(5) + new Centimetro(800)).valor);

            // Ejemplo de sobrecarga de los operadores == y !=
            Console.WriteLine(new Metro(5) == new Centimetro(500));

            // Operadores de conversion
            Metro metro = new Metro(5);
            Centimetro centimetro = new Centimetro(800);
            Centimetro resultadoCen = centimetro + metro;
            Console.WriteLine(metro.valor);

            Console.ReadKey();
        }
    }
}
