using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro29
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool flag = true;

            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                {
                    flag = false;
                    break;
                }
            }
            if (e.jugadores.Count < e.cantidadDeJugadores && flag)
            {
                e.jugadores.Add(j);
                return true;
            }

            return false;
        }
    }
}
