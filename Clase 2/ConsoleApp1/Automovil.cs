using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Automovil
    {
        // Atributos NO estaticos
        public Single velocidadActual;
        // Atributos estaticos
        public static Byte cantidadRuedas;

        // Metodos estaticos
        public static void MostrarCantidadRuedas()
        {
            Console.WriteLine(Automovil.cantidadRuedas);
        }
        // Metodos NO estaticos
        public void Acelerar(Single velocidad)
        {
            this.velocidadActual += velocidad;
        }
    }
}
