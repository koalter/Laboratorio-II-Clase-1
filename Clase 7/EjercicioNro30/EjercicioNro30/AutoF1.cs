using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro30
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        #region Getters y setters
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public short GetVueltasRestastes()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }
        #endregion

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero: " + this.numero);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Cantidad de combustible: " + this.GetCantidadCombustible());
            sb.AppendLine("------------------------------");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
