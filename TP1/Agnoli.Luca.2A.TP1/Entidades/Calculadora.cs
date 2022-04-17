using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida el operador pasado por parametro. Si no recibe un operando correcto lo inicializa en +.
        /// </summary>
        /// <param name="operador"> Recibe el operador a validar.</param>
        /// <returns> El operando validado.</returns>
        public static char ValidarOperador(char operador)
        {
            char operadorRetorno;
            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operadorRetorno = '+';
            }
            else
            {
                operadorRetorno = operador;
            }
            return operadorRetorno;
        }
        /// <summary>
        /// Realiza la operacion entre 2 objetos Operando y el operador recibido por parametro.
        /// </summary>
        /// <param name="num1"> Operando num1 que se operara.</param> 
        /// <param name="num2"> Operando num2 que se operara.</param> 
        /// <param name="operador"> Operador que marcara la operacion a realizar.</param>
        /// <returns> El resultado de la operacion.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double valorRetorno;
            switch( Calculadora.ValidarOperador(operador) )
            {
                case '/':
                    valorRetorno = num1 / num2;
                    break;
                case '-':
                    valorRetorno = num1 - num2;
                    break;
                case '*':
                    valorRetorno = num1 * num2;
                    break;
                default:
                    operador = '+';
                    valorRetorno = num1 + num2;
                    break;            
            }
            return valorRetorno;
        }

    }
}
