using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public abstract class Archivo
    {
        /// <summary>
        /// Propiedad abstracta que retorna la extension del archivo
        /// </summary>
        protected abstract string Extension
        {
            get;
        }
        /// <summary>
        /// Valida que la extension correspondia al archivo.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns>true si es valida, false si no lo es</returns>
        public bool ValidarExtension(string ruta)
        {
            bool extensionValidada = false;

            if(Path.GetExtension(ruta) == this.Extension)
            {
                extensionValidada = true;
            }
            return extensionValidada;
        }
        /// <summary>
        /// Valida que el archivo exista
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns>true si existe, caso contrario false</returns>
        public bool ValidarSiExisteElArchivo(string ruta)
        {
            bool archivoExiste = false;
            if (File.Exists(ruta))
            {
                archivoExiste = true;
            }
            return archivoExiste;
        }
    }
}
