using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase_Generics
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE DEL TORNEO: " + this.nombre.ToUpper());
            foreach (T equipo in this.equipos)
            {
                // Aca van los datos de cada equipo
                sb.AppendLine(equipo.Ficha());
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            string resultado1 = random.Next(10).ToString();
            Thread.Sleep(10);
            string resultado2 = random.Next(10).ToString();

            return String.Format("{0} {1} - {2} {3}", equipo1.nombre, resultado1, resultado2, equipo2.nombre);
        }

        public string JugarPartido()
        {
            Random random = new Random();
            int length = this.equipos.Count;
            T equipo1;
            T equipo2;
            do
            {
                equipo1 = this.equipos[random.Next(length)];
                Thread.Sleep(10);
                equipo2 = this.equipos[random.Next(length)];
            } while (equipo1 == equipo2);
            return this.CalcularPartido(equipo1, equipo2);
        }

        #region Operadores
        public static bool operator ==(Torneo<T> lista, T equipo)
        {
            return lista.equipos.Contains(equipo);
        }
        public static bool operator !=(Torneo<T> lista, T equipo)
        {
            return !(lista == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> lista, T equipo)
        {
            if (lista != equipo)
            {
                lista.equipos.Add(equipo);
            }
            return lista;
        }
        #endregion
    }
}
