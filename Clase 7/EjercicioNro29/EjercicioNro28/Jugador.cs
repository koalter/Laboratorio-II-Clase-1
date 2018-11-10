using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro29
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
            this.promedioGoles = this.GetPromedioGoles();
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / (float)this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------");
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni);
            sb.AppendLine("Partidos jugados: " + this.partidosJugados);
            sb.AppendLine("Total de goles marcados: " + this.totalGoles);
            sb.AppendLine("Promedio de goles por partido: " + this.promedioGoles);
            sb.AppendLine("------------------------------------------");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
