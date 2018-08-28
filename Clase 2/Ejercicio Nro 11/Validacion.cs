using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    public class Validacion
    {
        /// <summary>
        /// Valida el dato ingresado.
        /// </summary>
        /// <param name="valor">Es el valor ingresado</param>
        /// <param name="min">Es el valor mínimo permitido</param>
        /// <param name="max">Es el valor máximo permitido</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno;

            if (valor >= min && valor <= max)
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
