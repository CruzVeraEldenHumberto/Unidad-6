using System;
using System.Collections; // se usa la libreria Collections para poder utilzar los metodos de Hashtable
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_3.Cruz_Vera_Elden_Humberto
{
    class BusquedaHash
    {   // variables auxiliares
        int Cantidad;
        int Llave;
        string Valor;
        
        Hashtable hashtable = new Hashtable(); // se crea un objeto de clase Hashtable
        public void AgregarElementos() // Metodo que agrega elementos a la coleccion
        {
            Console.Write("Capture la cantidad de elementos que desea agregar: ");
            Cantidad = Int16.Parse(Console.ReadLine()); // variable que determina la cantidad de elementos de la coleccion

            for(int Contador = 0; Contador<Cantidad;Contador++)
            {
                Console.Write("Ingrese una llave numerica para el elemento: ");
                Llave = Int16.Parse(Console.ReadLine()); // valor de la llave
                Console.Write("Ingrese el valor del elemento: ");
                Valor = Console.ReadLine(); // valor del elemento
                hashtable[Llave] = Valor; // lo que va en el corchete es el llave y este es igual al valor capturado
                Console.WriteLine();
            }
        }

        public void MostrarTabla()
        {
            AgregarElementos(); // llamada de metodo
            Console.WriteLine();
            foreach (DictionaryEntry entry in hashtable) // ciclo para desplegar los elementos de la coleccion
            { // imprime la llave y el valor del elemento
                Console.WriteLine("Llave: {0}  |  Valor: {1}", entry.Key, entry.Value);
            }
        }

        public void Busqueda()
        {
            MostrarTabla(); // llamada de metodo
            Console.Write("\nIngrese la llave del elemento que desea buscar: ");
            Llave = Int16.Parse(Console.ReadLine()); // captura la llave que se desea buscar
            if (hashtable.ContainsKey(Llave)) // si la coleccion contiene la llave a buscar
            {
                Valor = (string)hashtable[Llave]; // a la variable Valor se le asigna el valor del elemento de la
                // coleccion en esa llave
                // mensaje de busqueda exitosa
                Console.WriteLine("Se ha encontrado el elemento con llave: {0} y valor {1}", Llave, Valor);
            }
            else // si no
            {  // se imprime un mensaje diciendo que la busqueda no fue exitosa
                Console.WriteLine("No hay ningun elemento que contenga esa llave");
            }
            Console.Write("\nPresione una tecla para salir: "); // mensaje de salida
            Console.ReadKey();
        }
    }
}
