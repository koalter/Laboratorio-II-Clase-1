using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        int espacioDisponible;
        string nombre;
        List<Vehiculo> vehiculos;

        #region Metodos
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + e.nombre);
            foreach (Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return estacionamiento.vehiculos.Contains(vehiculo);
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);

                return vehiculo.ImprimirTicket();
            }
            else
            {
                return "El vehiculo no es parte del estacionamiento\n";
            }
        }
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente != null 
                && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }
            return estacionamiento;
        }
        #endregion
    }
}
