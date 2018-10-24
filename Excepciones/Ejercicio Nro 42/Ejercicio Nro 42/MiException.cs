using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class MiException : Exception
    {
        public MiException()
        {
            throw new Exception();
        }
    }
}
