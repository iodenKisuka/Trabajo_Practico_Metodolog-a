using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Pila:IColeccionableTP
    {
        Stack<IComparableP> pilas= new Stack<IComparableP>();
        public int Cuantos()
        {
           return pilas.Count;
        }

        public IComparableP Minimo()
        {
            /**IComparable min;
            while (Cuantos()>0) {
                



            }
            return min;**/
            throw new NotImplementedException();
        }

        public IComparableP Maximo()
        {
            throw new NotImplementedException();
        }

        public void Agregar(IComparableP objeto)
        {
            pilas.Push(objeto);
        }

        public bool Contiene(IComparableP objeto)
        {
            throw new NotImplementedException();
        }

        //EJERCICIO  5
        public void Llenar(IColeccionableTP coleccionable) {
            Random rnd = new Random();
            int valor_elegido_al_azar=rnd.Next(0, 100);
            for (int x = 1; x <= 20; x++){
                IComparableP comparable=new Numero(valor_elegido_al_azar);
                //IColeccionableTP coleccionable = new Pila();
                coleccionable.Agregar(comparable);
            }
        }

        //EJERCICIO 6
        /** public void Informar(IColeccionableTP coleccionable)
         {
             Console.WriteLine(coleccionable.Cuantos());
             Console.WriteLine(coleccionable.Minimo());
             Console.WriteLine(coleccionable.Maximo());
             int num = int.Parse(Console.ReadLine());
           //IColeccionableTP coleccionable = new Pila();
             IComparableP compara = new Numero(num);
         } **/

    }
}
