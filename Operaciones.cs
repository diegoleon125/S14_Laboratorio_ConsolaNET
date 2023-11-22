using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_Laboratorio_ConsolaNET
{
    public class Operaciones
    {
        public static int getEntero(string prefijo, string reemplazo)
        {
            int respuesta = 0;
            bool correcto = false;
            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = int.TryParse(numeroTexto, out respuesta);
                if (!correcto)
                {
                    Console.Clear();
                    Console.Write(reemplazo + "===================================\n");
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);
            return respuesta;
        }
        public static string getTextoPantalla(string prefijo)
        {
            Console.Write(prefijo);
            return Console.ReadLine();
        }
        public static void getTecla(string prefijo)
        {
            Console.Write("===================================\n" + prefijo);
            Console.ReadKey();
        }
        public static int getOpcion(string prefijo, int limite, string reemplazo)
        {
            int respuesta = 0;
            bool correcto = false;
            do
            {
                string numeroTexto = getTextoPantalla("===================================\n" + prefijo);
                correcto = int.TryParse(numeroTexto, out respuesta);
                if (respuesta <= 0 || respuesta > limite) correcto = false;
                if (!correcto)
                {
                    Console.Clear();
                    Console.Write(reemplazo + "===================================\n");
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);
            return respuesta;
        }
        public static string setTitulo(string titulo)
        {
            return "===================================\n" + titulo + "\n" + "===================================\n";
        }
        public static string printTabla(int[] valor1, int[] valor2, int contador)
        {
            string texto = "";
            for (int i = 0; i < contador; i++)
            {
                texto += i.ToString("D4") + "  |  ";
                texto += valor1[i].ToString("D2") + "  |  ";
                string val2texto = "";
                if (valor2[i] == 1) val2texto = "Si";
                if (valor2[i] == 2) val2texto = "No";
                texto += val2texto;
                texto += "\n";
            }
            return texto;
        }
    }
}
