using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 10;
            int min = 0;
            int max = 0;
            int numero;
            int total = 0;
            double promedio;
            string auxiliarNumero;
            bool numeroValido;

            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.Write("Ingrese un numero ({0}/{1}): ", i + 1, length);
                    auxiliarNumero = Console.ReadLine();
                    if (int.TryParse(auxiliarNumero, out numero))
                    {
                        numero = Convert.ToInt32(auxiliarNumero);
                        numeroValido = Validacion.Validar(numero, -100, 100);
                    }
                    else
                    {
                        numeroValido = false;
                    }

                }while (numeroValido == false);

                if (i == 0)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    if (numero > max)
                    {
                        max = numero;
                    }
                }

                total += numero;
            }

            promedio = total / length;

            Console.WriteLine("El numero minimo es: {0}", min);
            Console.WriteLine("El numero maximo es: {0}", max);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
