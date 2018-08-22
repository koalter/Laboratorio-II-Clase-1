using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento;
        
            Console.Write("Ingrese fecha de nacimiento (DD/MM/AAAA): ");

            if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
            {
                int diasVividos = DateTime.Now - fechaNacimiento;

                Console.WriteLine("Ha vivido {0} dias", diasVividos);
            }

            Console.ReadKey();
        }
    }
}
