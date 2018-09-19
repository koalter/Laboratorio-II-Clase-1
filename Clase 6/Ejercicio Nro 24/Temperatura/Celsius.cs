using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        // Atributos
        double temperatura;

        // Constructores
        public Celsius() : this(0) { }
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Getters
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        // Operadores implícitos y explícitos
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.GetTemperatura() + 273.15);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.GetTemperatura() * (9 / 5)) + 32);
        }
        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }
    }
}
