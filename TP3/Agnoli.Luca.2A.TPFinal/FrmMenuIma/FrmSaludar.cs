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
    public partial class FrmSaludar : Form
    {
        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FrmSaludar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento load, carga la hora de entrada y saluda al usuario correspondiete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSaludar_Load(object sender, EventArgs e)
        {
            DateTime horaEntrada = DateTime.Now;
            this.txtBienvenida.Text = $"{Environment.UserName}";
            this.txtHorarioBienvenida.Text = $"{horaEntrada}";
        }     
    }
}
