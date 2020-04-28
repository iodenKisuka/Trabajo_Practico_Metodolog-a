using System;
using System.Collections.Generic;

namespace Clase1_.net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iniciando programa");
            IColeccionableTP pila = new Pila();
            IColeccionableTP cola = new Cola();
           // Llenar(pila);
            Console.WriteLine("ingreso a llenar");
            Llenar(cola);
            // Informar(pila);
            Informar(cola);





            Console.WriteLine("Hello World!");
           



        }

        //EJERCICIO  5
       public static void Llenar(IColeccionableTP coleccionable)
        {
            Random rnd = new Random();
            int valor_elegido_al_azar = rnd.Next(0, 100);
            for (int x = 1; x <= 20; x++)
            {
                IComparableP comparable = new Numero(valor_elegido_al_azar);
                //IColeccionableTP coleccionable = new Pila();
                coleccionable.Agregar(comparable);
            }
        }

        //EJERCICIO 6
        public static void Informar(IColeccionableTP coleccionable)
        {
            Console.WriteLine(coleccionable.Cuantos());
            Console.WriteLine(((Numero)(coleccionable.Minimo())).Valor);
            Console.WriteLine(((Numero)(coleccionable.Maximo())).Valor);
            int num = int.Parse(Console.ReadLine());
           /** IComparableP compara = new Numero(num);
            if (coleccionable.Contiene(compara))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }**/
        }


    }
}
