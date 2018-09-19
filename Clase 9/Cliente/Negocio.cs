using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool noExiste = true;
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    noExiste = false;
                }
            }
            if (noExiste)
            {
                n.clientes.Enqueue(c);
            }

            return noExiste;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
    }
}
