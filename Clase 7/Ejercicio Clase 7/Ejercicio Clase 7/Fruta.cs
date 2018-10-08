using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_7
{
    public class Fruta
    {
        public float _peso;
        public int _volumen;

        public Fruta()
        {
            Random rand = new Random();
            this._peso = (float)rand.NextDouble() * 4 + 1;
            this._volumen = rand.Next(10) + 1;
        }

        // Crear un constructor por defecto que de valores aleatorios a ambos atributos. 
        // Peso será un valor entre 1 y 5, volumen entre 1 y 10.
    }
}
