using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjercicioNro67
{
    public sealed class Temporizador
    {
        Thread hilo;
        int intervalo;

        public delegate void encargadoTiempo();

        #region Propiedades
        public bool Activo
        {
            get;
            set;
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        #endregion
        #region Metodos
        private void Corriendo()
        {

        }
        #endregion
        #region Eventos
        public event encargadoTiempo EventoTiempo;
        #endregion
    }
}
