using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Pila:Coleccionable<Numero>
    {
        Stack<Numero> Pilas;
        Stack<Numero> Pila_copia=Pilas;

        public Pila()
        {
        }
        public int cuantos()
        {
            return Pilas.Count;
        }
        public Numero minimo() {
            Comparable min = Desapilar();
            while (cuantos() > 0)
            {
                
                Comparable comparar = Desapilar();
                if (min < comparar)
                {
                    min = comparar;
                }
                else { comparar = Desapilar(); }


            }
            return min;
             }
        public Numero maximo() {
            Comparable max = Desapilar();
            while (cuantos() > 0)
            {
                Numero MaxNum = new Numero();

                while(Pilas.)
                if (MaxNum.sosMayor())
                {
                    max = comparar;
                }
                else { comparar = Desapilar(); }


            }
            return max ; }
        public void agregar(Comparable comparable)
        {
            Pilas.Push(comparable);

        }
        public bool contiene(Comparable comparable)
        {
            if (comparable == Desapilar())
            {
                return true;
            }
            else
            {
                if (cuantos()<1)
                {
                    return false;
                }

                else { return contiene(Desapilar()); }
            }
        }

        private Comparable Desapilar()
        {
            Pila_copia.Pop();
            return Pila_copia[cuantos() - 1];

        }







    }
}
