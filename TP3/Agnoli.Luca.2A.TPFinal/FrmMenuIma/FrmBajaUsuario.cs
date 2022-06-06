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
    public partial class FrmBajaUsuario : Form
    {
        private AdministracionPersonas administracion;
        private Persona personaBaja;
        private PuntoXml<List<Persona>> listaPersonasImprimir;
        private string ruta;

        /// <summary>
        /// Inicializa el formulario, la administracio y la lista en formato xml.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="listaImpresa"></param>
        public FrmBajaUsuario(AdministracionPersonas admin, PuntoXml<List<Persona>> listaImpresa)
        {
            InitializeComponent();
            this.administracion = admin;
            this.listaPersonasImprimir = listaImpresa;
            this.ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"clientes.xml";
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDelMessage;
            resultadoDelMessage = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultadoDelMessage == DialogResult.Yes)
            {
                Close();
            }          
        }
        /// <summary>
        /// Da de baja a un usuario cambiando su estado de activo a false, llamando al metodo AccionConfirmarClick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultadoDelMessage;
                resultadoDelMessage = MessageBox.Show("Confirma la baja?", "Baja persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultadoDelMessage == DialogResult.Yes)
                {
                    AccionConfirmarClick();
                }
            }
            catch (MiExcepcionPersonaNula ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Persona nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(MiExcepcionCasillerosEnBlanco ex)
            {
                MessageBox.Show($"{ex.ToString()}", "Persona nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Valida que la persona sea válida. Cambia el estado de la persona a false y actualiza la lista.
        /// </summary>
        private void AccionConfirmarClick()
        {
            if (txtDniSolicitado.Text.Length == 8 && !string.IsNullOrWhiteSpace(txtDniSolicitado.Text))
            {
                personaBaja = administracion.BuscarPorDni(administracion, Convert.ToInt32(txtDniSolicitado.Text));
                if (personaBaja is not null)
                {
                    personaBaja.EstadoPlan = false;
                    listaPersonasImprimir.Guardar($"{this.ruta}", administracion.ListaPersonas);
                    MessageBox.Show($"Se ha dado de baja exitosamente! ", "Baja usuario",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    throw new MiExcepcionPersonaNula("La persona no se encuentra en el sistema o es nula", "FrmClientesActivos.cs", "btnBuscarPorDni_Click");
                }              
            }
            else
            {
                throw new MiExcepcionCasillerosEnBlanco("Los campos no pueden estar en blanco o tener espacios", "FrmBajaUsuario", "AccionConfirmarCLick()");
            }
        }
        /// <summary>
        /// Válida que sea solo numeros y que pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDniSolicitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el DNI", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
