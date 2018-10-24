using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Generics
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Ficha()
        {
            return String.Format("{0} fundado el {1}", this.nombre, this.fechaCreacion.Date.ToString("dd/MM/yyyy"));
        }

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return (equipo1.nombre == equipo2.nombre) && (equipo1.fechaCreacion == equipo2.fechaCreacion);
        }
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
    }
}
