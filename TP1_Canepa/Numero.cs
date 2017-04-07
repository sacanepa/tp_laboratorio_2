using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Canepa
{
    public class Numero
    {
        #region Fields
        private double _numero;
        #endregion

        #region Methods
        /// <summary>
        /// constructor por defecto que inicializa el objeto numero en 0
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }
        /// <summary>
        /// asigna el numero en formato string al field
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            setNumero(strNumero);    
        }
        /// <summary>
        /// asigna numero double al field numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._numero = numero;
        }
        /// <summary>
        /// metodo que parsea el string ingresado por el ususario a double. Si no puede hacerlo retorna 0
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double validarNumero(string numeroString)
        {
            double auxNumero = 0;
            if (!double.TryParse(numeroString, out auxNumero))
            {
                return 0;
            }
            else
            {
                double.TryParse(numeroString, out auxNumero);
                return auxNumero;
            }
        }
        /// <summary>
        /// metodo set, llama a validarNumero y lo asigna al field
        /// </summary>
        private void setNumero(string numeroString)
        {
            this._numero = validarNumero(numeroString);
        }
        
        /// <summary>
        /// metodo que retorna el numero en el field
        /// </summary>
        public double getNumero()
        {

            return this._numero;
        }

        

        #endregion

    }
}
