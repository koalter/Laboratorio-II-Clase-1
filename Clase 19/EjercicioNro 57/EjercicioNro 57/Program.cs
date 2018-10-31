using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjercicioNro_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona yo = new Persona("Lorenzo", "Cea");
            Persona.Guardar(yo);
            
            Persona otro = Persona.Leer("Persona.bin");
            Console.WriteLine(otro.ToString());
            
            Console.ReadKey();
        }
    }
}
