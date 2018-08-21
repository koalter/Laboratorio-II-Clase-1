using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esPrimo = true;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Numeros primos encontrados:");
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    esPrimo = true;
                }
            }

            Console.ReadKey();
        }
    }
}
