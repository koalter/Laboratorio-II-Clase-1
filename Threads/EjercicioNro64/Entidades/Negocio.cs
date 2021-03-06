﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Negocio
    {
        Caja caja1;
        Caja caja2;
        List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.clientes)
            {
                if (this.caja1.FilaClientes.Count <= this.caja2.FilaClientes.Count)
                {
                    this.caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    this.caja2.FilaClientes.Add(cliente);
                }

                Thread.Sleep(1000);
            }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string>();
        }
    }
}
