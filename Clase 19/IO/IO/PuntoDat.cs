using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        #region Metodos
        /*
        public bool Guardar(PuntoDat ruta)
        {
        }
        */
        public bool Guardar(string ruta, PuntoDat obj)
        {
            bool retorno = this.ValidarArchivo(ruta);

            if (retorno == true)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ruta, FileMode.Create);
                bf.Serialize(fs, obj.Contenido);
                fs.Close();
            }

            return retorno;
        }

        public PuntoDat Leer(string ruta)
        {
            if (this.ValidarArchivo(ruta))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ruta, FileMode.Open);
                this.contenido = (string)bf.Deserialize(fs);
                fs.Close();
            }
            return this;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) != "dat")
                {
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");
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
        #endregion
    }
}
