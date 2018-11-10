using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro30
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);

            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                Random rand = new Random();
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)rand.Next(15, 101));
                System.Threading.Thread.Sleep(20);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
