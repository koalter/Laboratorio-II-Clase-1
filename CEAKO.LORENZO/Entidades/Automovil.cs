using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        ConsoleColor color;
        int valorHora;

        #region Metodos
        private Automovil() : base("")
        {
            this.valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color) : this()
        {
            this.Patente = patente;
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora)
            : this(patente, color)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Color: " + this.color);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ConsultarDatos());
            sb.AppendLine("Hora de ingreso: " + this.ingreso.ToString());
            sb.AppendLine("Costo de estadia: " + (DateTime.Now - this.ingreso).Hours * this.valorHora);

            return sb.ToString();
        }

        #endregion
    }
}
