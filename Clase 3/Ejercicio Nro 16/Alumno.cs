using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string _nombre, string _apellido, int _legajo)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.legajo = _legajo;
        }

        /// <summary>
        /// Coloca la nota del examen final sólo si las notas uno y dos son mayores o iguales a 4. Caso contrario, es -1.
        /// </summary>
        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random numero = new Random();
                this._notaFinal = numero.Next(1, 10);
                //Esta linea agrega una pausa a la ejecucion, necesario para que el random nos de otro numero.
                System.Threading.Thread.Sleep(100);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder log = new StringBuilder();
            log.AppendFormat("Apellido: {0}\n", this.apellido);
            log.AppendFormat("Nombre: {0}\n", this.nombre);
            log.AppendFormat("Legajo: {0}\n", this.legajo);
            log.AppendFormat("Nota Primer Parcial: {0}\n", this._nota1);
            log.AppendFormat("Nota Segundo Parcial: {0}\n", this._nota2);
            if (this._notaFinal != -1)
            {
                log.AppendFormat("Nota Final: {0}\n", this._notaFinal);
            }
            else
            {
                log.AppendLine("Alumno desaprobado!");
            }

            return log.ToString();
        }
    }
}
