using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        string apellido;
        string nombre;
        int dni;
        string fotoAlumno;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                bool esAlfabetico = true;
                foreach (char letra in value)
                {
                    if (!(char.IsLetter(letra)))
                    {
                        esAlfabetico = false;
                    }
                }
                if (esAlfabetico)
                {
                    this.apellido = value;
                }
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                bool esNumero = true;
                foreach (char digit in value.ToString())
                {
                    if (!(char.IsDigit(digit)))
                    {
                        esNumero = false;
                    }
                }
                if (esNumero)
                {
                    this.dni = value;
                }
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
                bool esAlfabetico = true;
                foreach (char letra in value)
                {
                    if (!(char.IsLetter(letra)))
                    {
                        esAlfabetico = false;
                    }
                }
                if (esAlfabetico)
                {
                    this.apellido = value;
                }
            }
        }
        public string RutaDeLaFoto
        {
            get
            {
                return this.fotoAlumno;
            }
            set
            {
                this.fotoAlumno = value;
            }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.RutaDeLaFoto = ruta;
        }
    }
}
