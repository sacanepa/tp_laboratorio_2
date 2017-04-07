using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Canepa
{
    public class Calculadora
    {
        #region Methods
        /// <summary>
        /// metodo que efectúa el calculo correcto elegido por el ususario.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            
            switch (operador)
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() != 0)
                    {
                        resultado = numero1.getNumero() / numero2.getNumero();
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
            }
            return resultado;
        }

        public static string limpiar()
        {
            return "";
        }
        /// <summary>
        /// metodo que valida si el operador elegido/ingresado por el usuario es valido para operar. Si no es retorna +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            if ((operador != "+") && (operador != "-") && (operador != "*") && (operador != "/"))
                operador = "+";
            
            return operador;
        }
        
        #endregion

    }
}
