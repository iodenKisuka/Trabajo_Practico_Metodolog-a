using System;
using System.Collections;
using System.Collections.Generic;
namespace Pilas_Y_Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          Queue<int> Cola_principal = new Queue<int>();
            
            Cola_principal.Enqueue(1);
            Cola_principal.Enqueue(2);
            Cola_principal.Enqueue(3);
            Cola_principal.Enqueue(4);
            
           
            Queue<int> Cola_1 = new Queue<int>();
           
            

            /**
            Console.WriteLine("cantidad cola principal :" + Cola_principal.Count);
            while (Cola_1.Count > 0)
            {
               Console.WriteLine( Cola_1.Dequeue());
            }
    **/
            Console.WriteLine("cantidad cola principal :"+Cola_principal.Count);


                Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("cantidad cola principal :" + Cola_principal.Count + " CANTIDAD DE Cola_1 " + Cola_1.Count);

            int cantidad_1 = Cola_principal.Count;
            int cantidad_2 = Cola_1.Count;
            int total;
           Queue<int> copia = new Queue<int>();
            if (cantidad_1 > cantidad_2) { total = cantidad_1;
             // copia = Cola_principal;
            }
            else { total = cantidad_2;
              //  copia = Cola_1;
            }
            Console.WriteLine("CANTIDA COPIA " + copia.Count+ " cantidad cola principal :" + Cola_principal.Count + " CANTIDAD DE Cola_1 " + Cola_1.Count);
            for(int x=0; x<total; x++)
            {
                // Cola_principal.Enqueue(copia.Peek());
                //Cola_1.Enqueue(copia.Dequeue());
                Cola_principal.Enqueue(Cola_principal.Peek());
                Cola_1.Enqueue(Cola_principal.Dequeue());
            }
            Cola_principal.Enqueue(6);
            Console.WriteLine("cantidad cola principal :" + Cola_principal.Count + " CANTIDAD DE Cola_1 " + Cola_1.Count+" CANTIDAd COPIA " + copia.Count);

            Console.WriteLine("cantidad cola principal :" + Cola_principal.Count);
            while (Cola_principal.Count > 0)
            {
                Console.WriteLine(Cola_principal.Dequeue());
            }
            Console.WriteLine("cantidad cola principal :" + Cola_principal.Count);
            Console.WriteLine("CANTIDAD DE Cola_1 " + Cola_1.Count);
            while (Cola_1.Count > 0)
            {
                Console.WriteLine(Cola_1.Dequeue());
            }
            Console.WriteLine(" CANTIDA COPIA " + copia.Count);
            while (Cola_1.Count > 0)
            {
                Console.WriteLine(Cola_1.Dequeue());
            }



        }


       
    }
}
