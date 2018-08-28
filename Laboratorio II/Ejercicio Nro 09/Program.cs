using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.Write("Ingrese la altura en lineas para la pirámide: ");
            if (int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine();
                for (int i = 0; i < altura; i++)
                {
                    for (int j = 0; j < 1 + i*2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();
        }
    }
}
