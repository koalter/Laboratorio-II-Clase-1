using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {// Atributos
        double cantidad;
        static float cotizRespectoDolar;

        // Constructores
        public Pesos() : this(0) { }
        public Pesos(double _cantidad) : this(_cantidad, 40F) { }
        public Pesos(double _cantidad, float _cotizacion)
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
            return Pesos.cotizRespectoDolar;
        }

        // Operadores explícitos e implícitos
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            // Paso de pesos a dolares
            Dolar d = (Dolar)p;
            // Y de dolares a euros
            return (Euro)d;
        }
        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        // Operadores aritméticos y lógicos
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.GetCantidad() == ((Pesos)d).GetCantidad();
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p.GetCantidad() == ((Pesos)e).GetCantidad();
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p.GetCantidad() == ((Pesos)d).GetCantidad());
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p.GetCantidad() == ((Pesos)e).GetCantidad());
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1.GetCantidad() == p2.GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.GetCantidad() + ((Pesos)d).GetCantidad();
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.GetCantidad() - ((Pesos)d).GetCantidad();
        }
    }
}
