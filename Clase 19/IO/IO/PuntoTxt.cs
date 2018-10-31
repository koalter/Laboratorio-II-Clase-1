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
        /*
        public bool Guardar(string ruta)
        {
        }
        */
        public bool Guardar(string ruta, string obj)
        {
            bool retorno = this.ValidarArchivo(ruta);
            if (retorno == true)
            {
                StreamWriter sw = new StreamWriter(ruta);
                sw.Write(obj);
                sw.Close();
            }

            return retorno;
        }

        public string Leer(string ruta)
        {
            string texto = "";
            if (this.ValidarArchivo(ruta))
            {
                StreamReader stream = new StreamReader(ruta);
                texto = stream.ReadToEnd();
                stream.Close();
            }
            return texto;
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
