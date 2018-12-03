using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._1_Cruz_Vera_Elden_Humberto
{
    public class Numero
    {  // Se definen dos arreglos y un par de variables auxiliares
        int[] arreglo = new int[] { 8, 7, 8, 9, 10, 11, 2, 4, 3, 100, 70, 50, 34 };
        int[] arreglo2 = new int[] { 7, 11, 2, 3, 7, 10, 15, 19, 25, 1000, -1, 0 };
        int Num = 0;
        int ContAux = 0;
        int Posicion = 0;
        int Tamaño = 0;
        public void Busqueda1()
        {
            
            Console.WriteLine("El arreglo es: ");
            foreach (var item in arreglo) // se imprime el arreglo
            {
                Console.Write("|" + item);
            }
            Console.Write("\nIngrese el numero a buscar: "); // se ingresa el numero a buscar
            Num = Int16.Parse(Console.ReadLine());
            
            Tamaño = arreglo.Length; //se define el tamaño del arreglo
           

            while (Posicion < Tamaño) //si el contador Posicion es menor que Tamaño continua el ciclo
            {
                if (arreglo[Posicion] == Num) // si e valor de arreglo es igual al numero imprime un mensaje y se rompe
                    // el ciclo
                {
                    Console.WriteLine("\nEl numero {0} se encontró dentro del arreglo", Num);
                    break;
                }
                else
                {
                    ContAux++; // de lo contrario se añaden una unidad a dos contadores auxiliares
                    Posicion++;
                }
            }

            if(ContAux == arreglo.Length) // si ContAux es igual al tamaño del arreglo no se encontró el arreglo
            {
                Console.WriteLine("\nEl número no fue encontrado dentro del arreglo");
            }
        }

        public void Busqueda2() // Metodo muy similar al anterior, con la excepcion de que aqui se define el numero
            // a buscar
        {
            Num = 10;
            ContAux = 0;
            Posicion = 0;
            Tamaño = 0;
            Console.WriteLine("El arreglo es: ");
            foreach (var item in arreglo2)
            {
                Console.Write("|" + item);
            }
            Console.Write("\nEl numero a buscar es 10: ");
            

            Tamaño = arreglo2.Length;


            while (Posicion < Tamaño)
            {
                if (arreglo2[Posicion] == Num)
                {
                    Console.WriteLine("\nEl numero {0} se encontró dentro del arreglo", Num);
                    break;
                }
                else
                {
                    ContAux++;
                    Posicion++;
                }
            }

            if (ContAux == arreglo2.Length)
            {
                Console.WriteLine("\nEl número no fue encontrado dentro del arreglo");
            }
        }
        
    }

}       
    
