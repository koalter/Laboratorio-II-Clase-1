using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Clase de ejemplo para autos.
    /// </summary>
    public class Automovil
    {
        // Atributos NO estaticos
        public Single velocidadActual;
        // Atributos estaticos
        public static Byte cantidadRuedas;

        // Metodos estaticos
        /// <summary>
        /// Imprime por pantalla la cantidad de ruedas.
        /// </summary>
        public static void MostrarCantidadRuedas()
        {
            Console.WriteLine(Automovil.cantidadRuedas);
        }
        // Metodos NO estaticos
        /// <summary>
        /// Incrementa la velocidad actual del vehículo
        /// </summary>
        /// <param name="velocidad">La velocidad aumenta por el valor ingresado</param>
        public void Acelerar(Single velocidad)
        {
            this.velocidadActual += velocidad;
        }
    }
}
