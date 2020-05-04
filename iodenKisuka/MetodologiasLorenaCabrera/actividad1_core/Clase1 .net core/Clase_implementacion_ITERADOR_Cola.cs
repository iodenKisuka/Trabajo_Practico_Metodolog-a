using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Cola : Interador
    {
        private Queue<IComparableP> colas = new Queue<IComparableP>();
        int posicion;

        public Clase_implementacion_ITERADOR_Cola(Queue<IComparableP> colas)
        {
            this.colas = colas;
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
