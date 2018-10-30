using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numeros = new List<int>();
            int auxiliar;

            Console.WriteLine("a. Mostrar el vector tal como fue ingresado");
            for (int i = 0; i < 20; i++)
            {
                auxiliar = random.Next(100);
                if (random.Next(2) == 1)
                {
                    auxiliar *= (-1);
                }
                numeros.Add(auxiliar);
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("b. Luego mostrar los positivos ordenados en forma decreciente.");
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] >= 0)
                {
                    for (int j = i+1; j < numeros.Count; j++)
                    {
                        if (numeros[i] >= 0 && numeros[j] > numeros[i])
                        {
                            auxiliar = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = auxiliar;
                        }
                    }
                }
            }

            foreach (var item in numeros)
            {
                if (item >= 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("c. Por último, mostrar los negativos ordenados en forma creciente.");
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < 0)
                {
                    for (int j = i + 1; j < numeros.Count; j++)
                    {
                        if (numeros[i] < 0 && numeros[j] > numeros[i])
                        {
                            auxiliar = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = auxiliar;
                        }
                    }
                }
            }

            foreach (var item in numeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
