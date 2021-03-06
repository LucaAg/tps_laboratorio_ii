using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class PersonaNulaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
       
        /// <summary>
        /// Inicializa los datos de la excepcion, llamando al segundo constructor
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        /// <param name="clase">Clase donde se produce</param>
        /// <param name="metodo">Metodo donde se produce</param>
        public PersonaNulaException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }
        /// <summary>
        /// Inicializa los datos de la excepcion, llamando a base
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        /// <param name="clase">Clase donde se produce</param>
        /// <param name="metodo">Metodo donde se produce</param>
        /// <param name="innerException">Mensaje si se produce una excepcion dentro de otra</param>
        public PersonaNulaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        /// <summary>
        /// Propiedad de solo lectura, retorna el nombre de la clase.
        /// </summary>
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura, retorna el nombre de del metodo.
        /// </summary>
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo ToString.
        /// </summary>
        /// <returns>Retorna los datos de la excepcion</returns>
        public override string ToString()
        {
            StringBuilder datosStringStr = new StringBuilder();
            datosStringStr.AppendFormat("Excepción en el método {0} de la clase {1}:\n", this.NombreMetodo, this.NombreClase);
            datosStringStr.AppendLine($"{this.Message}");
            PersonaNulaException miException = this;
            while (miException.InnerException != null)
            {
                miException = (PersonaNulaException)miException.InnerException;
                datosStringStr.AppendFormat("Excepción en el método {0} de la clase {1}:\n", miException.NombreMetodo, miException.NombreClase);
                datosStringStr.AppendLine($"{miException.Message}\t");
            }
            datosStringStr.AppendLine(this.StackTrace);
            return datosStringStr.ToString();
        }
    }
}
