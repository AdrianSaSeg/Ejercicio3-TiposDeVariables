using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_TiposVariablesEstaticas
{
    class Variables
    {
        public static string nombre;
        internal static int edad;
        private static int numeroPrivate;
        protected static DateTime fechaAlta;
        static int numero;

        public static int accesoVariable(int a)
        {
            numeroPrivate = a;
            return numeroPrivate;
        }


    }

}
