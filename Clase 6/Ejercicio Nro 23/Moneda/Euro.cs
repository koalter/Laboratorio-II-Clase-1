using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        // Atributos
        double cantidad;
        static float cotizRespectoDolar;

        // Constructores
        public Euro() : this(0) { }
        public Euro(double _cantidad) : this(_cantidad, (float)(1 / 1.3642)) { }
        public Euro(double _cantidad, float _cotizacion)
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
            return cotizRespectoDolar;
        }

        // Operadores explícitos e implícitos
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() / Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            Dolar d = (Dolar)e;
            return (Pesos)d;
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        // Operadores aritméticos y lógicos
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e.GetCantidad() == ((Euro)d).GetCantidad());
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e.GetCantidad() == ((Euro)p).GetCantidad());
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.GetCantidad() == e2.GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + ((Euro)d).GetCantidad();
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return e.GetCantidad() - ((Euro)p).GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.GetCantidad() + ((Euro)p).GetCantidad();
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }
    }
}
