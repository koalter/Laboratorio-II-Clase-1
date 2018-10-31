using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EjercicioNro_57
{
    [Serializable]
    public class Persona
    {
        string nombre;
        string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Obtiene una entidad Persona y la serializa en un archivo.
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static void Guardar(Persona persona)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream("Persona.bin", FileMode.Create);

            formatter.Serialize(file, persona);

            file.Close();
        }

        /// <summary>
        /// Lee el archivo path, lo deserializa y lo retorna como un objeto Persona.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Persona Leer(string path)
        {
            Persona persona;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file;

            try
            {
                file = new FileStream(path, FileMode.Open);
                persona = (Persona)formatter.Deserialize(file);
                file.Close();
                return persona;
            } catch (FileNotFoundException)
            {
                string archivo;
                Console.Write("El archivo no existe, ingrese el nombre del archivo: ");
                archivo = Console.ReadLine();
                Console.Clear();
                return Leer(archivo);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre : {0} -- Apellido: {1}", this.nombre, this.apellido);

            return sb.ToString();
        }
    }
}
