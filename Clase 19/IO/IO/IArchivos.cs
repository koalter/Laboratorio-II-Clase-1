using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public interface IArchivos<T>
    {
        private bool Guardar(string ruta, T obj)
        {
            if (obj.GetType() == typeof(string))
            {

            }
        }

        private T Leer(string ruta)
        {

        }
    }
}
