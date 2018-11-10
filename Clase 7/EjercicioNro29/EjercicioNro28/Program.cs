using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(5, "UTN FRA");
            Jugador j1 = new Jugador(11111111, "Lorenzo");
            if (equipo + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }
            Jugador j2 = new Jugador(22222222, "Emanuel", 8, 3);
            if (equipo + j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }
            Jugador j3 = new Jugador(22222222, "Luciano", 3, 2);
            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            Jugador j4 = new Jugador(33333333, "Agustin", 5, 4);
            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            Jugador j5 = new Jugador(44444444, "Nicolas", 4, 3);
            if (equipo + j5)
            {
                Console.WriteLine(j5.MostrarDatos());
            }
            Jugador j6 = new Jugador(55555555, "Enzo", 6, 5);
            if (equipo + j6)
            {
                Console.WriteLine(j6.MostrarDatos());
            }
            Jugador j7 = new Jugador(66666666, "Matias", 8, 3);
            if (equipo + j7)
            {
                Console.WriteLine(j7.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
