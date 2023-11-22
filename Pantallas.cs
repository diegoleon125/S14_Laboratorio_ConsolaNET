using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace S14_Laboratorio_ConsolaNET
{
    public class Pantallas
    {
        public static int[] Edad = new int[1000];
        public static int[] Vacunado = new int[1000];
        public static int cont = 0;
        public static int MenuPrincipal()
        {
            string texto = Operaciones.setTitulo("Encuesta Covid-19") +
                "1: Realizar Encuesta\n" +
                "2: Mostrar Datos de la encuesta\n" +
                "3: Mostrar Resultados\n" +
                "4: Buscar Personas por edad\n" +
                "5: Salir\n";
            Console.Write(texto);
            int opcion = Operaciones.getOpcion("Ingrese una opción: ",5 ,texto);
            return opcion;
        }
        public static int RealizarEncuesta()
        {
            string texto1 = Operaciones.setTitulo("Encuesta de vacunación");
            Console.Write(texto1);
            int edad = Operaciones.getEntero("¿Qué edad tienes?: ", texto1);
            string texto2 = "¿Qué edad tienes?: " + edad + "\n";
            string texto3 = "Te has vacunado\n" +
                "1: Sí\n" +
                "2: No\n";
            Console.Write(texto3);
            int encuesta = Operaciones.getOpcion("Ingrese una opción: ",2 , texto1 + texto2 + texto3);
            Edad[cont] = edad;
            Vacunado[cont] = encuesta;
            Console.Clear();
            string texto4 = "\n\n ¡Gracias por participar!\n\n\n";
            Console.Write(texto1 + texto4);
            Operaciones.getTecla("Presione una tecla ...");
            cont++;
            return 0;
        }
        public static int DatosEncuesta()
        {
            string texto = Operaciones.setTitulo("Datos de la encuesta");
            texto += "\nID    | Edad | Vacunado\n=======================\n";
            texto += Operaciones.printTabla(Edad, Vacunado, cont) + "\n";
            Console.Write(texto);
            Operaciones.getTecla("Presione una tecla para regresar ...");
            return 0;
        }
        public static int ResultadosEncuesta()
        {
            string texto = Operaciones.setTitulo("Resultados de la encuesta");
            if (cont == 0)
            {
                texto += "\nNo hay datos\n\n";
                Console.Write(texto);
            }
            else
            {
                int si_vacunado = 0;
                int no_vacunado = 0;
                int[] rangoedad = new int[6];
                for (int i = 0; i < cont; i++)
                {
                    if (Vacunado[i] == 1) si_vacunado++;
                    else if (Vacunado[i] == 2) no_vacunado++;
                    if (Edad[i] <= 20) rangoedad[0]++;
                    else if (Edad[i] <= 30) rangoedad[1]++;
                    else if (Edad[i] <= 40) rangoedad[2]++;
                    else if (Edad[i] <= 50) rangoedad[3]++;
                    else if (Edad[i] <= 60) rangoedad[4]++;
                    else rangoedad[5]++;
                }
                texto += si_vacunado.ToString("D2") + " personas se han vacunado\n" +
                    no_vacunado.ToString("D2") + " personas no se han vacunado\n\n" +
                    "Existen:\n" +
                    rangoedad[0].ToString("D2") + " personas entre 01 y 20 años\n" +
                    rangoedad[1].ToString("D2") + " personas entre 21 y 30 años\n" +
                    rangoedad[2].ToString("D2") + " personas entre 31 y 40 años\n" +
                    rangoedad[3].ToString("D2") + " personas entre 41 y 50 años\n" +
                    rangoedad[4].ToString("D2") + " personas entre 51 y 60 años\n" +
                    rangoedad[5].ToString("D2") + " personas de más de 61  años\n";
                Console.WriteLine(texto);
            }
            Operaciones.getTecla("Presione una tecla para regresar ...");
            return 0;
        }
        public static int BuscarPersonasEdad()
        {
            string texto1 = Operaciones.setTitulo("Busca a personas por edad");
            if (cont == 0)
            {
                texto1 += "\nNo hay datos\n\n";
                Console.Write(texto1);
            }
            else
            {
                Console.Write(texto1);
                int edad = Operaciones.getEntero("¿Qué edad quieres buscar?: ", texto1);
                int si_vacunado = 0;
                int no_vacunado = 0;
                for (int i = 0; i < cont; i++)
                {
                    if (Edad[i] == edad)
                    {
                        if (Vacunado[i] == 1) si_vacunado++;
                        else if (Vacunado[i] == 2) no_vacunado++;
                    }
                }
                string texto2 = "\n" + si_vacunado.ToString("D2") + " se vacunaron\n" +
                    no_vacunado.ToString("D2") + " no se vacunaron\n";
                Console.Write(texto2);
            }
            Operaciones.getTecla("Presione una tecla para regresar ...");
            return 0;
        }
    }
}