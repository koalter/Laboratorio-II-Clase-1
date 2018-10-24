using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public class Llamada
    {
        // Campos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        // end Campos

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos del objeto de tipo Llamada.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("Numero de Origen: " + this.nroOrigen);
            sb.AppendLine("Numero de Destino: " + this.nroDestino);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else
            {
                if (llamada1.duracion < llamada2.duracion)
                {
                    retorno = -1;
                }
                else
                {
                    retorno = 0;
                }
            }

            return retorno;
        }
        #endregion
    }
}
