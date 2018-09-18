using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_Nro_20
{
    class Program
    {
        /// <summary>
        /// Conversor de Monedas.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Pesos pesos = 17.55;
            Dolar dolar = 10;
            Euro euro = 7;
            // Los numeros ingresados se convierten IMPLICITAMENTE

            //dolar = (Dolar)pesos; // convierto los pesos en su valor dolar EXPLICITAMENTE
            
            Console.WriteLine("Tengo {0} Dolares", dolar.GetCantidad());
            Console.WriteLine("Que en pesos son: {0}", ((Pesos)dolar).GetCantidad());

            Console.WriteLine("Si sumo {0} Pesos y {1} Dolares tengo {2} Pesos", pesos.GetCantidad(), dolar.GetCantidad(), (pesos+dolar).GetCantidad());

            Console.ReadKey();
        }
    }
}
