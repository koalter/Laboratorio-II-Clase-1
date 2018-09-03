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
        
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno;
            dibujo = "*";
            if (this.tinta >= gasto)
            {
                this.tinta -= (short)gasto;
                for (int i = 0; i < gasto; i++)
                {
                    Console.Write(dibujo);
                }
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public void Recargar()
        {
            short tintaQueFalta = (short)(cantidadTintaMaxima - this.tinta);

            SetTinta(tintaQueFalta);
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
    }
}
