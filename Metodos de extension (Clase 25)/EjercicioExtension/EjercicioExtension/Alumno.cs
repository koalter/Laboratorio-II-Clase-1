using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtension
{
    public class Alumno
    {
        string nombre;
        string apellido;
        DateTime fechaNac;
        int dni;
        string direccion;

        public Alumno(string nombre, string apellido, DateTime fecha, int dni, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fecha;
            this.dni = dni;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2} - {3} - {4}", 
                this.nombre, this.apellido, this.fechaNac.Mostrar(), this.dni.Mostrar(), this.direccion);
        }
    }
}
