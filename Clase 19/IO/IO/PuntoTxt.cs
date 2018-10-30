using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta)
        {

        }

        public string Leer(string ruta)
        {

        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) != "txt")
                {
                    throw new ArchivoIncorrectoException("El archivo no es un txt.");
                }
                else
                {
                    return true;
                }
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
        }
    }
}
