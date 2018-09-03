using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    public class Sobrecarga
    {
        public string tipoNumero;

        // El metodo llama a la sobrecarga declarada por debajo usando ": this(parametro)"
        // this("Metro") -> Sobrecarga("Metro");
        public Sobrecarga() : this("Metro")
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo">Tipo de unidad métrica</param>
        public Sobrecarga(string tipo)
        {
            tipoNumero = tipo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo">Tipo de unidad métrica</param>
        /// <param name="metro">Primera medida</param>
        /// <param name="metroDos">Segunda medida</param>
        public Sobrecarga(string tipo, int metro, int metroDos) : this(tipo)
        {
            Sumar(metro, metroDos);
        }

        public float Sumar(int a, int b)
        {
            int resultado;
            if (tipoNumero == "Metro")
            {
                resultado = a + b;
            }
            else
            {
                resultado = (a + b) * 100;
            }
            return resultado;
        }
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }


    }
}
