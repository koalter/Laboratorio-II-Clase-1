using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class NumeroBinario
    {
        string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            // Los sumo en forma decimal
            double retorno = Conversor.BinarioDecimal((string)bin) + (double)dec;
            // Lo paso a binario
            return Conversor.DecimalBinario(retorno);

        }
        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            return bin + ((double)dec * (-1));
        }
        public static bool operator ==(NumeroBinario bin, NumeroDecimal dec)
        {
            return Conversor.BinarioDecimal((string)bin) == (double)dec;
        }
        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static explicit operator string(NumeroBinario objeto)
        {
            return objeto.numero.ToString();
        }
    }
}
