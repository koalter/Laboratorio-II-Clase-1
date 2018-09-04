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
        public Dolar(double _cantidad) : this(_cantidad, 1F) { }
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
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
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
    }
}
