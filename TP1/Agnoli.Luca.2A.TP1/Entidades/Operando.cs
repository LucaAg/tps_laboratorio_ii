using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor que inicializa por default numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que recibe un double para inicializar numero con el valor recibido.
        /// </summary>
        /// <param name="numero"></param> Recibe un double por parametro
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Consturctor que recibe un string, para inicializar el valor de numero con esa string trasnfomada en double.
        /// </summary>
        /// <param name="strNumero"></param> Recibe una string numero.
        public Operando(string strNumero)
        {
            double valorNum;
            double.TryParse(strNumero, out valorNum);
            this.numero = valorNum;
        }
        /// <summary>
        /// Sobrecarga del operador +. Realiza la suma de los numeros entre 2 objetos Operando.
        /// </summary>
        /// <param name="n1"></param> Operando 1 para obtener su numero.
        /// <param name="n2"></param> Operando 2 para obtener su numero.
        /// <returns></returns> La suma de los operandos
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero; //sobrecargo '+'
        }

        /// <summary>
        /// Sobrecarga del operador -. Realiza la resta de los numeros entre 2 objetos Operando.
        /// </summary>
        /// <param name="n1"></param> Operando 1 para obtener su numero.
        /// <param name="n2"></param> Operando 2 para obtener su numero.
        /// <returns></returns> La resta de los operando
        public static double operator -(Operando n1,Operando n2)
        {
            return n1.numero - n2.numero; //sobrecargo '-'
        }

        /// <summary>
        /// Sobrecarga del operador *. Realiza la multiplicacion de los numeros entre 2 objetos Operando.
        /// </summary>
        /// <param name="n1"></param> Operando 1 para obtener su numero.
        /// <param name="n2"></param> Operando 2 para obtener su numero.
        /// <returns></returns> Resultado de la multiplicacion
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado = n1.numero * n2.numero;
            if (resultado == -0)
            {
                resultado = 0;
            }
            return resultado;  //sobrecargo '*'
        }

        /// <summary>
        /// Sobrecarga del operador /. Realiza la division de los numeros entre 2 objetos Operando. Valida que no se pueda dividir por 0.
        /// </summary> 
        /// <param name="n1"></param> Operando 1 para obtener su numero.
        /// <param name="n2"></param> Operando 2 para obtener su numero.
        /// <returns></returns> Resultado de la division o si es el divisor es 0, MinValue.
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno;
            if(n2.numero == 0) // me aseguro que la division no se realice por 0
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero; // si n2.numero es distinto a 0 realizo la division exitosamente
            }
            return retorno; //sobrecargo '/'
        }

        /// <summary>
        /// Valida los operando recibiendolo como string
        /// </summary>
        /// <param name="strNumero"></param> Recibe la string a validar.
        /// <returns></returns> returna 0 en caso de error, true si el operando es valido.
        private static double ValidarOperando(string strNumero)
        {
            double valorString; // variable donde guardaré el out de tryParse
            bool esNum = double.TryParse(strNumero, out valorString); // guardo en un booleano para saber si es numero o no. Guardo el casteo en valorString
            if(esNum == false) // si es false asigno valorString a 0, sino queda ya validado para retornar
            {
                valorString = 0;
            }
            return valorString;
        }

        /// <summary>
        ///  Valida si la string recibida es binario o no.
        /// </summary>
        /// <param name="binario"></param> La string binaria a validar.
        /// <returns></returns> false si no es binario, true si es binario.
        private static bool EsBinario(string binario)
        {
            bool esBin = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    esBin = false;
                    break;
                }        
            }
            return esBin;
        }

        /// <summary>
        /// Transforma un numero decimal a binario, recibiendo un double.
        /// </summary> 
        /// <param name="numero"></param> numero double a convertir.
        /// <returns></returns> retorna la string de un numero binario
        public static string DecimalBinario(double numero)
        {
            double restoNum;
            string numBinarioString = "";
            string nuevaString = "";
            double numeroCast = Math.Abs(numero);
            int numeroInt = (int)numeroCast;
            while (numeroInt != 0) // acumulo los restos en el while
            {
                restoNum = numeroInt % 2;
                numeroInt = numeroInt / 2;
                numBinarioString += restoNum;
            }
            for (int i = numBinarioString.Length - 1; i >= 0; i--) // doy vuelta la string
            {
                nuevaString += numBinarioString[i];
            }
            if(!(Operando.EsBinario(nuevaString))) //llamo a EsBinario. SI es false hay un valor que no es 0 o 1.
            {
                nuevaString = "Valor inválido";
            }
            return nuevaString;
        }
        /// <summary>
        /// transforma un decimal a binario recibiendo una string.
        /// </summary>
        /// <param name="numero"></param> String numero a convertir.
        /// <returns></returns> La string del numero binario
        public static string DecimalBinario(string numero)
        {
            double numeroCasteado = 0;
            if (double.TryParse(numero, out numeroCasteado))
            {
                numero = Operando.DecimalBinario(numeroCasteado);
            }
            else
            {
                numero = "Valor inválido";
            }
            return numero;
        }
        /// <summary>
        /// Transforma una string de numero binario a decimal.
        /// </summary>
        /// <param name="numero"></param> String numero a convertir.
        /// <returns></returns> La string del numero decimal.
        public static string BinarioDecimal(string numero)
        {
            string numAlReves = "";
            double numDecimal = 0;
            string retorno = "";
            if(numero != "Valor inválido")
            {
                for (int i = numero.Length - 1; i >= 0; i--) //doy vuelta la string 
                {
                    numAlReves += numero[i];
                }

                for (int i = 0; i < numAlReves.Length; i++) // cargo a la string con el valor en decimal
                {
                    if (numAlReves[i] == '1')
                    {
                        numDecimal += (double)Math.Pow(2, i);
                    }
                }
                retorno = numDecimal.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }

           
            return retorno;
        }
        /// <summary>
        /// Carga un valor recibido a la variable numero, y valida con la funcion ValidarOperando.
        /// </summary>
        private string Numero
        {
            set { numero = Operando.ValidarOperando(value); } //cargo el valor en 0 si hay error, sino, en el valor recibido.
        }
    }
}
