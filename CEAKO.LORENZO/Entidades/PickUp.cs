using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        string modelo;
        int valorHora;

        #region Metodos
        private PickUp() : base("")
        {
            this.valorHora = 70;
        }
        public PickUp(string patente, string modelo) : this()
        {
            this.Patente = patente;
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Modelo: " + this.modelo);

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
