using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Pila : Interador
    {
        Stack<IComparableP> pilas = new Stack<IComparableP>();
        int posicion;

        public Clase_implementacion_ITERADOR_Pila(Stack<IComparableP> pilas)
        {
            this.pilas = pilas;
            posicion = 0;
        }

        public object actual()
        {
            throw new NotImplementedException();
        }

        public bool fin()
        {
            throw new NotImplementedException();
        }

        public void siguiente()
        {
            throw new NotImplementedException();
        }
    }
}
