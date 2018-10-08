using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajon cajon = new Cajon(100);
            Fruta a = new Fruta();
            Fruta b = new Fruta();
            Fruta c = new Fruta();
            Fruta d = new Fruta();
            Fruta e = new Fruta();
            // estaria bueno agregarle un delay por cada declaracion de Fruta
            string opcion;

            cajon.AgregarFruta(a);
            cajon.AgregarFruta(b);
            cajon.AgregarFruta(c);
            cajon.AgregarFruta(d);
            cajon.AgregarFruta(e);

            do
            {
                Console.WriteLine(cajon.MostrarContenido());
                Console.WriteLine("Escoja la accion:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Quitar");
                Console.WriteLine("9. Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        cajon.AgregarFruta(new Fruta());
                        break;
                    case "2":
                        cajon.QuitarFruta();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcion != "9");
        }
    }
}
