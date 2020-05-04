using System;
using System.IO;
using System.Collections.Generic;

namespace Clase1_.net_core
{
    class Program
    {
        static void Main(string[] args)
        {

            ////  ContextAlumnoStegy estrategiaalimno = new ContextAlumnoStegy(new Comparar_Alumno_Dni());
            // estrategiaalimno.SosIgual();
            /** //Ejercicio 7
             Console.WriteLine("iniciando programa");
             IColeccionableTP pila = new Pila();
             IColeccionableTP cola = new Cola();
             Llenar(pila);
             Console.WriteLine("ingreso a llenar pila");
             Llenar(cola);
             Informar(pila);
             Console.WriteLine("Datos de la Cola");
             Informar(cola);

             //Ejercicio 8
             Console.WriteLine("Datos de la COLECCION");
             IColeccionableTP pila2 = new Pila();
             IColeccionableTP cola2 = new Cola();
             ColeccionMultiple multiple = new ColeccionMultiple(pila2, cola2);
             Llenar(multiple.pila_colecion);
             Llenar(multiple.cola_coleccion);


             Console.WriteLine("Datos entrando a COLECCION");
             Informar(multiple); **/

            /*   //Ejercicio 13
               Console.WriteLine("Datos de la COLECCION");
               IColeccionableTP pila3 = new Pila();
               IColeccionableTP cola3 = new Cola();
               ColeccionMultiple multiple2 = new ColeccionMultiple(pila3, cola3);
               LlenarPersonas(multiple2.pila_colecion);
               LlenarPersonas(multiple2.cola_coleccion);
               Informar(multiple2);    **/

            //Ejercicio 17
            //Console.WriteLine("Datos de la COLECCION");
            //IColeccionableTP pila4 = new Pila();
            //IColeccionableTP cola4 = new Cola();
            //ColeccionMultiple multiple3 = new ColeccionMultiple(pila4, cola4);
            //LlenarAlumnos(multiple3.pila_colecion);
            //LlenarAlumnos(multiple3.cola_coleccion);
            //Informar(multiple3);

            // Console.WriteLine("Hello World!");
            Numero num1 = new Numero(1);
            Numero num2 = new Numero(2);
            Persona persona = new Persona("nombre1",1234);
            Numero num3 = new Numero(3);
            Persona persona2 = new Persona("nombre2", 12345);
            IComparableP num1repetido = new Numero(1);
            IComparableP persona1repetido = new Persona("nombre1", 1234);
            Conjunto nuevo_conjunto = new Conjunto();
            nuevo_conjunto.Agregar(persona);
            nuevo_conjunto.Agregar(num1);
            nuevo_conjunto.Agregar(persona2);

            nuevo_conjunto.Agregar(persona1repetido); nuevo_conjunto.Agregar(persona1repetido);
            nuevo_conjunto.Agregar(persona1repetido);
            nuevo_conjunto.Agregar(persona1repetido);
            nuevo_conjunto.Agregar(num2);
            nuevo_conjunto.Agregar(num3);
            nuevo_conjunto.Agregar(num1repetido);
            foreach (IComparableP elemento in nuevo_conjunto.Listacomparable)
            {
                Console.WriteLine(elemento);
            }
            Diccionario nuevoDiccinario = new Diccionario();
            Clave_Valor clave = new Clave_Valor(persona1repetido,persona1repetido);
            Clave_Valor clave1_repetido = new Clave_Valor(persona1repetido, persona);
            Clave_Valor clave2 = new Clave_Valor(persona1repetido, num1);
            nuevoDiccinario.Agregar(clave);
            nuevoDiccinario.Agregar(clave);
            nuevoDiccinario.Agregar(clave1_repetido);
            nuevoDiccinario.Agregar(clave2);

            Clave_Valor clave_repetido = new Clave_Valor(num1repetido, persona);
            Console.WriteLine( nuevoDiccinario.valorDe(clave_repetido));
            Console.WriteLine(nuevoDiccinario.valorDe(clave));

            foreach (KeyValuePair<IComparableP, object> result in nuevoDiccinario.diccionario)
            {
                Console.WriteLine(string.Format("Key-{0}:Value-{1}", result.Key, result.Value));
            }
            foreach (var economica in nuevoDiccinario.diccionario)
            {
                Console.WriteLine("{0} : {1}", economica.Key, economica.Value);
            }


            Console.WriteLine("Usando el patron interator");
            ImprimirElementos(nuevoDiccinario);

        }

        //EJERCICIO  5
        public static void Llenar(IColeccionableTP coleccionable)
        {
            Random rnd = new Random();

            for (int x = 1; x <= 20; x++)
            {
                int valor_elegido_al_azar = rnd.Next(0, 100);
                IComparableP comparable = new Numero(valor_elegido_al_azar);
                //IColeccionableTP coleccionable = new Pila();
                coleccionable.Agregar(comparable);
            }

        }

        //EJERCICIO 6
        public static void Informar(IColeccionableTP coleccionable)
        {
            Console.WriteLine("Cantidad " + coleccionable.Cuantos());
            if (coleccionable.Cuantos() > 0)
            {
                // Console.WriteLine("Minimo " + ((Numero)(coleccionable.Minimo())).Valor);
                Console.WriteLine("Minimo " + coleccionable.Minimo());
                Console.WriteLine("Maximo " + coleccionable.Maximo());
                Console.WriteLine("Ingrese un numero que quiere buscar");
                int num = int.Parse(Console.ReadLine());

                //  IComparableP compara = new Numero(num);
                Sub_programa_informar(coleccionable, num);

                // IComparableP compara = new Persona("",num) ;
                // IComparableP compara;


                /*  if (coleccionable.Contiene(compara))
                  {
                      Console.WriteLine("El elemento leído está en la colección");
                  }
                  else
                  {
                      Console.WriteLine("El elemento leído NO está en la colección");
                  */
            }
            Console.WriteLine(" ");

        }

        //sub_programa
        public static void Sub_programa_informar(IColeccionableTP coleccionable, int num)
        {
            bool saber_si_ando = false;
            try
            {
                IComparableP compara = new Numero(num);
                saber_si_ando = coleccionable.Contiene(compara);
            }
            catch (Exception)
            {
                try
                {
                    IComparableP compara = new Alumno("", num, num, num);
                    //saber_si_ando = coleccionable.Contiene(compara);
                    //ejercici practica 2 probando si funciona
                    //Aplicando_Estrategia_Comparar_Alumno_Ejercicio2_practica2();

                }
                catch (Exception)
                {
                    IComparableP compara = new Persona("", num);
                    saber_si_ando = coleccionable.Contiene(compara);
                }
            }
            finally
            {
                if (saber_si_ando)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }
            }

        }

       // Ejercicio 12
        public static void LlenarPersonas(IColeccionableTP coleccionable)
        {
            for (int L = 0; L < 20; L++)
            {
                Random aleatorio = new Random();
                //string nombre_al_azar = Path.GetRandomFileName();
                IComparableP comp = new Persona(Nombre_al_azar(), aleatorio.Next(10000000, 99999999));
                coleccionable.Agregar(comp);
            }
        }
        public static string Nombre_al_azar()
        {
            //string texto_aleatorio = "";
            List<string> nombres = new List<string> { "JUAN", "JOSÉ LUIS", "JOSÉ", "MARÍA GUADALUPE", "FRANCISCO", "GUADALUPE", "MARÍA", "JUANA", "ANTONIO", "JESÚS", "MIGUEL ÁNGEL", "PEDRO", "ALEJANDRO", "MANUEL", "MARGARITA", "MARÍA DEL CARMEN", "JUAN CARLOS", "ROBERTO", "FERNANDO", "DANIEL", "CARLOS", "JORGE", "RICARDO", "MIGUEL", "EDUARDO", "JAVIER", "RAFAEL", "MARTÍN", "RAÚL", "DAVID", "JOSEFINA", "JOSÉ ANTO" };
            Random aleatorio = new Random();
            int cantidad = nombres.Count - 1;

            return nombres[aleatorio.Next(0, cantidad)];
        }
        public static void LlenarAlumnos(IColeccionableTP coleccionable)
        {
            for (int L = 0; L < 20; L++)
            {
                Random aleatorio = new Random();

                IComparableP compA = new Alumno(Nombre_al_azar(), aleatorio.Next(10000000, 99999999), aleatorio.Next(100, 99999), aleatorio.Next(1, 10));
                coleccionable.Agregar(compA);
            }

        }
        //public static void Aplicando_Estrategia_Comparar_Alumno_Ejercicio2_practica2() {
        //    //Ejercicio 2 Practica 2
        //    Random aleatorio = new Random();
        //    List<IEstrategia_Comparar_Alumno> Lista_Estrategia_Comparar_Alumno = new List<IEstrategia_Comparar_Alumno>() { new Comparar_Alumno_Nombre(), new Comparar_Alumno_Dni(), new Comparar_Alumno_Promedio(), new Comparar_Alumno_Legajo() };

        //    IEstrategia_Comparar_Alumno estrategia = Lista_Estrategia_Comparar_Alumno[aleatorio.Next(4)];
        //    Alumno alumno_A = new Alumno();
        //    alumno_A.Estrategia_elegida = estrategia;
        //}



        //Ejercicio 7 Practica 2
        public static void  ImprimirElementos(IColeccionableTP coleccionable)
        {
            Interador interador = coleccionable.iterador();

            while(!interador.fin())
            {
                object elemento = interador.actual();
                interador.siguiente();
                //si no agregara siguiente seria un bucle infinito
                Console.WriteLine(elemento);
            }
        }

    }
}
