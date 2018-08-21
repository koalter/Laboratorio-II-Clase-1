using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectos = 0;
            int suma = 0;

            Console.WriteLine("Estos son los primeros cuatro numeros perfectos:");

            for (int i = 6; numerosPerfectos < 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        suma += j;
                    }
                }
                if (suma == i)
                {
                    numerosPerfectos++;
                    Console.Write("{0}; ", i);
                }
                suma = 0;
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
