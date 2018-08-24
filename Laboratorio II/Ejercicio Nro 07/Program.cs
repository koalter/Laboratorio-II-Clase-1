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
                int fNacEnDias = fechaNacimiento.Day + DiasPorMeses(fechaNacimiento.Month) + (fechaNacimiento.Year * 365) + Bisiestos(fechaNacimiento.Year);
                DateTime fechaActual = DateTime.Now;
                int fActEnDias = fechaActual.Day + DiasPorMeses(fechaActual.Month) + (fechaActual.Year * 365) + Bisiestos(fechaActual.Year);
                int diasVividos = fActEnDias - fNacEnDias;
                Console.WriteLine("\nDias vividos: {0}", diasVividos);
                Console.WriteLine("\nEdad estimada: {0}", diasVividos / 365);
            }

            Console.ReadKey();
        }

        static int Bisiestos(int year)
        {
            int retorno = 0;

            for (float i = 1; i <= year; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            retorno++;
                        }
                    }
                    else
                    {
                        retorno++;
                    }
                }
            }

            return retorno;
        }

        static int DiasPorMeses(int month)
        {
            int retorno = 0;
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < month; i++)
            {
                retorno += meses[i];
            }

            return retorno;
        }
    }
}
