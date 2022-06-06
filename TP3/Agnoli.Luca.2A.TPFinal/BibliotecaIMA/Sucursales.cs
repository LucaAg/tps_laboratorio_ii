using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class Sucursales : IDatosContacto
    {
        private string nombreDepartamento;
        private double telefono;
        private string direccion;
        /// <summary>
        /// Inicializa los atributos de las sucursales
        /// </summary>
        /// <param name="nombreDep"></param>
        /// <param name="tel"></param>
        /// <param name="direc"></param>
        public Sucursales(string nombreDep, double tel, string direc)
        {
            this.nombreDepartamento = nombreDep;
            this.telefono = tel;
            this.direccion = direc;
        }
        public string Nombre { get { return this.nombreDepartamento; } set { this.nombreDepartamento = value; } }
        public double NumeroTelefonico { get { return this.telefono; } set { this.telefono = value; } }
        public string Direccion { get { return this.direccion; } set { this.direccion = value; } }

        public string Mostrar()
        {
            StringBuilder datosSucursalesStr = new StringBuilder();
            datosSucursalesStr.AppendLine($"Nombre del deparamento: {this.Nombre}");
            datosSucursalesStr.AppendLine($"Telefono: {this.NumeroTelefonico}");
            datosSucursalesStr.AppendLine($"Dirección: {this.Direccion}");
            return datosSucursalesStr.ToString();
        }
    }
}
