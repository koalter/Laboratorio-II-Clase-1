using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int primerGrupo = 0;
            int segundoGrupo = 0;

            Console.Write("Ingrese un numero: ");
            bool esNumero = int.TryParse(Console.ReadLine(), out numero);

            if (esNumero)
            {
                Console.WriteLine("\nSe encontraron los siguientes centros numericos:");
                for (int pivote = 1; pivote <= numero; pivote++)
                {
                    for (int j = 1; j < pivote; j++)
                    {
                        primerGrupo += j;
                    }
                    for (int i = pivote + 1; segundoGrupo <= primerGrupo; i++)
                    {
                        segundoGrupo += i;
                        if (segundoGrupo == primerGrupo)
                        {
                            Console.Write("{0}; ", pivote);
                        }
                    }
                    primerGrupo = 0;
                    segundoGrupo = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
