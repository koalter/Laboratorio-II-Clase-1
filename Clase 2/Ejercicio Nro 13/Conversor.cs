using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un número de decimal a binario.
        /// </summary>
        /// <param name="numero">Número a convertir</param>
        /// <returns></returns>
        public static string DecimalBinario(int numero)
        {
            string auxiliar = "";
            int i;
            for (i = 0; numero > 1; i++)
            {
                auxiliar += Convert.ToString(numero % 2);
                numero /= 2;
            }
            auxiliar += Convert.ToString(numero);

            string retorno = "";
            for (int j = i; j >= 0; j--)
            {
                retorno += auxiliar[j];
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="cadena">Cadena a convertir</param>
        /// <returns></returns>
        public static int BinarioDecimal(string cadena)
        {
            int length = cadena.Length;
            int numero = 0;
            int digito;

            for (int i = 1; i <= length; i++)
            {
                digito = Convert.ToInt32(cadena[length-i]) - 48;
                // 49 es el ascii de 1, 48 es el ascii de 0
                numero += digito * Convert.ToInt32((Math.Pow(2, i-1)));
            }

            return numero;
        }
    }
}
