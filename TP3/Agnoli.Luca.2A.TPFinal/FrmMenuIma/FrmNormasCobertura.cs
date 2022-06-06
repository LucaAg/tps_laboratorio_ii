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
    public partial class FrmNormasCobertura : Form
    {
        PuntoTxt<string> archivoSistAtencion;
        string datosTotalesCobertura;
        string rutaImprimir;
        string rutaSistAtencion;
        string rutaOrientacion;
        string rutaAtencionAmbulatoria;
        string rutaMedicamentos;
        string rutaInternacion;
        /// <summary>
        /// Inicializa en el formulario y el archivo txt de sistema de atención.
        /// </summary>
        public FrmNormasCobertura()
        {
            InitializeComponent();
            this.archivoSistAtencion = new PuntoTxt<string>();
            this.rutaSistAtencion = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"SistAtencion.txt";
            this.rutaOrientacion = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"Orientacion.txt";
            this.rutaAtencionAmbulatoria = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"AtencionAmbulatoria.txt";
            this.rutaMedicamentos = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"Medicamentos.txt";
            this.rutaInternacion = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"Internacion.txt";
            this.rutaImprimir = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"datosCobertura.txt";
        }

        /// <summary>
        /// Carga el rich text box con la info de sistema de cobertura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSistemasAtencion_Click(object sender, EventArgs e)
        {          
            this.rtxDatosCobertura.Text = this.archivoSistAtencion.Leer(rutaSistAtencion);
        }

        /// <summary>
        /// Carga el rich text box con la info de orientación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrientacion_Click(object sender, EventArgs e)
        {         
            this.rtxDatosCobertura.Text = this.archivoSistAtencion.Leer(rutaOrientacion);
        }

        /// <summary>
        /// Carga el rich text box con la info de atención ambulatoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtencionMedicoAmbulatoria_Click(object sender, EventArgs e)
        {          
            this.rtxDatosCobertura.Text = this.archivoSistAtencion.Leer(rutaAtencionAmbulatoria);           
        }

        /// <summary>
        /// Carga el rich text box con la info de medicamentos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicamentos_Click(object sender, EventArgs e)
        {       
            this.rtxDatosCobertura.Text = this.archivoSistAtencion.Leer(rutaMedicamentos);
        }

        /// <summary>
        /// Carga el rich text box con la info de internación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternacion_Click(object sender, EventArgs e)
        {          
            this.rtxDatosCobertura.Text = this.archivoSistAtencion.Leer(rutaInternacion);
        }

        /// <summary>
        /// Carga al rich text box con string vacio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rtxDatosCobertura.Text = string.Empty;
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Imprime todos los datos de los botones del rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {                
                GuardarArchivoCobertura(rutaImprimir, retornarDatosCobertura());
                MessageBox.Show("Se han imprimido los datos correctamente", "Impresion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MiExcepcionArchivoInvalido ex)
            {
                MessageBox.Show(ex.Message, "Error en el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        /// <summary>
        /// Si el archivo existe, lo guardo. Si el archivo no existe, crea una nueva carpeta en el escritorio y guarda los datos del
        /// rich text box.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="contenido">Contenido del archivo</param>
        private void GuardarArchivoCobertura(string ruta, string contenido)
        {
            if (archivoSistAtencion.ValidarSiExisteElArchivo(ruta))
            {
                this.archivoSistAtencion.Guardar(ruta, contenido);
            }
            else
            {
                this.archivoSistAtencion.GuardarComo(ruta, contenido);
            }
        }

        /// <summary>
        /// Almacena en una string todos los datos de los botones del formulario.
        /// </summary>
        /// <returns>Datos cargados de la cobertura</returns>
        private string retornarDatosCobertura()
        {
            this.datosTotalesCobertura = this.archivoSistAtencion.Leer(rutaSistAtencion);
            this.datosTotalesCobertura += this.archivoSistAtencion.Leer(rutaOrientacion);
            this.datosTotalesCobertura += this.archivoSistAtencion.Leer(rutaAtencionAmbulatoria);
            this.datosTotalesCobertura += this.archivoSistAtencion.Leer(rutaMedicamentos);
            this.datosTotalesCobertura += this.archivoSistAtencion.Leer(rutaInternacion);
            return datosTotalesCobertura;
        }
    }
}
