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
    public partial class FrmModificarDatos : Form
    {
        private AdministracionPersonas administracion;
        private Persona personaAModificar;
        private PuntoXml<List<Persona>> listaPersonasImprimir;
        /// <summary>
        /// Inicializa el formulario, la administración, la persona y la lista de personas en formato xml.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="persona"></param>
        /// <param name="listaPersonasImpresa"></param>
        public FrmModificarDatos(AdministracionPersonas admin,Persona persona, PuntoXml<List<Persona>> listaPersonasImpresa)
        {
            InitializeComponent();
            this.administracion = admin;
            this.personaAModificar = persona;
            this.listaPersonasImprimir = listaPersonasImpresa;
        }
        /// <summary>
        /// Evento load, que llama al metodo cargarPlaceHolderText.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificarDatos_Load(object sender, EventArgs e)
        {
            cargarPlaceHolderText(personaAModificar);
        }
        /// <summary>
        /// Carga los datos del formulario, con los datos de la persona a modificar.
        /// </summary>
        /// <param name="persona"></param>
        private void cargarPlaceHolderText(Persona persona)
        {
            txtDni.PlaceholderText = persona.Dni.ToString();
            txtApellido.Text = persona.Apellido;
            txtNombre.Text = persona.Nombre;
            txtDireccion.Text = persona.Direccion;
            txtTelefono.Text = persona.NumeroTelefonico.ToString();
            dtpFechaNacimiento.Value = persona.FechaNacimiento;
            nudEdad.Value = persona.Edad;
            activarRadioButtonsPlan(persona);
            establecerGrupoSanguineo(persona);
            activarRadioGenero(persona);
        }
        /// <summary>
        /// Carga los radio boton género con el genero seleccionado anteriormente en alta.
        /// </summary>
        /// <param name="persona"></param>
        public void activarRadioGenero(Persona persona)
        {
            if(persona.Sexo == rdbMasculino.Text)
            {
                rdbMasculino.Checked = true;
            }
            else if(persona.Sexo == rdbFemenino.Text)
            {
                rdbFemenino.Checked = true;
            }
            else
            {
                rdbNoBinario.Checked = true;
            }
        }
        /// <summary>
        /// Actualiza los datos de la persona, con los nuevos ingresados.
        /// </summary>
        /// <param name="persona"></param>
        public void actualizarDatosPersona(Persona persona)
        {
            if(persona is not null)
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.FechaNacimiento = dtpFechaNacimiento.Value;
                persona.Edad = (int)nudEdad.Value;
                persona.Dni = Convert.ToInt32(txtDni.PlaceholderText);
                persona.Sexo = obtenerGeneroPersona();
                persona.GrupoSanguineo = ObtenerGrupoSanguineo();
                persona.Direccion = txtDireccion.Text;
                persona.NumeroTelefonico = Convert.ToInt32(txtTelefono.Text);
                persona.Plan = obtenerPlan();
            }          
        }

        /// <summary>
        /// Activa los radio boton con el plan seleccionado anteriormente en alta, según la persona.
        /// </summary>
        /// <param name="persona"></param>
        public void activarRadioButtonsPlan(Persona persona)
        {
            Plan planPersona = persona.Plan;
            if (planPersona.TipoPlan == "PlanClasico")
            {
                rdbPlanClasico.Checked = true;
            }
            else if (planPersona.TipoPlan == "PlanPlus")
            {
                rdbPlanPlus.Checked = true;
            }
            else 
            {
                rdbPlanPremiun.Checked = true;
            }           
        }
        /// <summary>
        /// Carga la listBox de grupo sanguineo, según el el grupo sanguineo establecido en alta.
        /// </summary>
        /// <param name="persona"></param>
        public void establecerGrupoSanguineo(Persona persona)
        {
            cmbGrupoSanguineo.Text = persona.GrupoSanguineo;
        }
       /// <summary>
       /// Si confirma el usuario, llama al metodo AccionConfirmarClick.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult accionConfirmar;
                accionConfirmar = MessageBox.Show("Confirma la modificación", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(accionConfirmar == DialogResult.Yes)
                {
                    AccionConfirmarClick();
                }             
            }
            catch(MiExcepcionCasillerosEnBlanco ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(MiExcepcionPersonaNula ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Verifica que los textos esten correctos, y si la persona existe modifica la persona en la lista y actualiza el archivo xml.
        /// </summary>
        private void AccionConfirmarClick()
        {
            if (VerificarTextBoxs())
            {
                int indice = 0;
                if (AdministracionPersonas.checkearPersonaEnLista(administracion, personaAModificar) && listaPersonasImprimir is not null)
                {
                    if(personaAModificar is not null)
                    {
                        indice = administracion.ListaPersonas.IndexOf(personaAModificar);
                        string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"clientes.xml";
                        this.actualizarDatosPersona(personaAModificar);
                        administracion.ListaPersonas[indice] = personaAModificar;
                        this.listaPersonasImprimir.Guardar(ruta, administracion.ListaPersonas);
                        MessageBox.Show($"MODIFICACION EXITOSA\n{personaAModificar.ToString()}", "Modificacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        throw new MiExcepcionPersonaNula("La persona no se encuentra en el sistema, o es nula", "FrmModificarDatos.cs", "AccionComfirmarClick");
                    }
                }
                else
                {
                    MessageBox.Show($"No se ha podido realizar la modificacion", "Modificacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new MiExcepcionCasillerosEnBlanco("No puede haber casilleros en blanco", "FrmModificarDatos.cs", "AccionComfirmarClick");
            }
        }
        /// <summary>
        /// Llama al metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Asigna los text box en string.empty
        /// </summary>
        private void Limpiar()
        {
            this.txtDni.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.nudEdad.Value = 0;
        }
        /// <summary>
        /// Busca el genero de la persona segun corresponda por el radio boton
        /// </summary>
        /// <returns>String con el genero correspondiente</returns>
        private string obtenerGeneroPersona()
        {
            string genero = string.Empty;
            if (rdbMasculino.Checked)
            {
                genero = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked)
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
        /// Obtiene el grupo sanguineo según lo ingresado en el list box
        /// </summary>
        /// <returns>String con el grupo sanguíneo</returns>
        private string ObtenerGrupoSanguineo()
        {
            int indice = cmbGrupoSanguineo.SelectedIndex;
            if (indice == -1)
            {
                indice = 0;
            }
            string grupoSanguineo = cmbGrupoSanguineo.Items[indice].ToString();
            return grupoSanguineo;
        }
        /// <summary>
        /// Busca el plan según el radio boton seleccionado
        /// </summary>
        /// <returns>Plan según corresponda</returns>
        public Plan obtenerPlan()
        {
            Plan PlanAuxiliar = null;
            if (this.rdbPlanClasico.Checked)
            {
                PlanAuxiliar = new PlanClasico(3500, "Plan Clasico", "ST", "ST");
            }
            else if (this.rdbPlanPlus.Checked)
            {
                PlanAuxiliar = new PlanPlus(6000, "Plan Plus", "ST", "ST");
            }
            else if (this.rdbPlanPremiun.Checked)
            {
                PlanAuxiliar = new PlanPremiun(15000, "Plan Premiun", "ST", "ST");
            }
            return PlanAuxiliar;
        }
        /// <summary>
        /// Llama al metodo close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Verifica que sea solo letras, espacios y pueda borrar.
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
        /// Verifica que los text box no esten vacíos.
        /// </summary>
        /// <returns>true si estan correctos, caso contrario false</returns>
        private bool VerificarTextBoxs()
        {
            bool estanCargados = false;
            if (txtApellido.Text != string.Empty && txtDni.PlaceholderText != string.Empty && txtNombre.Text != string.Empty &&
                txtDireccion.Text != string.Empty && txtTelefono.Text != string.Empty)
            {
                estanCargados = true;
            }
            return estanCargados;
        }
        /// <summary>
        /// Verifica que sea solo letras, espacios y pueda borrar.
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
        /// Verifica que sea solo letras, nùmeros, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar letras y numeros en la dirección", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Verifica que sea números y que pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el número de telefono", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Cambia la primera letra de todas las palabras a mayus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            this.txtNombre.SelectionStart = this.txtNombre.Text.Length;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            this.txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            this.txtApellido.SelectionStart = this.txtApellido.Text.Length;
        }
    }
}
