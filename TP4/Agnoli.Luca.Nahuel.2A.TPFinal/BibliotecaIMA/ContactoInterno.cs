using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class contactoInterno : IDatosContacto
    {
        private string nombreDepartamento;
        private double telefono;
        private string direccion;
        /// <summary>
        /// Inicialzia los atributos de contactoInterno
        /// </summary>
        /// <param name="nombreDep">Nombre del departamento</param>
        /// <param name="tel">Telefono</param>
        /// <param name="direc">Direccion del departamento</param>
        public contactoInterno(string nombreDep, double tel, string direc)
        {
            this.nombreDepartamento = nombreDep;
            this.telefono = tel;
            this.direccion = direc;
        }
        /// <summary>
        /// Propiedad que retorna el nombre y permite asignarle un valor.
        /// </summary>
        public string Nombre { get { return this.nombreDepartamento; } set { this.nombreDepartamento = value; } }
        /// <summary>
        ///  Propiedad que retorna el NumeroTelefonico y permite asignarle un valor.
        /// </summary>
        public double NumeroTelefonico { get { return this.telefono; } set { this.telefono = value; } }
        /// <summary>
        /// Propiedad que retorna la Direccion y permite asignarle un valor.
        /// </summary>
        public string Direccion { get { return this.direccion; } set { this.direccion = value; } }
        /// <summary>
        /// Muestra los datos del contactoInterno
        /// </summary>
        /// <returns>retorna una string con los datos</returns>
        public string Mostrar()
        {
            StringBuilder datosContactoInternoStr = new StringBuilder();
            datosContactoInternoStr.AppendLine($"Nombre de la sección: {this.Nombre}");
            datosContactoInternoStr.AppendLine($"Telefono: {this.NumeroTelefonico}");
            datosContactoInternoStr.AppendLine($"Dirección dentro del departamento: {this.Direccion}");
            return datosContactoInternoStr.ToString();
        }
    }
}
