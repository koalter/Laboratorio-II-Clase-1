using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string auxiliarNumero;
            int suma = 0;
            bool continuar;
            char tecla;

            do
            {
                Console.Write("Ingrese un numero: ");
                auxiliarNumero = Console.ReadLine();
                while (int.TryParse(auxiliarNumero, out numero) == false)
                {
                    Console.Write("Ingrese un numero: ");
                    auxiliarNumero = Console.ReadLine();
                }
                numero = Convert.ToInt32(auxiliarNumero);

                suma += numero;

                Console.Write("\nDesea continuar: ");
                tecla = (char)Console.Read();
                continuar = ValidarRespuesta.ValidaS_N(tecla);
            } while (continuar == true);

            Console.WriteLine("La suma de todos los numeros ingresados es: {0}", suma);

            Console.ReadKey();
        }
    }
}
