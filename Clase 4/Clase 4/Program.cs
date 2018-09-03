using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Sobrecarga objeto = new Sobrecarga();
            Sobrecarga centimetro = new Sobrecarga("Centimetro", 10, 4);

            Console.WriteLine("en metros -- {0}", objeto.Sumar(10,4));
            Console.ReadKey();
        }
    }
}
