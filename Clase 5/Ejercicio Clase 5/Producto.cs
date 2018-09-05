using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
    class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        /// <summary>
        /// Método constructor.
        /// </summary>
        /// <param name="_marca">Atributo marca: string</param>
        /// <param name="_codigo">Atributo codigoDeBarra: string</param>
        /// <param name="_precio">Atributo precio: float</param>
        public Producto(string _marca, string _codigo, float _precio)
        {
            this.codigoDeBarra = _codigo;
            this.marca = _marca;
            this.precio = _precio;
        }

        // Getters
        /// <summary>
        /// Devuelve la marca del producto.
        /// </summary>
        /// <returns>Devuelve la marca del producto.</returns>
        public string GetMarca()
        {
            return this.marca;
        }
        /// <summary>
        /// Devuelve el precio del producto.
        /// </summary>
        /// <returns>Devuelve el precio del producto.</returns>
        public float GetPrecio()
        {
            return this.precio;
        }
        // END Getters

        /// <summary>
        /// Muestra el producto pasado por parámetro.
        /// </summary>
        /// <param name="p">Producto.</param>
        /// <returns>Devuelve una cadena con los detalles del producto.</returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder detalles = new StringBuilder();
            detalles.AppendFormat("Marca: {0}\n", p.GetMarca());
            detalles.AppendFormat("Precio: {0}\n", p.GetPrecio());
            detalles.AppendFormat("Código: {0}\n", (string)p);
            return detalles.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.GetMarca() == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
