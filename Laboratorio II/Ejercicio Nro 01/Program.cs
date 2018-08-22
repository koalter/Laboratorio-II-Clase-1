using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esNumero;
            const int length = 5;
            int maximo = 0;
            int minimo = 0;
            int total = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
                if (esNumero)
                {
                    if (i == 0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    else
                    {
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                        else if (numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                    total = total + numero;
                }
                
            }
            
            promedio = total / length;

            Console.WriteLine("");

            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
