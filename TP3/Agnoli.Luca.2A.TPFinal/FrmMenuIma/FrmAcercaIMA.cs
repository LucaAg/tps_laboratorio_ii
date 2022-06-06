using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuIma
{
    public partial class FrmAcercaIMA : Form
    {
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FrmAcercaIMA()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cuando se inicia el formulario carga de valores los rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAcercaIMA_Load(object sender, EventArgs e)
        {
            this.rtxValores.Text = $"{MostrarValoresIMA()}";
            this.rtxMision.Text = $"{MostrarMisionIMA()}";
        }
        /// <summary>
        /// Muestra datos tipo string
        /// </summary>
        /// <returns>String de datos</returns>
        public string MostrarValoresIMA()
        {
            string valores = "Anhelamos seguir construyendo un sistema de financiamiento de prestaciones" +
            " médicas para nuestros asociados que persiga tanto la protección integral de su salud, como la de " +
            "los demás aspectos de la persona humana, sumando a ello, " +
            "un real y efectivo compromiso de solidaridad hacia toda la sociedad en su conjunto.";
            return valores;
        }
        /// <summary>
        /// Muestra datos tipo string
        /// </summary>
        /// <returns>String de datos</returns>
        public string MostrarMisionIMA()
        {
            string mision = "Desde 1974, nuestra misión principal es brindar servicios de alta calidad médica," +
                " cuidando el contenido humano, social y solidario que no puede ser dejado de lado por las organizaciones que como la nuestra, " +
                "se dedican tanto a contener necesidades humanas, como así también a ocuparse y preocuparse por la salud de nuestros asociados";
            return mision;
        }
    }
}
