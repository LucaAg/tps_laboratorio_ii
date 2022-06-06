using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class PuntoTxt<T> : Archivo where T : class
    {
        /// <summary>
        /// Retorna la extension en formato txt.
        /// </summary>
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        /// <summary>
        /// Guarda, si el archivo existe, en formato txt. Caso contrario, arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Guardar", "PuntoTxt.cs");
            }
        }

        /// <summary>
        /// Si el archivo no existe, guarda los datos y crea una carpeta en la ruta seleccionada.
        /// Caso contrario arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "GuardarComo", "PuntoTxt.cs");
            }
        }

        /// <summary>
        /// Lee los datos de un archivo txt.
        /// Caso contrario arroja MiExcepcionArchivoInvalido.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns></returns>
        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader miStreamReader = new StreamReader(ruta))
                {
                    return miStreamReader.ReadToEnd();
                }
            }
            else
            {
                throw new MiExcepcionArchivoInvalido("La ruta o la extension no son validas", "Leer", "PuntoTxt.cs");
            }
        }

        /// <summary>
        ///  Guarda los datos en formato txt.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        public void GuardarArchivo(string ruta, string contenido)
        {
            using (StreamWriter miStreamWriter = new StreamWriter(ruta))
            {
                miStreamWriter.WriteLine(contenido);
            }
        }
    }
}
