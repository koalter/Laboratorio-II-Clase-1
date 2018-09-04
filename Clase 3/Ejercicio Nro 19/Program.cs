using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador cadena = new Sumador();
            Sumador enteros = new Sumador();
            Console.WriteLine("Sumas de enteros");
            Console.WriteLine("10 + 4 = {0}", enteros.Sumar(10, 4));
            Console.WriteLine("1 + 3 = {0}", enteros.Sumar(1, 3));
            Console.WriteLine("5 + 11 = {0}", enteros.Sumar(5, 11));
            Console.WriteLine("Cantidad de sumas: {0}", (int)enteros);
            Console.WriteLine("");
            Console.WriteLine("Sumas de cadenas");
            Console.WriteLine("Hola +(' ')+ Mundo = {0}", cadena.Sumar("HOLA", " MUNDO"));
            Console.WriteLine("Abre + latas = {0}", cadena.Sumar("ABRE", "LATAS"));
            Console.WriteLine("Uno + Dos = {0}", cadena.Sumar("Uno", "Dos"));
            Console.WriteLine("Cantidad de sumas: {0}", (int)cadena);
            Console.WriteLine("Hay la misma cantidad de sumas en cadena que en enteros? {0}", cadena | enteros);
            Console.ReadKey();
        }
    }
}
