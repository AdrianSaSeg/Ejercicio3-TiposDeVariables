using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_FuncionesBasic
{
    class Funciones
    {
        public static int suma (int x, int y)
        {
            return x + y;
        }

        public static double calculaIRPF(double sueldoBruto, double porcentaje)
        {
            return (sueldoBruto * porcentaje) / 100;
        }

        public static Boolean eliminarUsuario(int id, string nombre)
        {
            return true;
        }

        public static void imprimirTexto(string texto)
        {

        }

        public static void insertarNoticia(int id_noticia, DateTime fecha)
        {

        }
        
        public static int CambioValor(ref int a, int b)
        {
            a = 1;
            return b;
        }
    }
}
