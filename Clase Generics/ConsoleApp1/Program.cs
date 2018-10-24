using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_Generics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancio los torneos y equipos
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de Futbol");
            EquipoFutbol boca = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol river = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol racing = new EquipoFutbol("Racing", DateTime.Now);
            EquipoBasquet bocaBasquet = new EquipoBasquet("BocaB", DateTime.Now);
            EquipoBasquet riverBasquet = new EquipoBasquet("RiverB", DateTime.Now);
            EquipoBasquet racingBasquet = new EquipoBasquet("RacingB", DateTime.Now);
            // Agrego los equipos a los torneos permitidos (verificando tambien que no se puedan duplicar)
            torneoBasquet += bocaBasquet;
            torneoBasquet += riverBasquet;
            torneoBasquet += racingBasquet;
            torneoBasquet += bocaBasquet;
            torneoBasquet += bocaBasquet;
            torneoFutbol += boca;
            torneoFutbol += river;
            torneoFutbol += racing;
            // Muestro los equipos anotados a cada torneo
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            // Se juegan 3 partidos de cada torneo y se muestran sus resultados
            Console.WriteLine("PARTIDOS JUGADOS");
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine(torneoBasquet.JugarPartido());

            Console.ReadKey();
        }
    }
}
