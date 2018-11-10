using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia torneo = new Competencia(8, 4);
            Console.WriteLine(torneo.MostrarDatos());
            AutoF1 a1 = new AutoF1(10, "Ferrari");
            if (torneo + a1)
            {
                Console.WriteLine(a1.MostrarDatos());
            }
            AutoF1 a2 = new AutoF1(7, "Audi");
            if (torneo + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }
            AutoF1 a3 = new AutoF1(7, "Audi");
            if (torneo + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }
            AutoF1 a4 = new AutoF1(4, "McLaren");
            if (torneo + a4)
            {
                Console.WriteLine(a4.MostrarDatos());
            }
            AutoF1 a5 = new AutoF1(12, "Audi");
            if (torneo + a5)
            {
                Console.WriteLine(a5.MostrarDatos());
            }
            AutoF1 a6 = new AutoF1(5, "Ferrari");
            if (torneo + a6)
            {
                Console.WriteLine(a6.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
