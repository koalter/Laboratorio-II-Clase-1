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
        /// Convierte un número decimal a binario.
        /// </summary>
        /// <param name="numero">Toma el número en formato decimal y lo convierte.</param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            const int precision = 9;
            int numeroEntero = (int)numero;
            double numeroConComa = numero - numeroEntero;
            string parteDecimal = "";
            string parteEntera = "";
            string retorno = "";

            // Procedimiento para convertir la parte entera
            int i;
            for (i = 0; numeroEntero > 1; i++)
            {
                parteEntera += (numeroEntero % 2).ToString();
                numeroEntero /= 2;
            }
            parteEntera += numeroEntero.ToString();

            for (int j = i; j >= 0; j--)
            {
                retorno += parteEntera[j];
            }

            // Procedimiento para convertir la parte decimal.
            if (numeroConComa != 0)
            {
                for (int k = 0; k < precision &&numeroConComa != 0; k++)
                {
                    numeroConComa *= 2;
                    parteDecimal += ((int)numeroConComa).ToString();
                    numeroConComa -= (int)numeroConComa;
                }
                retorno += "," + parteDecimal.TrimEnd('0');
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="cadena">El número a convertir debe ser ingresado con , y no con .</param>
        /// <returns></returns>
        public static double BinarioDecimal(string cadena)
        {
            string strAuxiliar = cadena;
            long intAuxiliar;
            double numero = 0;

            cadena = cadena.Replace('.', ',');

            if (double.TryParse(cadena, out numero) == true)
            {
                // Corro las comas.
                int cantidadDeComas;
                for (cantidadDeComas = 0; long.TryParse(strAuxiliar, out intAuxiliar) == false; cantidadDeComas++)
                {
                    numero *= 10;
                    strAuxiliar = numero.ToString();
                }

                int length = strAuxiliar.Length;
                int digito;
                numero = 0;

                for (int i = 1; i <= length; i++)
                {
                    // El parámetro del Convert me asegura que se convierta desde el bit menos significativo
                    // al bit más significativo.
                    // 49 es el ascii de 1, 48 es el ascii de 0.
                    digito = Convert.ToInt32(strAuxiliar[length - i]) - 48;
                    numero += digito * Convert.ToDouble((Math.Pow(2, (i - 1) - cantidadDeComas)));
                }
            }

            return numero;
        }
    }
}
