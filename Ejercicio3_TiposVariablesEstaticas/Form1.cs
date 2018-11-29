using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_TiposVariablesEstaticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Como la clase no es estatica, tenemos que crear un objeto
            CuentaBancaria cuenta = new CuentaBancaria();

            /*como el saldoPrivado es private, lo tenemos que introducir y 
            mostrar a traves de un metodo*/
            Boolean comprueba = cuenta.setSaldo(double.Parse(textBox1.Text));
            if (comprueba)
            {
                cuenta.ShowSaldo();
            }
            else
            {
                MessageBox.Show("Error. Introduzca un número menor que 100.000");
            }
            

            //introducimos y mostramos el saldo publico
            cuenta.saldoPublico = double.Parse(textBox2.Text);
            MessageBox.Show(Convert.ToString(cuenta.saldoPublico));
            
        }
    }
}
