﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_31
{
    public class Cliente
    {
        string nombre;
        int numero;

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
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.Numero == c2.Numero);
        }
    }
}
