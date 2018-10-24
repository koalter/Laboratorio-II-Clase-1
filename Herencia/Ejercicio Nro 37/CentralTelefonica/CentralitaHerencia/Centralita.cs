using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Local llamada in this.listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Provincial llamada in this.listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    break;
                case TipoLlamada.Todas:
                    ganancia = this.CalcularGanancia(TipoLlamada.Local) + this.CalcularGanancia(TipoLlamada.Provincial);
                    break;
                default:
                    break;
            }

            return ganancia;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social de la central: " + this.razonSocial);
            sb.AppendLine("Ganancias totales: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancias locales: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancias provinciales: " + this.GananciasPorProvincia);

            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            int length = this.listaDeLlamadas.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (Llamada.OrdenarPorDuracion(this.listaDeLlamadas[i], this.listaDeLlamadas[j]) == 1)
                    {
                        Llamada auxiliar = this.listaDeLlamadas[i];
                        this.listaDeLlamadas[i] = this.listaDeLlamadas[j];
                        this.listaDeLlamadas[j] = auxiliar;
                    }
                }
            }
        }
        #endregion
    }
}
