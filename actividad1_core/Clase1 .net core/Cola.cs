using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Cola: IColeccionableTP
    {
        private Queue<IComparableP> colas = new Queue<IComparableP>();

        public void Agregar(IComparableP objeto)
        {
            colas.Enqueue(objeto);
        }

        public bool Contiene(IComparableP objeto)
        {
            throw new NotImplementedException();
        }

        public int Cuantos()
        {
            return colas.Count;
        }

        public IComparableP Maximo()
        {
           
            Queue<IComparableP> colas_copia2;
            colas_copia2 = Clonar(colas);
            IComparableP max= colas_copia2.Dequeue();
            
            while (colas_copia2.Count>0)
            {
                IComparableP comparar = colas_copia2.Dequeue();
                if (max.SosMayor(comparar))
                {
                    max = comparar;
                }

                
            }
            return max;
        }

        public IComparableP Minimo()
        {
            Queue<IComparableP> colas_copia;
            colas_copia = Clonar(colas);
            IComparableP min = colas_copia.Dequeue();
            while (colas_copia.Count> 0)
            {
                IComparableP comparar =colas_copia.Dequeue();
                if (min.SosMenor(comparar)){
                    min = comparar;
                }
            }
            return min;
        }
        private Queue<IComparableP> Clonar(Queue<IComparableP> Aclonar)
        {
            Queue<IComparableP> Clon = new Queue<IComparableP>();
            while (Aclonar.Count > 0)
            {
                Clon.Enqueue(Aclonar.Dequeue());
            }
            return Clon;
        }
        //EJERCICIO  5
        /** public void Llenar(IColeccionableTP coleccionable)
         {
             Random rnd = new Random();
             int valor_elegido_al_azar = rnd.Next(0, 100);
             for (int x = 1; x <= 20; x++)
             {
                 IComparableP comparable = new Numero(valor_elegido_al_azar);
                 //IColeccionableTP coleccionable = new Cola();

                 coleccionable.Agregar(comparable);
                
             }
         }**/

    }
}
