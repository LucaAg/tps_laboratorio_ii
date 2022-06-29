using BibliotecaIMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTP4
{
    public partial class FrmAltaSucursal : Form
    {
        List<Sucursales> listaSucursales;
        /// <summary>
        /// Inicializa los formularios y la lista de sucursales.
        /// </summary>
        public FrmAltaSucursal(List<Sucursales> listaSucursalesRecibida)
        {
            InitializeComponent();
            this.listaSucursales = listaSucursalesRecibida;
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
        /// Carga los text box en casilleros vacios.
        /// </summary>
        private void Limpiar()
        {
            txtDireccion.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
        }
        /// <summary>
        /// Genera que la primer letra de cada palabra sea mayuscula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            this.txtLocalidad.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLocalidad.Text);
            this.txtLocalidad.SelectionStart = this.txtLocalidad.Text.Length;
        }
        /// <summary>
        /// Genera que la primer letra de cada palabra sea mayuscula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            this.txtDireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDireccion.Text);
            this.txtDireccion.SelectionStart = this.txtDireccion.Text.Length;
        }
        /// <summary>
        /// Valida que sea solo números y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el Contacto", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que sea solo letras, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar numeros en la localidad", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que sea solo letras, numeros, espacios y pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar numeros o letras", "Error en en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Llama al metodo AccionDarAlta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                AccionDarAlta();
            }
            catch (CasillerosEnBlancoException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SucursalNulaException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que los datos sean correctos, y da de alta una nueva sucursal agrengandola a la base 
        /// de datos.
        /// </summary>
        private void AccionDarAlta()
        {
            if (VerificarTextBoxs())
            {
                Sucursales sucursalNueva = InstanciarSucursal();
                if(sucursalNueva is not null)
                {
                    if (listaSucursales != sucursalNueva)
                    {
                        listaSucursales.Add(sucursalNueva);                        
                        if(listaSucursales == sucursalNueva)
                        {
                            GestorSQL.Alta(sucursalNueva);
                            MessageBox.Show("Sucursal agregada exitosamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la sucursal", "Error en alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La sucursal ya se encuentra en la lista", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new SucursalNulaException("La sucursal no existe", "FrmAltaSucursal.cs", "AccionDarAlta");
                }              
            }
            else
            {
                throw new CasillerosEnBlancoException("Los campos no pueden estas vacios", "FrmAltaSucursal ", "AccionDarAlta");
            }
        }

        /// <summary>
        /// Instancia un nuevo objeto Sucursales.
        /// </summary>
        /// <returns></returns>
        private Sucursales InstanciarSucursal()
        {
            Sucursales sucursalNueva = new Sucursales(txtLocalidad.Text, Convert.ToDouble(txtContacto.Text), txtDireccion.Text);
            return sucursalNueva;
        }

        /// <summary>
        /// Verifica que los text box no esten vacios.
        /// </summary>
        /// <returns></returns>
        private bool VerificarTextBoxs()
        {
            bool estanCargados = false;
            if (txtContacto.Text != string.Empty && txtDireccion.Text != string.Empty && 
                txtLocalidad.Text != string.Empty)
            {
                estanCargados = true;
            }
            return estanCargados;
        }
    }
}
