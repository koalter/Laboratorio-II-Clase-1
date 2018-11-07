using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace EjercicioNro64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio miNegocio = new Negocio(caja1, caja2);
            string[] cliente = new string[10];
            for (int i = 0; i < 10; i++)
            {
                cliente[i] = "Cliente" + i;
                miNegocio.Clientes.Add(cliente[i]);
            }

            Thread tAsignarCaja = new Thread(miNegocio.AsignarCaja);
            Thread tAtender1 = new Thread(miNegocio.Caja1.AtenderClientes);
            tAtender1.Name = "Caja 1";
            Thread tAtender2 = new Thread(miNegocio.Caja2.AtenderClientes);
            tAtender2.Name = "Caja 2";
            tAsignarCaja.Start();
            tAsignarCaja.Join();
            tAtender1.Start();
            tAtender2.Start();

            Console.ReadKey();
        }
    }
}
