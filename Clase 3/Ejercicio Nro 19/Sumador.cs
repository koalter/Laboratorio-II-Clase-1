using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_19
{
    public class Sumador
    {
        int cantidadSumas;

        /// <summary>
        /// Inicializa el objeto por el valor del parámetro.
        /// </summary>
        /// <param name="a">Parámetro entero.</param>
        public Sumador(int a)
        {
            this.cantidadSumas = a;
        }
        /// <summary>
        /// Inicializa el objeto en 0.
        /// </summary>
        public Sumador() : this(0) { }

        public long Sumar(long numeroUno, long numeroDos)
        {
            this.cantidadSumas++;

            return numeroUno + numeroDos;
        }

        public string Sumar(string cadenaUno, string cadenaDos)
        {
            this.cantidadSumas++;

            return cadenaUno + cadenaDos;
        }

        /// <summary>
        /// Conversión explícita del objeto llamado para obtener la cantidad de sumas.
        /// </summary>
        /// <param name="s">Objeto a convertir.</param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga la operación suma, reutilizando el código de sobrecarga del operador int.
        /// </summary>
        /// <param name="obj1">Primer objeto Sumador.</param>
        /// <param name="obj2">Segundo objeto Sumador.</param>
        /// <returns>Devuelve la suma de las 'cantidades de sumas' de los dos objetos.</returns>
        public static long operator +(Sumador obj1, Sumador obj2)
        {
            return (int)obj1 + (int)obj2;
        }

        /// <summary>
        /// Compara los dos objetos para verificar si sus cantidades de sumas son iguales.
        /// </summary>
        /// <param name="obj1">Primer objeto Sumador.</param>
        /// <param name="obj2">Segundo objeto Sumador.</param>
        /// <returns>True si tienen la misma cantidad, en su defecto False.</returns>
        public static bool operator |(Sumador obj1, Sumador obj2)
        {
            bool retorno;
            if ((int)obj1 == (int)obj2)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
