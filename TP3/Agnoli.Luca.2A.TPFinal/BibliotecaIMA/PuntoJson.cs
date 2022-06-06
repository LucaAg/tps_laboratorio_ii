using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class PuntoJson<T> : Archivo where T : class
    {
        /// <summary>
        /// Retorna la extension en formato Json.
        /// </summary>
        protected override string Extension
        {
            get
            {
                return ".json";
            }
        }

        /// <summary>
        /// Guarda, si el archivo existe, en formato Json. Caso contrario, arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Guardar", "PuntoJson.cs");
            }
        }

        /// <summary>
        /// Si el archivo no existe, guarda los datos y crea una carpeta en la ruta seleccionada.
        /// Caso contrario arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "GuardarComo", "PuntoJson.cs");
            }
        }
        /// <summary>
        /// Lee los datos de un archivo txt.
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
                    string jsonInfo = miStreamReader.ReadToEnd();
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    return JsonSerializer.Deserialize<T>(jsonInfo);
                }
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Leer", "PuntoJson.cs");
            }
        }
        /// <summary>
        /// Serializa los datos en formato xml.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter miStreamWriter = new StreamWriter(ruta))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string jsonInfo = JsonSerializer.Serialize(contenido,options);               
                miStreamWriter.WriteLine(jsonInfo);
            }
        }
    }
}
