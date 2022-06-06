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
    public partial class FrmModificar : Form
    {
        AdministracionPersonas administracion;
        Persona personaBuscada;
        private PuntoXml<List<Persona>> listaPersonasImprimir;
        /// <summary>
        /// Inicializa el formulario, la administración y la lsita en formato xml.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="listaPersonasImpresa"></param>
        public FrmModificar(AdministracionPersonas admin, PuntoXml<List<Persona>> listaPersonasImpresa)
        {
            InitializeComponent();
            this.administracion = admin;
            this.listaPersonasImprimir = listaPersonasImpresa;
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna una persona.
        /// </summary>
        public  Persona PersonaBuscada
        {
            get
            {
                return this.personaBuscada;
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Llama al metodo AccionConfirmarClick y caputara las posibles excepciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {      
            try
            {
                AccionConfirmarClick();
            }
            catch (MiExcepcionPersonaNula ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(MiExcepcionCasillerosEnBlanco ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Error al modificar",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error al modificar",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
        /// Valida el ingreso incorrecto de datos.
        /// Si la persona existe, instancia un FrmModificarDatos.
        /// Arroja las excepciones MiExcepcionPersonaNula y MiExcepcionCasillerosEnBlanco.
        /// </summary>
        private void AccionConfirmarClick()
        {
            if (txtDniSolicitado.Text != string.Empty)
            {
                if(txtDniSolicitado.Text.Length == 8)
                {
                    personaBuscada = administracion.BuscarPorDni(administracion, Convert.ToInt32(txtDniSolicitado.Text));
                    if (personaBuscada is not null)
                    {
                        if (personaBuscada.EstadoPlan)
                        {
                            FrmModificarDatos formModificar = new FrmModificarDatos(administracion, personaBuscada, listaPersonasImprimir);
                            formModificar.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show($"La persona no se encuentra activa en el sistema ", "Error al modificar",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        throw new MiExcepcionPersonaNula("Persona nula, no se encuentra en el sistema", "FrmModificar.cs", "AccionConfirmarClick");
                    }
                }
                else
                {
                    MessageBox.Show($"El texto no puede contener menos de 8 caracteres", "Error al modificar",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new MiExcepcionCasillerosEnBlanco("El texto no puede estar en blanco", "FrmModificar.cs", "AccionConfirmarClick");
            }
        }

        /// <summary>
        /// Valida que en el txtDni no ingresen valores que no sean números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDniSolicitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("No se pueden ingresar letras en el DNI", "Error en en ingreso de datos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
