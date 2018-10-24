using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    public class MiClase
    {
        static int LanzarExcepcion()
        {
            int a = 1;

            return a - 1;
        }

        public MiClase()
        {
            try
            {
                MiClase.LanzarExcepcion();
            }catch (DivideByZeroException e)
            {
                new MiClase(e);
            }
        }

        public MiClase(Exception e)
        {
            throw new UnaException().InnerException;
        }
    }
}
