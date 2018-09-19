using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        // Atributos
        double cantidad;
        static float cotizRespectoDolar;

        // Constructores
        public Dolar() : this(0) { }
        public Dolar(double _cantidad) : this(_cantidad, 1) { }
        public Dolar(double _cantidad, float _cotizacion)
        {
            this.cantidad = _cantidad;
            cotizRespectoDolar = _cotizacion;
        }

        // Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        // Operadores explícitos e implícitos
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        // Operadores aritméticos y lógicos
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.GetCantidad() == ((Dolar)p).GetCantidad();
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d.GetCantidad() == ((Dolar)e).GetCantidad());
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.GetCantidad() == d2.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }
    }
}
