using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Caja
    {
        List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string cliente in this.filaClientes)
            {
                Console.WriteLine("{0} - {1}", cliente, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }
    }
}
