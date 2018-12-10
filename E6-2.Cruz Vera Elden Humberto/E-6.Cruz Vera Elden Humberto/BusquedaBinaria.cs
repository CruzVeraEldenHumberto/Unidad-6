using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_6.Cruz_Vera_Elden_Humberto
{
    class BusquedaBinaria
    {   int[] Arreglo; // Arreglo donde se van a contener todos los numeros
        // variables auxiliares
        int Cantidad;
        int NumBuscar;
        int Indice;
        int Reemplazo;
        int Temp;
        private void Capturar() // Captura los numeros del arreglo
        {
            Console.Write("Introduza la cantidad de numeros que desea capturar: ");
            Cantidad = Int16.Parse(Console.ReadLine()); // Le pide al usuario la cantidad de numeros que quiere en el arreglo
            Arreglo = new int[Cantidad];
            Console.WriteLine();
            for (int Contador = 0; Contador < Arreglo.Length; Contador++) // ciclo para capturar elementos
            {
                Console.Write("Capture el numero deseado: ");
                Arreglo[Contador] = Int16.Parse(Console.ReadLine()); // se asigna un valor al arreglo
            }
        }

        private void Ordenar()
        {
            Capturar(); //llamada de metodo
            
            int temp;
            for (int Contador = 0; Contador < Arreglo.Length; Contador++) // Cuando se acabe el otro ciclo esta va a hacer
                                                                          // los recorridos necesarios hasta que todos los elementos se hayan comparadp
            {
                for (int Contador2 = 0; Contador2 < Arreglo.Length - 1; Contador2++) // Ciclo que compara los elementos
                                                                                     // del arreglo, por cada recorrido compara el elemento actual con el siguiente
                {
                    if (Arreglo[Contador2] > Arreglo[Contador2 + 1]) // si el indice actual es mayor al indice siguiente
                    {
                        temp = Arreglo[Contador2 + 1]; // se le asigna el valor de Contador2+1 a la variable temporal
                        Arreglo[Contador2 + 1] = Arreglo[Contador2]; // Arreglo[Contador2 +1] ahora tendra el valor 
                        //de Arreglo[Contador2]
                        Arreglo[Contador2] = temp; // Ahora el elemento actual tendra un valor menor que el del elemento
                        // siguiente
                    }
                }
            }
        
        }
        private bool BusquedaNumero()
        {
            ImprimirArreglo(); // llamada de metodo
            Console.Write("\nIngrese el numero a buscar: "); // captura el numero a buscar del usuario
            NumBuscar = Int16.Parse(Console.ReadLine());
            
            int Mid; // Indice medio del arreglo
            int Min = 0; // Indice menor del arreglo
            int Max = Arreglo.Length - 1; // indice mayor del arreglo
            while (Min <= Max) //Mientras que el indice menor sea menor o igual al mayot
            {
                Mid = (Min + Max) / 2; // El elemento medio es la suma de ambos entre 2
                
                if (NumBuscar < Arreglo[Mid]) // si el numero a buscar es menor que el valor de arreglo en la posicion media
                    // parte el arreglo en dos al determinar que el maximo es la posicion media -1
                {
                    Max = Mid - 1;
                }
                if (NumBuscar > Arreglo[Mid]) // si el numero a buscar es mayor que el valor de arreglo en la posicion media
                                              // parte el arreglo en dos al determinar que el menor es la posicion media +1
                {
                    Min = Mid + 1;
                }
                if (NumBuscar == Arreglo[Mid]) // si el numero a buscar es igual al arreglo en la posicion media 
                    // asigna el valor de Indice al indice donde se encontro el numero y regresa true
                {
                    Indice = Mid;
                    return true;
                }
            }
            return false; // regresa falso si no se encuentra el numero
        }

        private void ImprimirArreglo() // imprime los valores del arreglo
        {
            Ordenar();
            foreach (var item in Arreglo) // Despliega el valor actua del arreglo
            {
                Console.Write("|{0}|", item);
            }
        }

        private bool BusquedaReemplazo()
        {
            Console.WriteLine();
            Ordenar();
            Console.Write("Ingrese un numero a reemplazar: ");
            NumBuscar = Int16.Parse(Console.ReadLine());
            Console.Write("Ingrese el nuevo numero de reemplazo: ");
            Reemplazo = Int16.Parse(Console.ReadLine());
            int Mid; // Indice medio del arreglo
            int Min = 0; // Indice menor del arreglo
            int Max = Arreglo.Length - 1; // indice mayor del arreglo
            while (Min <= Max) //Mientras que el indice menor sea menor o igual al mayor
            {
                Mid = (Min + Max) / 2; // El elemento medio es la suma de ambos entre 2

                if (NumBuscar < Arreglo[Mid]) // si el numero a buscar es menor que el valor de arreglo en la posicion media
                                              // parte el arreglo en dos al determinar que el maximo es la posicion media -1
                {
                    Max = Mid - 1;
                }
                if (NumBuscar > Arreglo[Mid]) // si el numero a buscar es mayor que el valor de arreglo en la posicion media
                                              // parte el arreglo en dos al determinar que el menor es la posicion media +1
                {
                    Min = Mid + 1;
                }
                if (NumBuscar == Arreglo[Mid]) // si el numero a buscar es igual al arreglo en la posicion media 
                                               // asigna el valor de Indice al indice donde se encontro el numero y regresa true
                {
                    Temp = Arreglo[Mid];
                    Indice = Mid;
                    Arreglo[Mid] = Reemplazo;
                    return true;
                }
            }
            return false; // regresa falso si no se encuentra el numero

        }

        public void Imprimir()
        {
            if (BusquedaNumero() == true) // si Busqueda regresa true imprimir un mensaje de numero encontrado
            {
                Console.WriteLine("\nEl numero {0} fue encontrado", NumBuscar);
            }
            else // de lo contrario imprime que no encontró el numero
                Console.WriteLine("\nEl numero no fue encontrado");

           

            if (BusquedaReemplazo() == true) // si Busqueda regresa true imprimir un mensaje de reemplazo de numero
            {
                Console.WriteLine("\nSe reemplazo el valor {0} por {1} en el arreglo", Temp, Arreglo[Indice]);
            }
            else // de lo contraro imprime que no hay un numero para esa posicion
                Console.WriteLine("\nNo hay un valor para esa posicion del arreglo");

            foreach (var item in Arreglo) // imprime los valores del arreglo
            {
                Console.Write("|{0}|", item);
            }
        }
    }
}
