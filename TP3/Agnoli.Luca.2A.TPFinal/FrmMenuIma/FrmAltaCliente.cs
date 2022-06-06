using BibliotecaIMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuIma
{
    public partial class FrmAltaCliente : Form
    {
        private Plan plan;
        private AdministracionPersonas personasEnSistema;
        private PuntoXml<List<Persona>> listaPersonasImprimir;
        private string ruta;
        /// <summary>
        /// Inicializa el formulario, la lista de personas en formato xml y la administracion.
        /// </summary>
        /// <param name="admin">Recibe una administracion central</param>
        public FrmAltaCliente(AdministracionPersonas admin)
        {
            InitializeComponent();
            this.personasEnSistema = admin;
            this.listaPersonasImprimir = new PuntoXml<List<Persona>>();
            this.ruta = $"{AppDomain.CurrentDomain.BaseDirectory}"+@"clientes.xml";
        }
        /// <summary>
        /// Propiedad de solo lectura, que retorna la lista de personas en formato xml.
        /// </summary>
        public AdministracionPersonas PersonasSistema
        {
            get
            {
                return this.personasEnSistema;
            }
        }
        /// <summary>
        /// Propiedad que retorna un plan, y a la vez permite asignarle valores.
        /// </summary>
        private Plan PlanAuxiliar
        {
            get 
            {
                return this.plan;
            }
            set
            {
                this.plan = value;
            }
        }
        /// <summary>
        /// Evento load del formulario, se instancia un plan y se carga el rich text box con el metodo mostrarDatosPlan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            PlanAuxiliar = InstanciarPlan();
            this.rtxDatosPlan.Text = MostrarDatosPlan(PlanAuxiliar);
        }
        /// <summary>
        /// Muestra los datos segun el plan correspondiente
        /// </summary>
        /// <param name="tipoPlan"></param>
        /// <returns>String con datos del plan</returns>
        public string MostrarDatosPlan(Plan tipoPlan)
        {
            string datosRetorno = string.Empty;
            switch (tipoPlan)
            {
                case PlanClasico:
                    datosRetorno = tipoPlan.ToString();
                    break;
                case PlanPlus:
                    datosRetorno = tipoPlan.ToString();
                    break;
                case PlanPremiun:
                    datosRetorno = tipoPlan.ToString();
                    break;
            }
            return datosRetorno;
        }
        /// <summary>
        /// Instancia un plan según corresponda
        /// </summary>
        /// <returns>Plan correspondiente</returns>
        public Plan InstanciarPlan()
        {
            PlanAuxiliar = null;
            if(this.rdbPlanClasico.Checked)
            {
                plan = new PlanClasico(3500, "Plan Clasico", "ST", "ST");
            }
            else if(this.rdbPlanPlus.Checked)
            {
                plan = new PlanPlus(6000, "Plan Plus", "ST", "ST");
            }
            else if(this.rdbPlanPremiun.Checked)
            {
                plan = new PlanPremiun(15000, "Plan Premiun", "ST", "ST");
            }
            return plan;
        }
        /// <summary>
        /// Cuando se acciona el radio buton de plan plus, muestra sus datos llamando al metodo mostrarDatosPlan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbPlanPlus_CheckedChanged(object sender, EventArgs e)
        {
            PlanAuxiliar = InstanciarPlan();
            this.rtxDatosPlan.Text = MostrarDatosPlan(PlanAuxiliar);
        }
        /// <summary>
        /// Cuando se acciona el radio buton de plan premiun, muestra sus datos llamando al metodo mostrarDatosPlan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbPlanPremiun_CheckedChanged(object sender, EventArgs e)
        {
            PlanAuxiliar = InstanciarPlan();
            this.rtxDatosPlan.Text = MostrarDatosPlan(PlanAuxiliar);
        }
        /// <summary>
        /// Da de alta una persona a la lista de la administración y la guarda en el archivo xml, si es válida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                AccionDarAltaCLick();
            }
            catch(MiExcepcionCasillerosEnBlanco ex)
            {
                MessageBox.Show(ex.Message, "Error, no puede poseer casilleros en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        /// <summary>
        /// Llama al metodo InstanciarPersona
        /// </summary>
        private void AccionDarAltaCLick()
        {
            if (VerificarTextBoxs())
            {
                Persona personaAlta = InstanciarPersona();
                Persona personaAuxiliar;
                personaAuxiliar = this.personasEnSistema.BuscarPorDni(personasEnSistema, personaAlta.Dni);
                if(personaAuxiliar is null)
                {
                    if (personasEnSistema.ListaPersonas is not null)
                    {
                        this.personasEnSistema.ListaPersonas.Add(personaAlta);
                        if (AdministracionPersonas.checkearPersonaEnLista(personasEnSistema, personaAlta))
                        {
                            listaPersonasImprimir.Guardar($"{this.ruta}", personasEnSistema.ListaPersonas);
                            MessageBox.Show($"ALTA COMPLETADA\n{personaAlta.ToString()}", "Alta exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error la persona no esta en la lista", "Error en lista",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error valor nulo en lista", "Error en lista",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult consultaEstado;
                    if(personaAuxiliar.EstadoPlan == false)
                    {
                        consultaEstado = MessageBox.Show("La persona ya se encuentra registrada en el sistema, desea \nque vuelva a ser parte de nuestra sucursal?", "Persona ya registrada",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (consultaEstado == DialogResult.Yes)
                        {
                            personaAuxiliar.EstadoPlan = true;                          
                        }
                    }
                    else
                    {
                        MessageBox.Show("La persona ya se encuentra registrada en el sistema y esta activa", "Persona activa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Close();
                }
            }
            else
            {
                throw new MiExcepcionCasillerosEnBlanco("Los campos no pueden estas vacios", "FrmAltaCliente", "AccionDarAltaCLick");
            }
        }

        /// <summary>
        /// Instancia un objeto persona.
        /// </summary>
        /// <returns></returns>
        private Persona InstanciarPersona()
        {
            Plan planSeleccionado = InstanciarPlan();
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text, dtpFechaNacimiento.Value, (int)nudEdad.Value,
               Convert.ToInt32(txtDni.Text), ObtenerGeneroPersona(), ObtenerGrupoSanguineo(), txtDireccion.Text, Convert.ToDouble(txtTelefono.Text) ,planSeleccionado,true);
            return persona;
        }
        /// <summary>
        /// Segun el radio boton seleccionado retorna el genero de la persona.
        /// </summary>
        /// <returns>String con el genero</returns>
        private string ObtenerGeneroPersona()
        {
            string genero = string.Empty;
            if(rdbMasculino.Checked)
            {
                genero = rdbMasculino.Text;
            }
            else if(rdbFemenino.Checked)
            {
                genero = rdbFemenino.Text;
            }
            else
            {
                genero = rdbNoBinario.Text;
            }
            return genero;
        }
        /// <summary>
        /// Segun lo que se seleccione en el comboBox devuelve el grupo sanguineo.
        /// </summary>
        /// <returns>String con el grupo sanguineo</returns>
        private string ObtenerGrupoSanguineo()
        {
            int indice = cmbGrupoSanguineo.SelectedIndex;
            if(indice == -1)
            {
                indice = 0;
            }
            string grupoSanguineo = cmbGrupoSanguineo.Items[indice].ToString();
            return grupoSanguineo;
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
        /// Llama la metodo limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Asigna los text box a string.empty.
        /// </summary>
        private void Limpiar()
        {
            txtDni.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            nudEdad.Value = 0;
        }
        /// <summary>
        /// Verifica que los text box no esten vacios.
        /// </summary>
        /// <returns></returns>
        private bool VerificarTextBoxs()
        {
            bool estanCargados = false;
            if(txtApellido.Text != string.Empty && txtDni.Text != string.Empty && txtNombre.Text != string.Empty &&
                txtDireccion.Text != string.Empty && txtTelefono.Text != string.Empty)
            {
                estanCargados = true;
            }
            return estanCargados;
        }
        /// <summary>
        /// Valida que sea solo números y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el DNI", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;             
            }
        }
        /// <summary>
        /// Valida que sea solo letras, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar numeros en el Nombre", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que sea solo letras, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar numeros en el Apellido", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que sea solo letras, números, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar letras y numeros en la dirección", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }
        /// <summary>
        /// Valida que solo sea números y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el número de telefono", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Cambia la primera letra de cada palabra a mayúscula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            this.txtNombre.SelectionStart = this.txtNombre.Text.Length;
        }
        /// <summary>
        /// Cambia la primera letra de cada palabra a mayúscula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            this.txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            this.txtApellido.SelectionStart = this.txtApellido.Text.Length;
        }
    }
}
