using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo2();
            Console.ReadLine();
        }

        static void Ejemplo()
        {
            MiClase prueba = new MiClase();
            prueba.id = 7;
            Console.WriteLine("prueba.id -- {0}", prueba.id);
            MiClase prueba2 = new MiClase();
            prueba2.id = 4;
            Console.WriteLine("prueba2.id -- {0}", prueba2.id);
            Console.WriteLine("MiClase.estatico antes -- {0}", MiClase.estatico);
            MiClase.estatico = 1;
            Console.WriteLine("MiClase.estatico despues -- {0}", MiClase.estatico);
        }

        static void Ejemplo2()
        {
            Automovil auto = new Automovil();
            Automovil.cantidadRuedas = 4;
            Automovil.MostrarCantidadRuedas();
            auto.Acelerar(80);
            auto.Acelerar(35);
            Console.WriteLine("Velocidad: {0}", auto.velocidadActual);
        }
    }
}
