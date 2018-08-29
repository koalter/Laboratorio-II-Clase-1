using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno("Lorenzo", "Cea", 393102);
            Alumno alumnoDos = new Alumno("Nahuel", "Ko", 391731);
            Alumno alumnoTres = new Alumno("Eliana", "Son", 399231);

            alumnoUno.Estudiar(4, 6);
            alumnoDos.Estudiar(2, 6);
            alumnoTres.Estudiar(4, 8);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());

            Console.ReadKey();
        }
    }
}
