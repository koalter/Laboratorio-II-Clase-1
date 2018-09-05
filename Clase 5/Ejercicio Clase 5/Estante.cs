using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
    class Estante
    {
        int ubicacionEstante;
        Producto[] productos;

        // Constructores
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        // END Constructores

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestra la información del estante consultado.
        /// </summary>
        /// <param name="e">Nombre del estante.</param>
        /// <returns>Devuelve una cadena con toda la información.</returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder estante = new StringBuilder();
            int length = e.GetProductos().Length;
            estante.AppendFormat("Estante nº {0}:\n", e.ubicacionEstante);
            estante.AppendFormat("Cantidad de productos: {0}\n", length);
            
            for (int i = 0; i < length; i++)
            {
                estante.AppendFormat("{0}---------------\n", i+1);
                Producto.MostrarProducto(e.GetProductos()[i]);
            }
            return estante.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            int length = e.GetProductos().Length;
            bool igualdad = false;
            for (int i = 0; i < length; i++)
            {
                if (e.GetProductos()[i] == p)
                {
                    igualdad = true;
                    break;
                }
            }
            return igualdad;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            int length = e.GetProductos().Length;
            int i;
            bool hayCapacidad = false;
            for (i = 0; i < length; i++)
            {
                // ARREGLAR ESTO, (string)e.GetProductos()[i] NO PUEDE SER NULL DESDE UN PRINCIPIO
                if ((string)e.GetProductos()[i] == null)
                {
                    hayCapacidad = true;
                    break;
                }
            }
            if (hayCapacidad && e != p)
            {
                e.GetProductos()[i] = p;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                int length = e.GetProductos().Length;
                for (int i = 0; i < length; i++)
                {
                    if (e.GetProductos()[i] == p)
                    {
                        e.GetProductos()[i] = null;
                    }
                }
            }
            return e;
        }
    }

    class TestEstante
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);
            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)10.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)10.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)10.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.5);
            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.ReadKey();
        }
    }
}
