using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_6.Cruz_Vera_Elden_Humberto
{
    class Program
    {

        static void Main(string[] args)
        {
       
            BusquedaBinaria binary = new BusquedaBinaria(); // se crea objeto de la clase Busqueda Binaria
            binary.Imprimir(); // llamada de metodo Imprimir
            Console.Write("\nPresione una tecla para salir: "); // mensaje de salida
            Console.ReadKey();
        }
    }
}
