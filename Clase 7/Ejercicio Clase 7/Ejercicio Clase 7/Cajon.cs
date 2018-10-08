using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_7
{
    public class Cajon
    {
        List<Fruta> _frutas;
        int _volumen;

        #region Constructores
        private Cajon()
        {
            this._frutas = new List<Fruta>();
        }
        public Cajon(int volumen) : this()
        {
            this._volumen = volumen;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Calcula el espacio disponible en el cajon.
        /// </summary>
        /// <returns></returns>
        public int CalcularEspacioDisponible()
        {
            int espacioTotal = this._volumen;
            int espaciosOcupados = 0;
            foreach (Fruta item in this._frutas)
            {
                espaciosOcupados += item._volumen;
            }

            return espacioTotal - espaciosOcupados;
        }

        /// <summary>
        /// Muestra la capacidad del cajon, el espacio ocupado y los datos de cada fruta.
        /// </summary>
        /// <returns></returns>
        public string MostrarContenido()
        {
            StringBuilder sb = new StringBuilder();
            int espaciosOcupados = 0;
            foreach (Fruta item in this._frutas)
            {
                espaciosOcupados += item._volumen;
            }
            sb.AppendLine("Volumen total ocupado: " + espaciosOcupados);
            sb.AppendLine("Volumen total: " + this._volumen);
            sb.AppendLine("-------------------------------------");
            foreach (Fruta item in this._frutas)
            {
                sb.AppendLine("Peso: " + item._peso);
                sb.AppendLine("Volumen: " + item._volumen);
                sb.AppendLine("-------------------------------------");
            }
            sb.AppendLine("");
            return sb.ToString();
        }

        /// <summary>
        /// Agregará una nueva fruta a la lista, si hay espacio.
        /// </summary>
        /// <param name="f">Elemento que se va a agregar a la lista.</param>
        /// <returns></returns>
        public bool AgregarFruta(Fruta f)
        {
            bool retorno = false;
            int espacio = CalcularEspacioDisponible();

            if (f._volumen <= espacio)
            {
                this._frutas.Add(f);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Quitará una fruta al azar.
        /// </summary>
        public void QuitarFruta()
        {
            Random rand = new Random();
            int length = this._frutas.Count();

            this._frutas.RemoveAt(rand.Next(length));
        }
        #endregion
    }
}
