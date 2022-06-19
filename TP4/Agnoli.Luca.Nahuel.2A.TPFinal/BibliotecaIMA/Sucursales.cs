using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class Sucursales : IDatosContacto
    {
        private int idSucursal;
        private string nombreLocalidad;
        private double telefono;
        private string direccion;
        /// <summary>
        /// Inicializa los atributos de las sucursales
        /// </summary>
        /// <param name="nombreDep"></param>
        /// <param name="tel"></param>
        /// <param name="direc"></param>
        public Sucursales(string localidad, double tel, string direc)
        {
            this.nombreLocalidad = localidad;
            this.telefono = tel;
            this.direccion = direc;
        }

        /// <summary>
        /// Constructor que inicializa a una sucursal con los datos correspondientes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="localidad"></param>
        /// <param name="tel"></param>
        /// <param name="direc"></param>
        public Sucursales(int id, string localidad, double tel, string direc)
            :this(localidad,tel,direc)
        {
            this.idSucursal = id;
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public int IdSucursal { get { return this.idSucursal; } set { ; } }
        /// <summary>
        /// Propiedad de lectura y carga de datos.
        /// </summary>
        public string Nombre { get { return this.nombreLocalidad; } set { this.nombreLocalidad = value; } }
        /// <summary>
        /// Propiedad de lectura y carga de datos.
        /// </summary>
        public double NumeroTelefonico { get { return this.telefono; } set { this.telefono = value; } }
        /// <summary>
        /// Propiedad de lectura y carga de datos.
        /// </summary>
        public string Direccion { get { return this.direccion; } set { this.direccion = value; } }
        /// <summary>
        /// Muestra los datos de una sucursal
        /// </summary>
        /// <returns>String con datos de la sucursal</returns>
        public string Mostrar()
        {
            StringBuilder datosSucursalesStr = new StringBuilder();
            datosSucursalesStr.AppendLine($"ID : {this.IdSucursal}");
            datosSucursalesStr.AppendLine($"Localidad: {this.Nombre}");
            datosSucursalesStr.AppendLine($"Telefono: {this.NumeroTelefonico}");
            datosSucursalesStr.AppendLine($"Dirección: {this.Direccion}");
            return datosSucursalesStr.ToString();
        }

        /// <summary>
        /// Carga en una string los datos almacenados en la lista de sucursales.
        /// </summary>
        /// <returns>String con los datos</returns>
        public static string MostrarListaSucursales(List<Sucursales> listaSucursales)
        {
            StringBuilder datosSucursalesStr = new StringBuilder();
            foreach (Sucursales sucursal in listaSucursales)
            {
                datosSucursalesStr.AppendLine($"{sucursal.Mostrar()}");
            }
            return datosSucursalesStr.ToString();
        }
        /// <summary>
        /// Verifica si dos sucursales son iguales
        /// </summary>
        /// <param name="sucursalUno"></param>
        /// <param name="sucursalDos"></param>
        /// <returns>True si son iguales, false caso contrario</returns>
        public static bool operator ==(Sucursales sucursalUno, Sucursales sucursalDos)
        {
            return sucursalUno.nombreLocalidad == sucursalDos.nombreLocalidad && sucursalUno.Direccion == sucursalDos.Direccion && sucursalUno.NumeroTelefonico == sucursalUno.NumeroTelefonico;
        }
        /// <summary>
        /// Verifica que dos sucursales sean distintas
        /// </summary>
        /// <param name="sucursalUno"></param>
        /// <param name="sucursalDos"></param>
        /// <returns>True si son distintas, caso contrario, false.</returns>
        public static bool operator !=(Sucursales sucursalUno, Sucursales sucursalDos)
        {
            return !(sucursalUno == sucursalDos);
        }

        /// <summary>
        /// Verifica que una sucursal no este dentro de la lista de sucursales.
        /// </summary>
        /// <param name="listaSucursales"></param>
        /// <param name="sucursal"></param>
        /// <returns>True si esta en la lista, caso contrario, falso</returns>
        public static bool operator ==(List<Sucursales> listaSucursales, Sucursales sucursal)
        {
            bool sucursalListada = false;
            if (listaSucursales is not null)
            {
                foreach (Sucursales sucursalEnLista in listaSucursales)
                {
                    if (sucursalEnLista == sucursal)
                    {
                        sucursalListada = true;
                        break;
                    }
                }
            }
            return sucursalListada;
        }
        /// <summary>
        /// Verifica que la sucursal no este en la lista.
        /// </summary>
        /// <param name="listaSucursales"></param>
        /// <param name="sucursal"></param>
        /// <returns>True si no esta, caso contrario, false</returns>
        public static bool operator !=(List<Sucursales> listaSucursales, Sucursales sucursal)
        {
            return !(listaSucursales == sucursal);
        }
    }
}
