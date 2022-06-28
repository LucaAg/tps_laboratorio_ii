using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaIMA;

namespace FormsTP4
{
    public delegate void DelegadoCargarDatos();
    public partial class FrmSucursales : Form
    {
        private List<Sucursales> listaSucursales;
        private DelegadoCargarDatos delegadoCargarDatos;
        /// <summary>
        /// Inicializa el formulario, el delegado y la lista de sucursales.
        /// </summary>
        public FrmSucursales()
        {
            InitializeComponent();
            this.listaSucursales = new List<Sucursales>();
            delegadoCargarDatos = CargarLista;
            delegadoCargarDatos += CargarGridView;
        }
        /// <summary>
        /// Llama a los metodos CargarRichTextBoxs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSucursales_Load(object sender, EventArgs e)
        {
            delegadoCargarDatos.Invoke();
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuestaMensaje;
            respuestaMensaje = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuestaMensaje == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Carga los datos de las sucursales en el richtextbox
        /// </summary>
        private void CargarGridView()
        {
            dgvSucursales.DataSource = listaSucursales;
        }
        /// <summary>
        /// Carga la lista de las sucursales
        /// </summary>
        private void CargarLista()
        {
            try
            {
                this.listaSucursales = GestorSQL.LeerDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        /// <summary>
        /// Filtra una sucursal según su dni.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrarId_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursales sucursalFiltrada;
                List<Sucursales> list = new List<Sucursales>();
                FrmIdSucursal formId = new FrmIdSucursal();
                formId.ShowDialog();
                sucursalFiltrada = formId.SucursalFiltrada;
                if (sucursalFiltrada is not null)
                {
                    list.Add(sucursalFiltrada);
                    dgvSucursales.DataSource = list;
                    dgvSucursales.Update();
                    dgvSucursales.Refresh();
                }                                           
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}","Error al filtrar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Llama al metodo cargar lista.
        /// Actualiza el richTextBox con los datos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarSucursales_Click(object sender, EventArgs e)
        {
            try
            {
                delegadoCargarDatos.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error al filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Llama al metodo AccionAgregarSucursal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            AccionAgregarSucursal();
        }
        /// <summary>
        /// Instancia el formlario FrmAltaSucursal.
        /// </summary>
        private void AccionAgregarSucursal()
        {
            try
            {
                FrmAltaSucursal frmAltaSucursal = new FrmAltaSucursal(listaSucursales);
                frmAltaSucursal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error al agregar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

    }
}
