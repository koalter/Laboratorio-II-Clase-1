using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 472;
            Console.WriteLine("Decimal ({0}) a binario: \n{1}", numero, Conversor.DecimalBinario(numero));

            string binario = "11101";
            Console.WriteLine("Binario ({0}) a decimal: \n{1}", binario, Conversor.BinarioDecimal(binario));


            Console.ReadKey();
        }
    }
}
