using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Program
    {
        static void Main(string[] args)
        {

            Coleccionable pila = new Pila();
            Coleccionable cola = new Cola();

            llenarAlumnos(pila);
           llenarAlumnos(cola);
           informar(ColeccionMultiple);
           

            Console.WriteLine("hola ");



            Console.ReadKey();
          
        }

        public static void llenar(Numero coleccionable)
        {
            for (int x = 1; x <= 20; x++)
            {
                Random rnd = new Random();
                Comparable comp = new Numero(rnd.Next(0, 100));
                coleccionable.agregar(comp);

              
                }

        }
        public static string nombre_al_azar()
        {
            Random rnd = new Random();
            string texto_aleatorio = "";
            char[] lista = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int x = 0; x < 4; x++)
            {
                char randomChar = (char)rnd.Next('a', 'z');
                Console.WriteLine(randomChar);
                texto_aleatorio = texto_aleatorio + lista[rnd.Next(0, 4)] + randomChar;
            }
            return texto_aleatorio;
        }
        public static void llenarPersonas(Coleccionable<Persona> coleccionable) {
            for (int L = 0; L < 20; L++)
            {
                Random aleatorio = new Random();

                Comparable comp = new Persona(nombre_al_azar(),aleatorio.Next(10000000,99999999));
                coleccionable.agregar(comp);

            }

        }
        public static void llenarAlumnos(Coleccionable<Alumno> coleccionable)
        {
            for (int L = 0; L < 20; L++)
            {
                Random aleatorio = new Random();

                Comparable comp = new Alumno(nombre_al_azar(), aleatorio.Next(10000000, 99999999), aleatorio.Next(100, 99999), aleatorio.Next(1,10));
                coleccionable.agregar(comp);

            }

        }

        public static void informar(Coleccionable<Numero> coleccionable)
        {
            Console.WriteLine(coleccionable.cuantos());
            Console.WriteLine(coleccionable.minimo());
            Console.WriteLine(coleccionable.maximo());
            int num = int.Parse(Console.ReadLine());
            Comparable compara = new Numero(num);
            if (coleccionable.contiene(compara)) { 
            Console.WriteLine("El elemento leído está en la colección");
            }
            else { 
            Console.WriteLine("El elemento leído no está en la colección");
            }

        }
    }
    
   
}
