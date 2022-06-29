using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaIMA
{
    public class PlanPlus : Plan
    {
        /// <summary>
        /// Constructor vacio, necesario para poder imprimir y leer en xml
        /// </summary>
        public PlanPlus()
        {
        }
        /// <summary>
        /// Inicializa los datos del plan, llamando a base
        /// </summary>
        /// <param name="valor">Cargo del plan</param>
        /// <param name="tipo">Tipo de plan</param>
        /// <param name="consultaDom">Si posee consulta domiciliaria</param>
        /// <param name="consultaConsultorio">Si posee consulta por consultorio</param>
        public PlanPlus(double valor,string tipo, string consultaDom, string consultaConsultorio)
            :base(6000,tipo,consultaDom,consultaConsultorio)
        {
        }
        /// <summary>
        ///  Propiedad de solo lectura que retorna true a kinesiologia.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool Kinesiologia { get { return true; } set { ; } }
        /// <summary>
        ///  Propiedad de solo lectura que retorna true a FonoAudiologia.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool FonoAudiologia { get { return true; } set {  ; } }
        /// <summary>
        ///  Propiedad de solo lectura que retorna true a InternacionClinica.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool InternacionClinica { get { return false; } set { ; } }
        /// <summary>
        ///  Propiedad de solo lectura que retorna true a InternacioQuirurgicas.
        /// El set esta vacio, para poder imprimir en formato xml.
        /// </summary>
        public override bool InternacionQuirurgicas { get { return false; } set { ; } }
        /// <summary>
        /// Sobrecarga del metodo ToString
        /// </summary>
        /// <returns>String con los datos del plan</returns>
        public override string ToString()
        {
            StringBuilder datosPlanPlusStr = new StringBuilder();
            datosPlanPlusStr.AppendLine(base.ToString());
            return base.ToString();
        }
    }
}
