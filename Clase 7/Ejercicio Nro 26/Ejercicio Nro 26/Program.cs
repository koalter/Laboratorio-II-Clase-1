using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numeros = new int[20];
            int signo;
            int length = numeros.Length;

            Console.WriteLine("a. Mostrar el vector tal como fue ingresado");
            for (int i = 0; i < length; i++)
            {
                numeros[i] = rand.Next() + 1;
                signo = rand.Next(2);
                if (signo == 0)
                {
                    numeros[i] *= -1;
                }
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("b. Luego mostrar los positivos ordenados en forma decreciente.");
            for (int i = 0; i < length - 1; i++)
            {
                int auxiliar;
                for (int j = i; j < length; j++)
                {
                    if (numeros[j] > numeros[i])
                    {
                        auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }
            foreach (int n in numeros)
            {
                if (n > 0)
                {
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("c. Por último, mostrar los negativos ordenados en forma creciente.");
            foreach (int n in numeros)
            {
                if (n < 0)
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadKey();
        }
    }
}
