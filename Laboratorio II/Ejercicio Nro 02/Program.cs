using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            bool esNumero = int.TryParse(Console.ReadLine(), out numero);

            if (esNumero)
            {
                while (numero < 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);

                Console.WriteLine("El numero que ingreso es: {0}", numero);
                Console.WriteLine("El cuadrado del numero es: {0}", cuadrado);
                Console.WriteLine("El cubo del numero es: {0}", cubo);
            }

            Console.ReadKey();
        }
    }
}
