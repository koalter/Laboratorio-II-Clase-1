using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        void SetTinta(short tinta)
        {
            short auxiliar = this.tinta;

            auxiliar += tinta;

            if (auxiliar >= 0 && auxiliar <= cantidadTintaMaxima)
            {
                this.tinta = auxiliar;
            }
        }

        public bool Pintar(int gasto, string dibujo)
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine(dibujo);
            return true;
        }

        public void Recargar()
        {
            short tintaQueFalta = (short)(cantidadTintaMaxima - this.tinta);

            this.SetTinta(tintaQueFalta);
        }

        
    }
}
