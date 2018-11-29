using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Ejercicio3_TiposVariablesEstaticas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Variables.nombre = "Pepe";
            Variables.edad = 20;
           /* Variables.disponible = true;
            Variables.fechaAlta;
            Variables.numero;*/

            /*int res = Variables.accesoVariable(3);
            MessageBox.Show(Convert.ToString(res));*/
        }
    }
}
