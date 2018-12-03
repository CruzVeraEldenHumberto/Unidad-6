using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._1_Cruz_Vera_Elden_Humberto
{
   
    class Program
    {
        static void Main(string[] args)
        {  // Crea el objeto busqueda de la clase Numero, originalmente iba a tener otra clase pero me tronaba el codigo
            Numero busqueda = new Numero();

            // Se mandan a llamar los metodos Busqueda1 y Busqueda2
            busqueda.Busqueda1();
            Console.WriteLine();
            busqueda.Busqueda2();
            Console.ReadKey();
        }
    }
}
