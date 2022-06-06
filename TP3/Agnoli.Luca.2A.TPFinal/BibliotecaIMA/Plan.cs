using System;
using System.Text;

namespace BibliotecaIMA
{
    public abstract class Plan
    {
        private double valorPlan;
        private string tipoPlan;
        private string consultaDomiciliaria;
        private string consultaConsultorio;
        /// <summary>
        /// Constructor vacio para poder imprimir en formato xml
        /// </summary>
        public Plan()
        {
        }
        /// <summary>
        /// Inicializa los atributos del plan.
        /// </summary>
        /// <param name="valorPlan"></param>
        /// <param name="tipo"></param>
        /// <param name="consultaDom"></param>
        /// <param name="consultaConsultorio"></param>
        public Plan(double valorPlan,string tipo,string consultaDom,string consultaConsultorio)
        {
            this.valorPlan = valorPlan;
            this.tipoPlan = tipo;
            this.consultaDomiciliaria = consultaDom;
            this.consultaConsultorio = consultaConsultorio;
        }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al ValorPlan.
        /// </summary>
        public double ValorPlan { get { return this.valorPlan; } set { this.valorPlan = value; } }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor al TipoPlan.
        /// </summary>
        public string TipoPlan { get { return this.tipoPlan; } set { this.tipoPlan = value; } }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la ConsultaDomiciliaria.
        /// </summary>
        public string ConsultaDomiciliaria { get {return this.consultaDomiciliaria; } set { this.consultaDomiciliaria = value; } }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la ConsultaConsultorio.
        /// </summary>
        public string ConsultaConsultorio { get { return this.consultaConsultorio; } set { this.consultaConsultorio = value; } }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la Kinesiologia.
        /// </summary>
        public abstract bool Kinesiologia { get ; set ; }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la FonoAudiologia.
        /// </summary>
        public abstract bool FonoAudiologia { get ; set ; }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la InternacionClinica.
        /// </summary>
        public abstract bool InternacionClinica { get ; set ; }
        /// <summary>
        /// Propiedad de lectura, que a su vez, permite asignar un valor a la InternacioQuirurgicas.
        /// </summary>
        public abstract bool InternacionQuirurgicas { get ; set ; }
        /// <summary>
        /// Sobrecarga del metodo ToString
        /// </summary>
        /// <returns>String con los datos del plan</returns>
        public override string ToString()
        {
            string tieneKinesio = this.Kinesiologia ? "SI" : "NO";
            string tieneFonoAudiologia = this.FonoAudiologia ? "SI" : "NO";
            string tieneInternacionClinica = this.InternacionClinica ? "SI" : "NO";
            string tieneInternacionQuirurgica = this.InternacionClinica ? "SI" : "NO";
            StringBuilder datosPlanStr = new StringBuilder();
            datosPlanStr.AppendLine($"PLAN SOLICITADO: {this.TipoPlan}");
            datosPlanStr.AppendLine($"VALOR DEL PLAN: {this.ValorPlan}");
            datosPlanStr.AppendLine("SERVICIOS DEL PLAN: ");
            datosPlanStr.AppendLine($"CONSULTAS DOMICILIARIAS: {this.ConsultaDomiciliaria}");
            datosPlanStr.AppendLine($"CONSULTAS POR CONSULTORIO: {this.consultaConsultorio}");
            datosPlanStr.AppendLine($"KINESIOLOGIA: {tieneKinesio}");
            datosPlanStr.AppendLine($"FONOAUDIOLOGIA: {tieneFonoAudiologia}");
            datosPlanStr.AppendLine($"INTERNACION CLINICA: {tieneInternacionClinica}");
            datosPlanStr.AppendLine($"INTERNACION QUIRURGICA: {tieneInternacionQuirurgica}");
            datosPlanStr.AppendLine($"Datos extra: ST(Sin tope)");
            return datosPlanStr.ToString();
        }
    }
}
