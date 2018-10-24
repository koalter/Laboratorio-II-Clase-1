using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        int cilindrada;
        short ruedas;
        int valorHora;

        #region Metodos
        private Moto() : base("")
        {
            this.valorHora = 30;
        }
        public Moto(string patente, int cilindrada) : this(patente, cilindrada, 2)
        {
        }
        public Moto(string patente, int cilindrada, short ruedas)
            : this()
        {
            this.Patente = patente;
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            : base(patente)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cilindrada: " + this.cilindrada);
            sb.AppendLine("Ruedas: " + this.ruedas);

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ConsultarDatos());
            sb.AppendLine("Hora de ingreso: " + this.ingreso.ToString());
            sb.AppendLine("Costo de estadia: " + (DateTime.Now - this.ingreso).Hours * this.valorHora);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
