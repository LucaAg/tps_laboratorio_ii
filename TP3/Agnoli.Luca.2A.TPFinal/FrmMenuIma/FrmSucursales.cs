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
    public partial class FrmSucursales : Form
    {
        private Sucursales sucursalBerazategui;
        private Sucursales sucursalAvellaneda;
        private Sucursales sucursalBernal;
        private List<Sucursales> listaSucursales;
        private PuntoJson<List<Sucursales>> archivoJson;
        private string ruta;
        /// <summary>
        /// Inicializa el formulario, la sucursales, la lista de sucursales y el archivo en formato json.
        /// </summary>
        public FrmSucursales()
        {
            InitializeComponent();
            this.sucursalAvellaneda = new Sucursales("IMA Avellaneda", 42070022, "Gral Lavalle 781");
            this.sucursalBerazategui = new Sucursales("IMA Berazategui", 45867419, "C.137 1958");
            this.sucursalBernal = new Sucursales("IMA Bernal", 42598702, "Av. Las Heras 956");
            this.archivoJson = new PuntoJson<List<Sucursales>>();
            this.listaSucursales = new List<Sucursales>();
            this.ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"datosSucurales.json";
        }
        /// <summary>
        /// Llama a los metodos CargarRichTextBoxs y CargarListas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSucursales_Load(object sender, EventArgs e)
        {
            CargarRichTextBoxs();
            CargarLista();
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
        /// Llama al metodo AccionBotonImprimirDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimirDatos_Click(object sender, EventArgs e)
        {
            AccionBotonImprimirDatos();
        }
        /// <summary>
        /// Imprime los datos llamando la metodo GuardarArchivoJson.
        /// </summary>
        public void AccionBotonImprimirDatos()
        {
            if (GuardarArchivoJson(ruta, listaSucursales))
            {
                MessageBox.Show("Se ha imprido los datos correctamente", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Si el archivo existe lo guarda. Si el archivo no existe lo crea en la ruta especificada.
        /// </summary>
        /// <param name="ruta">Ruta para guardar el archivo</param>
        /// <param name="contenido">Contenido a guardar en el archivo</param>
        /// <returns>true si pudo guardarlo, false caso contrario</returns>
        private bool GuardarArchivoJson(string ruta, List<Sucursales> contenido)
        {
            bool seImprimio = false;
            if (archivoJson.ValidarSiExisteElArchivo(ruta))
            {
                this.archivoJson.Guardar(ruta, contenido);
                seImprimio = true;
            }
            else
            {
                this.archivoJson.GuardarComo(ruta, contenido);
                seImprimio = true;
            }
            return seImprimio;
        }
        /// <summary>
        /// Carga los datos de las sucursales en el richtextbox
        /// </summary>
        private void CargarRichTextBoxs()
        {
            rtxBernal.Text = this.sucursalBernal.Mostrar();
            rtxBerazategui.Text = this.sucursalBernal.Mostrar();
            rtxAvellaneda.Text = this.sucursalAvellaneda.Mostrar();
        }
        /// <summary>
        /// Carga la lista de las sucursales
        /// </summary>
        private void CargarLista()
        {
            this.listaSucursales.Add(sucursalBernal);
            this.listaSucursales.Add(sucursalAvellaneda);
            this.listaSucursales.Add(sucursalBerazategui);
        }
    }
}
