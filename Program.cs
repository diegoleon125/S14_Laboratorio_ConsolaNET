using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_Laboratorio_ConsolaNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.MenuPrincipal();
            while (opcion != 5)
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = Pantallas.DatosEncuesta();
                        break;
                    case 3:
                        opcion = Pantallas.ResultadosEncuesta();
                        break;
                    case 4:
                        opcion = Pantallas.BuscarPersonasEdad();
                        break;
                    default:
                        opcion = Pantallas.MenuPrincipal();
                        break;
                }
            }
            Console.Write("Hasta luego...");
            Console.ReadKey();
        }
    }
}
