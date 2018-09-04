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
        /// <returns>Medida en metros.</returns>
        public static Metro operator +(Metro metro, Metro metroDos)
        {
            metro.valor += metroDos.valor;
            return metro;
        }

        /// <summary>
        /// Sobrecarga del operador igual (==)
        /// </summary>
        /// <param name="metro"></param>
        /// <param name="centimetro"></param>
        /// <returns></returns>
        public static bool operator ==(Metro metro, Centimetro centimetro)
        {
            return metro.valor == centimetro.valor / 100;
            
        }

        public static bool operator !=(Metro metro, Centimetro centimetro)
        {
            return !(metro.valor == centimetro.valor / 100);
        }

        public static explicit operator Metro(Centimetro centimetro)
        {
            return new Metro(centimetro.valor / 100);
        }

        public static implicit operator Centimetro(Metro metro)
        {
            return new Centimetro(metro.valor * 100);
        }
    }
}
