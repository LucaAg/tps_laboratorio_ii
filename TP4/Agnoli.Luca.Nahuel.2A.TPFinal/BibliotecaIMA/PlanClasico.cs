using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class PlanClasico : Plan
    {
        public PlanClasico()
        {
        }

        public PlanClasico(double valorPlan, string tipo, string consultaDom, string consultaConsultorio)
            :base(3500,tipo,consultaDom,consultaConsultorio)
        {
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna true a kinesiologia.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool Kinesiologia { get {return true; } set { ; } }
        /// <summary>
        /// Propiedad de solo lectura que retorna true a FonoAudiologia.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool FonoAudiologia { get { return false; } set {  ; } }
        /// <summary>
        /// Propiedad de solo lectura que retorna true a InternacionClinica.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool InternacionClinica { get { return false; } set  { ; } }
        /// <summary>
        /// Propiedad de solo lectura que retorna true a InternacioQuirurgicas.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool InternacionQuirurgicas { get { return false; } set { ; } }

        /// <summary>
        /// Sobrecarga del metodo ToString
        /// </summary>
        /// <returns>String con los datos del plan</returns>
        public override string ToString()
        {
            StringBuilder datosPlanClasicoStr = new StringBuilder();
            datosPlanClasicoStr.AppendLine(base.ToString());
            return base.ToString();
        }
    }
}
