using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro26
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 20;
            Random random = new Random();
            int[] numeros = new int[length];
            int auxiliar;

            Console.WriteLine("a. Mostrar el vector tal como fue ingresado");
            for (int i = 0; i < length; i++)
            {
                numeros[i] = random.Next(100);
                if (random.Next(2) == 1)
                {
                    numeros[i] = -numeros[i];
                }
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("b. Luego mostrar los positivos ordenados en forma decreciente.");
            for (int i = 0; i < length; i++)
            {
                if (numeros[i] >= 0)
                {
                    for (int j = i+1; j < length; j++)
                    {
                        if (numeros[j] >= 0 && numeros[j] > numeros[i])
                        {
                            auxiliar = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = auxiliar;
                        }
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (numeros[i] >= 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("c. Por último, mostrar los negativos ordenados en forma creciente.");
            for (int i = 0; i < length; i++)
            {
                if (numeros[i] < 0)
                {
                    for (int j = i+1; j < length; j++)
                    {
                        if (numeros[j] < 0 && numeros[j] > numeros[i])
                        {
                            auxiliar = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = auxiliar;
                        }
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
