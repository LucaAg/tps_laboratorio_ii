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
    public partial class FrmIdSucursal : Form
    {
        Sucursales sucursalBuscada;
        /// <summary>
        /// Inicializa el formulario. A su vez, inicializa la sucursal buscada por ID en null.
        /// </summary>
        public FrmIdSucursal()
        {
            InitializeComponent();
            sucursalBuscada = null;
        }
        /// <summary>
        /// Propiedad que retorna la sucursal filtrada por dni.
        /// </summary>
        public Sucursales SucursalFiltrada
        {
            get { return this.sucursalBuscada; }
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
        /// Llama la metodo AccionBotonConfirmar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                AccionBotonConfirmar();
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
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Busca la sucursal por le ID ingreado. Valida que exista y que los casilleros del txtId sean validos.
        /// </summary>
        private void AccionBotonConfirmar()
        {
            int idIngreado;
            if (txtId.Text != string.Empty)
            {
                idIngreado = Convert.ToInt32(txtId.Text);
                sucursalBuscada = idIngreado.LeerDatosPorId();
                if(sucursalBuscada is not null)
                {
                    MessageBox.Show("Sucursal encontrada con exito", "Filtrar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    throw new SucursalNulaException("La sucursal no existe", "FrmIdSucursal.cs", "AccionBotonConfirmar");
                }             
            }
            else
            {
                throw new CasillerosEnBlancoException("El texto no puede estar en blanco", "FrmModificar.cs", "AccionConfirmarClick");
            }
        }

        /// <summary>
        /// Valida que en el txtId no ingresen valores que no sean números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se pueden ingresar letras en el DNI", "Error en en ingreso de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
