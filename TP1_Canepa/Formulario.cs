using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Canepa
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// Comando que llama al metodo operar y muestra el resultado en label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);
            this.cmbOperacion.Text = Calculadora.validarOperador(this.cmbOperacion.Text); 
            Numero resultado = new Numero(Calculadora.operar(numero1, numero2,cmbOperacion.Text));
            this.lblResultado.Text = resultado.getNumero().ToString();
                       

        }
        /// <summary>
        ///  Usa el método limpiar para asignar string vacio a cada comando del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cmbOperacion.Text = Calculadora.limpiar();
            this.txtNumero1.Text = Calculadora.limpiar();
            this.txtNumero2.Text = Calculadora.limpiar();
            this.lblResultado.Text = Calculadora.limpiar();
        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias!");
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            this.txtNumero1.Focus();
        }

    }
}
