﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);
            rojo.Pintar(18, "buenos dias");
            azul.Pintar(10, "hola mundo");
            Console.ReadKey();
        }
    }
}
