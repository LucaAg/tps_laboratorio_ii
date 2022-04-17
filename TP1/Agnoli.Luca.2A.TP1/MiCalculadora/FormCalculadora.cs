using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculora : Form
    {
        /// <summary>
        /// Constructor que inicializa el form
        /// </summary>
        public FormCalculora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia si hay valores cargados al inicio. A su vez, carga los operadores del comboBox.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void FormCalculora_Load(object sender, EventArgs e)
        {
            Limpiar();
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            //cmbOperador.SelectedIndex = 0
        }
        /// <summary>
        /// Al hacer click limpia los operando, operadores y resultados.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Asigna valores vacio y 0 a los operando, operadores y resultados.
        /// </summary>
        public void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
        }
        /// <summary>
        /// Realiza la operacion entre 2 numeros recibidos por el textbox, dependiendo de su operador
        /// </summary>
        /// <param name="numero1">String de numero para operar</param>
        /// <param name="numero2"> String de numero para operar</param> 
        /// <param name="operador"> Operador que asigna que tipo de operacion se realizara.</param> 
        /// <returns> El resultado de la operacion.</returns> 
        private static double Operar(string numero1, string numero2,string operador)
        {
            double resultado;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char ope1 = Convert.ToChar(operador);
            resultado = Calculadora.Operar(num1, num2, ope1);
           
            return Calculadora.Operar(num1, num2, ope1); 
        }

        /// <summary>
        /// Al hacer click realiza la operacion asignada. Si el operador es vacio toma por default la operacion +.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char ope;
            if (string.IsNullOrEmpty(cmbOperador.Text))
            {
                ope = '+';
            }
            else
            {
                ope = Convert.ToChar(cmbOperador.Text);
            }
            txtNumero1.Text = txtNumero1.Text.Replace(".", ",");
            txtNumero2.Text = txtNumero2.Text.Replace(".", ",");
            Operando num1 = new Operando(txtNumero1.Text);
            Operando num2 = new Operando(txtNumero2.Text);
            lblResultado.Text = Calculadora.Operar(num1, num2, ope).ToString();

            if ((string.IsNullOrWhiteSpace(txtNumero1.Text)) || !(double.TryParse(txtNumero1.Text, out _)))
            {
                txtNumero1.Text = "0";
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text) || !(double.TryParse(txtNumero2.Text, out _)))
            {
                txtNumero2.Text = "0";
            }

            lstOperaciones.Items.Add($"{txtNumero1.Text} {ope} {txtNumero2.Text} = {lblResultado.Text}");
        }

        /// <summary>
        /// Al hacer click convierte el resultado de las operaciones a binario.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
           // lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }
        /// <summary>
        /// Al hacre click convierte el resultaod de las operaciones a decimal.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
        /// <summary>
        /// Cierra el programa.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Pregunta al usuario si quiere cerrar el progama o continuar en el.
        /// </summary>
        /// <param name="sender"> De clase System object, recibe al iniciador del evento</param>
        /// <param name="e"> Datos del evento</param>
        private void FormCalculora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultadoMensaje;
            e.Cancel = true;
            resultadoMensaje = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultadoMensaje == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}
