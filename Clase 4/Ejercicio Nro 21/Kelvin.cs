using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Kelvin
    {
        // Atributos
        double temperatura;
        static float convRespectoCelsius;

        // Constructores
        public Kelvin() : this(0) { }
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Getters
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        // Operadores implícitos y explícitos
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.GetTemperatura() - 273.15);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetTemperatura() *  (9/5) - 459.67);
        }
        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }
    }
}
