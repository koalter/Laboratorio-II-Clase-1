using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Billetes;

namespace Facturas
{
    public class Factura
    {
        eTipoFactura tipo;
        int numero;
        DateTime fecha;
        eMoneda moneda;
        public List<Producto> productos;
        
        public Factura()
        {
            this.productos = new List<Producto>();
        }

        // Ejemplo de indexador
        public Producto this[int i]
        {
            get
            {
                Producto salida = null;
                foreach (Producto item in this.productos)
                {
                    if (item.Identificador == i)
                    {
                        salida = item;
                    }
                }
                return salida;
            }
            set
            {
                bool encontro = false;
                foreach (Producto item in this.productos)
                {
                    if (item.Identificador == i)
                    {
                        item.Cantidad += value.Cantidad;
                        encontro = true;
                    }
                }
                if (encontro == false)
                {
                    this.productos.Add(value);
                }
            }
        }
        // END Ejemplo

        // Propiedades
        public double Total
        {
            get
            {
                double total = 0;
                foreach (Producto item in productos)
                {
                    total += item.Total;
                }

                Pesos totalPesos;
                switch (Moneda)
                {
                    case eMoneda.Peso:
                        totalPesos = total;
                        break;
                    case eMoneda.Dolar:
                        totalPesos = total * Pesos.GetCotizacion();
                        break;
                    case eMoneda.Euro:
                        totalPesos = total * Pesos.GetCotizacion()/Euro.GetCotizacion();
                        break;
                }
                return total;
            }
        }

        public eTipoFactura Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public eMoneda Moneda
        {
            get
            {
                return this.moneda;
            }
            set
            {
                this.moneda = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        // END Propiedades
    }

    public enum eTipoFactura
    {
        A,
        B,
        C
    }

    public enum eMoneda
    {
        Peso,
        Dolar,
        Euro
    }
}
