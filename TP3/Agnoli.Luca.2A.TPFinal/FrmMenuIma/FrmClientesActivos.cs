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

namespace FrmMenuIma
{
    public partial class FrmClientesActivos : Form
    {
        AdministracionPersonas administracion;
        /// <summary>
        /// Inicializa el formulario y la administración.
        /// </summary>
        /// <param name="admin"></param>
        public FrmClientesActivos(AdministracionPersonas admin)
        {
            InitializeComponent();
            administracion = admin;
        }
        /// <summary>
        /// Carga los clientes activos en el rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClientesActivos_Load(object sender, EventArgs e)
        {
            rtbClientesActivos.Text = administracion.MostrarClientesActivos();
        }
        /// <summary>
        /// Llama a la funcion CargarTextoPorDni
        /// En caso de ser necesario captura las excepiones MiExcepcionPersonaNula y MiExcepcionPersonaNula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTextoPorDni();
            }
            catch (MiExcepcionPersonaNula ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Persona no valida en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(MiExcepcionCasillerosEnBlanco ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Casilleros en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Carga los datos de la persona filtrada por DNI.
        /// De ser necesario arroja las excepciones MiExcepcionPersonaNula y MiExcepcionCasillerosEnBlanco.
        /// </summary>
        private void CargarTextoPorDni()
        {
            Persona personaBuscada;
            if (!string.IsNullOrEmpty(txtFiltrarDni.Text) && !string.IsNullOrEmpty(txtFiltrarDni.Text))
            {
                personaBuscada = administracion.BuscarPorDni(administracion, Convert.ToInt32(txtFiltrarDni.Text));
                if (personaBuscada is not null && personaBuscada.EstadoPlan)
                {
                    rtbClientesActivos.Text = personaBuscada.ToString();
                }
                else
                {
                    throw new MiExcepcionPersonaNula($"La persona con DNI {txtFiltrarDni.Text} no se encuentra en el sistema o no esta activa", "FrmClientesActivos.cs", "btnBuscarPorDni_Click");
                }
            }
            else
            {
                throw new MiExcepcionCasillerosEnBlanco("Los campos de DNI no pueden estar vacios", "FrmClientesActivos.cs", "CargarTextoPorDni");
            }
        }
        /// <summary>
        /// Carga la rich text box con el retorno del metodo OrdenarListaPorApellido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarPorApellido_Click(object sender, EventArgs e)
        {
            rtbClientesActivos.Text = OrdenarListaPorApellido();
        }

        /// <summary>
        /// Ordena la lista de clientes activos por Apellido.
        /// </summary>
        /// <returns>Lista ordenada por nombre</returns>
        private string OrdenarListaPorApellido()
        {
            StringBuilder datosOrdenarPorNombreStr = new StringBuilder();
            IEnumerable<Persona> listaOrdenada = administracion.ListaPersonas.OrderBy(persona => persona.Apellido).ToList();
            foreach (Persona persona in listaOrdenada)
            {
                datosOrdenarPorNombreStr.AppendLine(persona.ToString());
            }
            return datosOrdenarPorNombreStr.ToString();
        }
        /// <summary>
        /// Ordena la lista de clientes activos por dni.
        /// </summary>
        /// <returns>Lista ordenada por dni</returns>
        private string OrdenarListaPorDni()
        {
            StringBuilder datosOrdenarPorNombreStr = new StringBuilder();
            IEnumerable<Persona> listaOrdenada = administracion.ListaPersonas.OrderBy(persona => persona.Dni).ToList();
            foreach (Persona persona in listaOrdenada)
            {
                datosOrdenarPorNombreStr.AppendLine(persona.ToString());
            }
            return datosOrdenarPorNombreStr.ToString();
        }

        /// <summary>
        /// Carga el rich text box con el retorno de la función OrdenarListaPorDni.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarPorDni_Click(object sender, EventArgs e)
        {
            rtbClientesActivos.Text = OrdenarListaPorDni();
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult botonSalir;
            botonSalir = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (botonSalir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
