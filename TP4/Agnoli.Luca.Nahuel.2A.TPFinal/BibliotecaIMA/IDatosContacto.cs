using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public interface IDatosContacto
    {
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Nombre.
        /// Obliga a las clases que la implementen a utilizarla.
        /// </summary>
        string Nombre
        {
            get; set;
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al NumeroTelefonico.
        /// Obliga a las clases que la implementen a utilizarla.
        /// </summary>
        double NumeroTelefonico
        {
            get; set;
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la Direccion.
        /// Obliga a las clases que la implementen a utilizarla.
        /// </summary>
        string Direccion
        {
            get; set;
        }
    }
}
