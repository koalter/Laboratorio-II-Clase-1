using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        // Atributos
        double temperatura;

        // Constructores
        public Fahrenheit() : this(0) { }
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Getters
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        // Operadores implícitos y explícitos
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetTemperatura() + 459.67) * 5 / 9);
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetTemperatura() - 32) * 5 / 9);
        }
        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }
    }
}
