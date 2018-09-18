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
            //double numero = 472.17;
            //Console.WriteLine("Decimal ({0}) a binario: \n{1}", numero, Conversor.DecimalBinario(numero));

            //string binario = "11101,00101";
            //Console.WriteLine("Binario ({0}) a decimal: \n{1}", binario, Conversor.BinarioDecimal(binario));
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            Console.WriteLine("{0}(b) + {1}(d) = {2}(b)", (string)objBinario, (double)objDecimal, objBinario + objDecimal);
            Console.WriteLine("{0}(b) + {1}(d) = {2}(d)", (string)objBinario, (double)objDecimal, objDecimal + objBinario);
            Console.WriteLine("{0}(b) y {1}(d) son iguales? {2}", (string)objBinario, (double)objDecimal, objDecimal == objBinario);

            Console.ReadKey();
        }
    }
}
