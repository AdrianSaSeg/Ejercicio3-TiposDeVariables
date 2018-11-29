using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_TiposVariablesEstaticas
{
    class CuentaBancaria
    {
        private double saldoPrivado;
        public double saldoPublico;

        //modificar saldo
        public Boolean setSaldo(double s)
        {
            if (s > 100000)
            
                return false;

            else
                saldoPrivado = s;

                return true;
        }

        // Mostrar Saldo
        public void ShowSaldo()
        {
            MessageBox.Show(Convert.ToString(saldoPrivado));
        }
    }
}
