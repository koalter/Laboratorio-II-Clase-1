using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Producto
    {
        int identificador;
        string nombre;
        double precio;
        double iva;
        int cantidad;
        
        public Producto(int id, string nombre, double precio)
        {
            this.identificador = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
            
        }
        public int Identificador
        {
            get
            {
                return this.identificador;
            }
            set
            {
                this.identificador = value;
            }
        }
        public double Precio
        {
            set
            {
                this.precio = value;
                this.iva = this.precio * 21 / 100;
            }
        }

        public double Total
        {
            get
            {
                return this.precio + this.iva;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
    }
}
