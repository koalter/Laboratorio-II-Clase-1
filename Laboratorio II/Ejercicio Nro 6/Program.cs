using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            bool esNumero = int.TryParse(Console.ReadLine(), out numero);

            if (esNumero)
            {
                if (numero % 4 == 0)
                {
                    if (numero % 100 == 0)
                    {
                        if (numero % 400 == 0)
                        {
                            Console.WriteLine("\nEs bisiesto!");
                        }
                        else
                        {
                            Console.WriteLine("\nNo es bisiesto!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEs bisiesto!");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo es bisiesto!");
                }
            }

            Console.ReadKey();
        }
    }
}
