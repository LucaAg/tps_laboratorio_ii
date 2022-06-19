using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaIMA;


namespace FormsTP4
{
    public partial class FrmMenuIma : Form
    {
        private AdministracionPersonas administracion;
        private PuntoXml<List<Persona>> listaUsuarios;
        private event Action OnTiempoFinalizado;
        private event Action<int> OnTiempoRestante;
        private string ruta;
        /// <summary>
        /// Inicializa el formulario, el temportizador, la administración, la lista en formato xml y asigna la ruta.
        /// </summary>
        public FrmMenuIma()
        {
            InitializeComponent();
            administracion = new AdministracionPersonas();
            this.listaUsuarios = new PuntoXml<List<Persona>>();
            ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"clientes.xml";
            OnTiempoRestante += MostrarTiempoRestante;
            OnTiempoFinalizado += NotificarJornadaCompleta;
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
            this.ComenzarCronometro(120);
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

        /// <summary>
        /// Lanza un message box cuando la mitad de la jornada esta completa.
        /// </summary>
        /// <param name="segundos"></param>
        private void MostrarTiempoRestante(int segundos)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Action<int> delegadoMitadJornada = MostrarTiempoRestante;
                    Invoke(delegadoMitadJornada, segundos);
                }
                else
                {
                    lblCronometro.Text = $"{segundos}";
                    pbrTemporizador.Increment(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Notifica cuando la jornada esta completada.
        /// </summary>
        private static void NotificarJornadaCompleta()
        {
            MessageBox.Show($"Felicidades {Environment.UserName}, has completado la jornada de trabajo");
        }
        /// <summary>
        /// Funcion que llama a los delegados/eventos para iniciar el cronometro.
        /// </summary>
        /// <param name="cancellation"></param>
        /// <param name="segundosTiempoJornada"></param>
        private void AccionCronometro(CancellationTokenSource cancellation,int segundosTiempoJornada)
        {
            try
            {
                do
                {
                    if (OnTiempoRestante is not null)
                    {
                        OnTiempoRestante.Invoke(segundosTiempoJornada);
                    }
                    segundosTiempoJornada--;
                    Thread.Sleep(1000);
                } while (segundosTiempoJornada >= 0 && !cancellation.IsCancellationRequested);
                if (OnTiempoFinalizado is not null)
                {
                    OnTiempoFinalizado.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        /// <summary>
        /// Comienza la tarea con el metodo AccionCronometro.
        /// Descuenta el cronometro, y asciende la barra segun el tiempo.
        /// </summary>
        /// <param name="segundosTiempoJornada"></param>
        public void ComenzarCronometro(int segundosTiempoJornada)
        {
            //int numeroBarra = 0;
            try
            {
                CancellationTokenSource cancellation;
                cancellation = new CancellationTokenSource();
                CancellationToken token = cancellation.Token;
                Task.Run(() => AccionCronometro(cancellation, segundosTiempoJornada), token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
