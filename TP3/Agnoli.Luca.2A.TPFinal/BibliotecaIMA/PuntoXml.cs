using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace BibliotecaIMA
{
    public class PuntoXml<T> : Archivo where T : class 
    {
        /// <summary>
        /// Retorna la extension del formato xml.
        /// </summary>
        protected override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        /// <summary>
        /// Guarda, si el archivo existe, en formato xml. Caso contrario, arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="contenido">contenido del archivo</param>
        public void Guardar(string ruta, T contenido)
        {
           
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Guardar", "PuntoXml.cs");
            }
        }

        /// <summary>
        /// Si el archivo no existe, guarda los datos y crea una carpeta en la ruta seleccionada.
        /// Caso contrario arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="contenido">contenido del archivo</param>
        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "GuardarComo", "PuntoXml.cs");
            }
        }

        /// <summary>
        /// Lee los datos de un archivo xml.
        /// Caso contrario arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns></returns>
        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader miStreamReader = new StreamReader(ruta))
                {
                    XmlSerializer miXmlSerializer = new XmlSerializer(typeof(T));
                    T tAux = miXmlSerializer.Deserialize(miStreamReader) as T;
                    return tAux;
                }
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Leer", "PuntoXml.cs");
            }
        }

        /// <summary>
        /// Serializa los datos en formato xml.
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="contenido">contenido del archivo</param>
        public void Serializar(string ruta, T contenido)
        {
            using (StreamWriter miStreamWriter = new StreamWriter(ruta))
            {
                XmlSerializer miXmlSerializer = new XmlSerializer(typeof(T));
                miXmlSerializer.Serialize(miStreamWriter, contenido);
            }
        }
    }
}
