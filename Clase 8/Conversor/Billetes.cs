using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
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
            return cotizRespectoDolar;
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

    public class Euro
    {
        // Atributos
        double cantidad;
        static float cotizRespectoDolar;

        // Constructores
        public Euro() : this(0) { }
        public Euro(double _cantidad) : this(_cantidad, (float)(1/1.3642)) { }
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
            return new Pesos((e.GetCantidad() / Euro.GetCotizacion()) * Pesos.GetCotizacion());
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

    public class Pesos
    {
        // Atributos
        double cantidad;
        static float cotizRespectoDolar;

        // Constructores
        public Pesos() : this(0) { }
        public Pesos(double _cantidad) : this(_cantidad, 17.55F) { }
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
            return cotizRespectoDolar;
        }

        // Operadores explícitos e implícitos
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.GetCantidad() / (Pesos.GetCotizacion()/Euro.GetCotizacion()));
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
