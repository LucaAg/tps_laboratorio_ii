using BibliotecaIMA;
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
    public partial class FrmInfoPlanes : Form
    {
        Plan plan;
        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FrmInfoPlanes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Muestra los datos del plan clasico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlanClasico_Click(object sender, EventArgs e)
        {
            plan = new PlanClasico(3500, "Plan Clasico", "ST", "ST");
            rtbInfoPlanes.Text = plan.ToString();
        }
        /// <summary>
        /// Muestra los datos del plan plus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlanPlus_Click(object sender, EventArgs e)
        {
            plan = new PlanPlus(6000, "Plan Plus", "ST", "ST");
            rtbInfoPlanes.Text = plan.ToString();
        }
        /// <summary>
        /// Muestra los datos del plan premiun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlanPremiun_Click(object sender, EventArgs e)
        {
            plan = new PlanPremiun(15000, "Plan Premiun", "ST", "ST");
            rtbInfoPlanes.Text = plan.ToString();
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult botonSalir;
            botonSalir = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if(botonSalir == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
