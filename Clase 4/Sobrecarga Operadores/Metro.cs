using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores
{
    public class Metro
    {
        public double valor;

        public Metro(double _valor)
        {
            this.valor = _valor;
        }
        
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="metro">Primer operando en metros.</param>
        /// <param name="centimetro">Segundo operando en centimetros.</param>
        /// <returns></returns>
        public static Metro operator +(Metro metro, Centimetro centimetro)
        {
            metro.valor += centimetro.valor / 100;
            return metro;
        }
    }
}
