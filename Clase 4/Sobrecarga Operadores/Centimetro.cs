using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores
{
    public class Centimetro
    {
        public double valor;

        public Centimetro(double _valor)
        {
            this.valor = _valor;
        }

        public static Centimetro operator +(Centimetro centimetro, Metro metro)
        {
            centimetro.valor += metro.valor * 100;
            return centimetro;
        }

        public static bool operator ==(Centimetro centimetro, Metro metro)
        {
            return centimetro.valor == metro.valor * 100;

        }

        public static bool operator !=(Centimetro centimetro, Metro metro)
        {
            return !(centimetro.valor == metro.valor * 100);
        }
    }
}
