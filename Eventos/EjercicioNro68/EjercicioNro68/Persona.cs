using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        string apellido;
        string nombre;

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre + " " + this.Apellido);

            return sb.ToString();
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
