using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class ColeccionMultiple:Coleccionable
    {
        Stack<Comparable> Pilas;
        Queue<Comparable> Colas;

        public ColeccionMultiple(Stack p, Queue c)
        {
            this.Pilas = p;
            this.Pilas = c;
        }

        public int cuantos()
        {
            return Pilas.Count + Colas.Count;
        }
        public Numero minimo()
        {
        
                Comparable min=0;
                foreach(Comparable x in Colas)
                {
                    //puse este if para no hacer lio si todos los numeros son mayores al cero que agregue para comparar
                    if (min==0) { min = x; }
                    foreach (Comparable y in Pilas)
                    {
                        if (y<min)
                        {
                            min = y;
                        }
                    }
                if (x < min) { min=x; }
                }
            return min;
            
        }
        Numero maximo()
        {
            Comparable max = 0;
            foreach (Comparable x in Colas)
            {
                //puse este if para no hacer lio si todos los numeros son menores al cero que agregue para comparar
                if (max == 0) { max = x; }
                foreach (Comparable y in Pilas)
                {
                    if (y < max)
                    {
                        max = y;
                    }
                }
                if (x < max) { max = x; }
            }
            return max;
        }
        abstract void agregar(Comparable t);
        bool contiene(Comparable t)
        {
            bool estaenPila=false;
            bool estaenCola = false;

            for( int x= 0; x < Pilas.Count; x++){
                if (x==t)
                {
                    estaenPila = true;
                }
            }
            for (int y = 0; y < Colas.Count; y++)
            {
                if (y == t)
                {
                    estaenCola = true;
                }
            }
            return estaenCola || estaenPila;



        }



    }
}
