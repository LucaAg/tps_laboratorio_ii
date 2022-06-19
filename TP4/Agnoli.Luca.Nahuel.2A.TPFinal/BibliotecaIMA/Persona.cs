using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaIMA
{
    [XmlInclude(typeof(PlanClasico))]
    [XmlInclude(typeof(PlanPlus))]
    [XmlInclude(typeof(PlanPremiun))]
    public class Persona : IDatosContacto
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;
        private DateTime fechaNacimiento;
        private string genero;
        private string grupoSanguineo;
        private string direccion;
        private double numeroTelefonico;
        private Plan planElegido;
        private bool estadoPlan;

        /// <summary>
        /// Constructor vacio para poder imprimir en formato xml
        /// </summary>
        public Persona()
        {
        }
        /// <summary>
        /// Inicializa los atributos de la Persona.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNac"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="grupoSanguineo"></param>
        /// <param name="dire"></param>
        /// <param name="numTel"></param>
        /// <param name="plan"></param>
        /// <param name="estadoDelPlan"></param>
        public Persona(string nombre,string apellido,DateTime fechaNac,int edad,int dni,string genero, string grupoSanguineo,
            string dire, double numTel,Plan plan,bool estadoDelPlan)
        {
            this.nombre = nombre; 
            this.apellido = apellido; 
            this.fechaNacimiento = fechaNac; 
            this.edad = edad; 
            this.dni = dni; 
            this.genero = genero; 
            this.grupoSanguineo = grupoSanguineo; 
            this.direccion = dire; 
            this.numeroTelefonico = numTel; 
            this.planElegido = plan; 
            this.estadoPlan = estadoDelPlan;
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Nombre.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }   
            set { this.nombre = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la Edad.
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la FechaNacimiento.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Apellido.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Dni.
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Sexo.
        /// </summary>
        public string Sexo
        {
            get { return this.genero; }
            set { this.genero = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al GrupoSanguineo.
        /// </summary>
        public string GrupoSanguineo
        {
            get { return this.grupoSanguineo; }
            set { this.grupoSanguineo = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la Direccion.
        /// </summary>
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al NumeroTelefonico.
        /// </summary>
        public double NumeroTelefonico
        {
            get { return this.numeroTelefonico; }
            set { this.numeroTelefonico = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al Plan.
        /// </summary>
        public Plan Plan
        {
            get { return this.planElegido; }
            set { this.planElegido = value; }
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al EstadoPlan.
        /// </summary>
        public bool EstadoPlan
        {
            get { return this.estadoPlan; }
            set { this.estadoPlan = value; }
        }    
        /// <summary>
        /// Sobrecarga del operador "==", verifica igualdad de dni, fecha de nacimiento y apellido.
        /// </summary>
        /// <param name="persona">Persona a comparar</param>
        /// <param name="personaDos">Persona dos a comparar</param>
        /// <returns>true si cumple la igualdad, false caso contrario</returns>
        public static bool operator ==(Persona persona, Persona personaDos)
        {
            return persona.Dni == personaDos.Dni && persona.FechaNacimiento == personaDos.FechaNacimiento && persona.Apellido == personaDos.Apellido;
        }
        /// <summary>
        /// Sobrecarga del operador "!=", llama a la sobrecarga de "==" 
        /// </summary>
        /// <param name="persona">Persona a comparar</param>
        /// <param name="personaDos">Persona dos a comparar</param>
        /// <returns>true si cumple la igualdad, false caso contrario</returns>
        public static bool operator !=(Persona persona, Persona personaDos)
        {
            return !(persona == personaDos);
        }
        /// <summary>
        /// Sobrecarga del metodo ToString
        /// </summary>
        /// <returns>String con los datos de la persona</returns>
        public override string ToString()
        {
            StringBuilder datosPersonaStr = new StringBuilder();
            datosPersonaStr.AppendLine($"Nombre: {this.Nombre}.\nApellido: {this.Apellido}.");
            datosPersonaStr.AppendLine($"Edad: {this.Edad}.\nSexo: {this.Sexo}.");
            datosPersonaStr.AppendLine($"DNI: {this.Dni}.\nDireccion: {this.Direccion}");
            datosPersonaStr.AppendLine($"Grupo sanguineo: {this.GrupoSanguineo}.");
            datosPersonaStr.AppendLine($"Numero telefonico: {this.NumeroTelefonico}.\nPlan solicitado: {this.Plan.GetType().Name}");
            return datosPersonaStr.ToString();
        }
    }
}
