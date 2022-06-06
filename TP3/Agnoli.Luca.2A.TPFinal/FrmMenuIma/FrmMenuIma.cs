using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaIMA;


namespace FrmMenuIma
{
    public partial class FrmMenuIma : Form
    {
        AdministracionPersonas administracion;
        PuntoXml<List<Persona>> listaUsuarios;
        string ruta;
        /// <summary>
        /// Inicializa el formulario, la administración, la lista en formato xml y asigna la ruta.
        /// </summary>
        public FrmMenuIma()
        {
            InitializeComponent();
            administracion = new AdministracionPersonas();
            this.listaUsuarios = new PuntoXml<List<Persona>>();
            ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"clientes.xml";
        }
        /// <summary>
        /// Carga la lista con los datos de los usuarios cagados en el archivo de la ruta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuIma_Load(object sender, EventArgs e)
        {
            if(File.Exists(ruta))
            {
                administracion.ListaPersonas = listaUsuarios.Leer(ruta);
            }
            FrmSaludar nuevoSaludo = new FrmSaludar();
            nuevoSaludo.ShowDialog();
        }
        /// <summary>
        /// Despliega el form FrmAcercaIMA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoIMA_Click(object sender, EventArgs e)
        {
            FrmAcercaIMA acercaIMA = new FrmAcercaIMA();
            acercaIMA.ShowDialog();
        }
        /// <summary>
        /// Despliega el form FrmAltaCliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente(administracion);
            frmAlta.ShowDialog();
            administracion = frmAlta.PersonasSistema;
        }

        /// <summary>
        /// Despliega el form FrmClientesActivos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarClientesActivos_Click(object sender, EventArgs e)
        {           
            FrmClientesActivos frmActivos = new FrmClientesActivos(administracion);
            frmActivos.ShowDialog();           
        }
        /// <summary>
        /// Despliega el form FrmModificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarDatosUsuario_Click(object sender, EventArgs e)
        {
            if(checkearListaCargada(administracion))
            {
                FrmModificar formModificar = new FrmModificar(administracion, listaUsuarios);
                formModificar.ShowDialog();
            }         
        }
        /// <summary>
        /// Despliega el form FrmBajaUsuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if(checkearListaCargada(administracion))
            {
                FrmBajaUsuario frmBaja = new FrmBajaUsuario(administracion, listaUsuarios);
                frmBaja.ShowDialog();
            }                      
        }
        /// <summary>
        /// Verifica que la lista este cargada
        /// </summary>
        /// <param name="admin">Recibe una administracion para acceder a la lista</param>
        /// <returns>True si esta cargada, false caso contrario</returns>
        private bool checkearListaCargada(AdministracionPersonas admin)
        {
            bool listaCargada = false;
            if(administracion.ListaPersonas.Count > 0)
            {
                listaCargada = true;
            }
            else
            {
                MessageBox.Show($"Error no hay usuarios cargados en el sistema", "Error al encontrar usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaCargada;
        }
        /// <summary>
        /// Despliega el form FrmInfoPlanes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlanes_Click(object sender, EventArgs e)
        {
            FrmInfoPlanes forminfoPlan = new FrmInfoPlanes();
            forminfoPlan.ShowDialog();
        }
        /// <summary>
        /// Despliega el form FrmNormasCobertura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCobertura_Click(object sender, EventArgs e)
        {
            FrmNormasCobertura formCobertura = new FrmNormasCobertura();
            formCobertura.ShowDialog();
        }
        /// <summary>
        /// Despliega el form FrmSucursales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContacto_Click(object sender, EventArgs e)
        {
            FrmSucursales formSucursales = new FrmSucursales();
            formSucursales.ShowDialog();
        }
    }
}
