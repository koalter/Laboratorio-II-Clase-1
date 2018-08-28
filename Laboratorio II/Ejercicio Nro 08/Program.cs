using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_08
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cantidadEmpleados = 1;
            int[] valorHora = new int[cantidadEmpleados];
            string[] nombre = new string[cantidadEmpleados];
            int[] antiguedad = new int[cantidadEmpleados];
            int[] horasTrabajadas = new int[cantidadEmpleados];

            int[] importeACobrar = new int[cantidadEmpleados];
            int[] importeAntiguedad = new int[cantidadEmpleados];
            int[] subtotal = new int[cantidadEmpleados];
            double[] descuento = new double[cantidadEmpleados];
            double[] total = new double[cantidadEmpleados];

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("Ingrese el valor hora: ");
                valorHora[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el nombre del empleado: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Ingrese la antiguedad (en años): ");
                antiguedad[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese horas trabajadas en el mes: ");
                horasTrabajadas[i] = Convert.ToInt32(Console.ReadLine());

                importeACobrar[i] = valorHora[i] * horasTrabajadas[i];
                importeAntiguedad[i] = antiguedad[i] * 150;
                subtotal[i] = importeACobrar[i] + importeAntiguedad[i];
                descuento[i] = subtotal[i] * 0.13;
                total[i] = subtotal[i] - descuento[i];
            }

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("****************************** \n");
                Console.WriteLine("Nombre: {0}", nombre[i]);
                Console.WriteLine("Años de antiguedad: {0}", antiguedad[i]);
                Console.WriteLine("Valor hora de trabajo: $ {0}", valorHora[i]);
                Console.WriteLine("Sueldo bruto: $ {0}", subtotal[i]);
                Console.WriteLine("Descuento: $ {0}", descuento[i]);
                Console.WriteLine("Sueldo neto: $ {0}", total[i]);
                Console.WriteLine("\n******************************");
            }

            Console.ReadKey();
        }
    }
}
