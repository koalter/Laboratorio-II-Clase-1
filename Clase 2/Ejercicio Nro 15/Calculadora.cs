using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    public class Calculadora
    {
        /// <summary>
        /// Calcula dos números ingresados por parámetro y su operación.
        /// </summary>
        /// <param name="primerNumero">Primer operando.</param>
        /// <param name="segundoNumero">Segundo operando.</param>
        /// <param name="operacion">Tipo de operación.</param>
        /// <returns>Devuelve el resultado.</returns>
        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if (Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero!");
                    }
                    break;
                default:
                    Console.WriteLine("No es una operación válida!");
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el segundo operando para la división sea correcta (distinta de cero).
        /// </summary>
        /// <param name="segundoOperando">Es el número a analizar.</param>
        /// <returns>Devuelve un valor booleano en base al numero ingresado.</returns>
        private static bool Validar(double segundoOperando)
        {
            bool esDistintoACero;
            if (segundoOperando != 0)
            {
                esDistintoACero = true;
            }
            else
            {
                esDistintoACero = false;
            }

            return esDistintoACero;
        }
    }
}
