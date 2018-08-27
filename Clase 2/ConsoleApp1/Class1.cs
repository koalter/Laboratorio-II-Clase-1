using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MiClase : ClasePadre
    {
        // Por defecto las clases son privadas al igual que las propiedades

        public int id2;
        public static int estatico2;
    }

    public class ClasePadre
    {
        public int id;
        public static int estatico;
    }
}
