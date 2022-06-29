using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class AdministracionPersonas
    {
        private List<Persona> listaPersonas;
        /// <summary>
        /// Inicializa la lista de personas
        /// </summary>
        public AdministracionPersonas()
        {
            this.listaPersonas = new List<Persona>(); 
        }
        /// <summary>
        /// Propiedad que retorna la lista.
        /// A su vez, puede cargar de valor la lista.
        /// </summary>
        public List<Persona> ListaPersonas
        {
            get
            {
                return this.listaPersonas;
            }
            set
            {
                this.listaPersonas = value;
            }
        }
        /// <summary>
        /// Muestra los datos de la lista
        /// </summary>
        /// <returns>String de datos lista</returns>
        public string Mostrar()
        {
            StringBuilder datosAdministracionStr = new StringBuilder();
            foreach (Persona personaEnLista in this.listaPersonas)
            {
                datosAdministracionStr.AppendLine(personaEnLista.ToString());
            }
            return datosAdministracionStr.ToString();
        }
        /// <summary>
        /// Muestra los clientes acitvos
        /// </summary>
        /// <returns>String de clientes activos</returns>
        public string MostrarClientesActivos()
        {
            StringBuilder datosClientesActivosStr = new StringBuilder();
            foreach (Persona personaEnLista in this.ListaPersonas)
            {
                if(personaEnLista.EstadoPlan)
                {
                    datosClientesActivosStr.AppendLine(personaEnLista.ToString());
                }              
            }
            return datosClientesActivosStr.ToString();
        }
        /// <summary>
        /// Llama a la sobrecarga del metodo "==".
        /// Checkea si la persona esta en la lista.
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="persona"></param>
        /// <returns>True si esta en lista, caso contrario false</returns>
        public static bool checkearPersonaEnLista(AdministracionPersonas administracion,Persona persona)
        {
            return administracion == persona;
        }

        /// <summary>
        /// Sobrecarga del operador "=="
        /// Iguala a 2 personas, para saber si pertenecen a la lista.
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="persona"></param>
        /// <returns>true si esta en lista, false caso contrario</returns>
        public static bool operator ==(AdministracionPersonas administracion,Persona persona)
        {
            bool personaEnLista = false;
            if(administracion.listaPersonas is not null)
            {
                foreach (Persona personita in administracion.listaPersonas)
                {
                    if(persona == personita)
                    {
                        personaEnLista = true;
                        break;
                    }
                }
            }
            return personaEnLista;
        }
        /// <summary>
        /// Sobrecarga del operador "=="
        /// Checkea que una persona no pertenezca a la lsita de administracion.
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="persona"></param>
        /// <returns>true, si no esta, false si esta</returns>
        public static bool operator !=(AdministracionPersonas administracion, Persona persona)
        {
            return !(administracion == persona);
        }
        /// <summary>
        /// Busca a una persona por DNI, si pertence a la lista
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="dni"></param>
        /// <returns>La persona busacada o null</returns>
        public Persona BuscarPorDni(AdministracionPersonas admin, int dni)
        {
            Persona personaBuscada = null;
            if (admin is not null) //textbox.txt.all(char.isDigit(digito));
            {
                foreach (Persona personita in admin.ListaPersonas)
                {
                    if (personita.Dni == dni)
                    {
                        personaBuscada = personita;
                        break;
                    }
                }
            }
            return personaBuscada;
        }
    }
}
