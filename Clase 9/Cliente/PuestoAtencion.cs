using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual + 1;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);

            return true;
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }

    public enum Puesto
    {
        Caja1,
        Caja2
    }
}
