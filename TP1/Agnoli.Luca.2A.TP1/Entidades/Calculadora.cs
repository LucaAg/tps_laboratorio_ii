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
        /// <param name="operador"></param> Recibe el operador a validar.
        /// <returns></returns> El operando validado.
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
        /// <param name="num1"></param> Operando num1 que se operara.
        /// <param name="num2"></param> Operando num2 que se operara.
        /// <param name="operador"></param> operador que marcara la operacion a realizar.
        /// <returns></returns> El resultado de la operacion.
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
