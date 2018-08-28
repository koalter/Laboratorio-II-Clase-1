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
            const int min = -100;
            const int max = 100;
            const int length = 10;
            int[] numero = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Ingrese un numero ({0}/{1})", i+1, length);
                if (int.TryParse(Console.ReadLine(), out numero[i]))
                {
                    if (Validacion.Validar(numero[i], min, max))
                    {

                    }
                }
            }
        }
    }
}
