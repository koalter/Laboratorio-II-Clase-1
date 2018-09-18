using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class NumeroDecimal
    {
        double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(NumeroDecimal dec, NumeroBinario bin)
        {
            return (double)dec + Conversor.BinarioDecimal((string)bin);
        }
        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            return (double)dec - Conversor.BinarioDecimal((string)bin);
        }
        public static bool operator ==(NumeroDecimal dec, NumeroBinario bin)
        {
            return Conversor.DecimalBinario((double)dec) == (string)bin;
        }
        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(dec == bin);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator double(NumeroDecimal objeto)
        {
            return objeto.numero;
        }
    }
}
