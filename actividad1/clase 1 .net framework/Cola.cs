using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Cola: Coleccionable<Numero>
    
        
        Queue<Numero> Colas;
        Queue<Numero> Cola_copia=Colas;
        public Cola()
        {
        }

        public int cuantos()
        {
            return Colas.Count;
        }
        public Numero minimo()
        {
            Comparable min = Desencolar_dequeue();
            while (cuantos()>0)
            {
                 
                Comparable comparar = Desencolar_dequeue();
                if (min < comparar)
                {
                    min = comparar;
                }
                else { comparar = Desencolar_dequeue(); }


            }
            return min;
        }
        public Numero maximo() {
            Comparable max = Desencolar_dequeue();
            while (cuantos() > 0)
            {
                Comparable<Numero> comparar = Desencolar_dequeue();
                if (max > comparar)
                {
                    max = comparar;
                }
                else { comparar = Desencolar_dequeue(); }


            }
            return Numero; }

        public void agregar(Comparable<Numero> c)
        {
            Colas.Enqueue(c);
        }
        public bool contiene(Comparable comparable)
        {
            if (comparable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Comparable<Numero> Desencolar_dequeue()
        {
            return Cola_copia.Dequeue();

        }

    }
}
