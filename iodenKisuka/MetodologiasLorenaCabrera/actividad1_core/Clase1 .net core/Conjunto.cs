using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Conjunto : IColeccionableTP
    {
        ArrayList Lista_conjunto = new ArrayList();
        
        public void Agregar(Object elemento) { }

        public void Agregar(IComparableP objeto)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(IComparableP objeto)
        {
            throw new NotImplementedException();
        }

        public int Cuantos()
        {
            throw new NotImplementedException();
        }

        public IComparableP Maximo()
        {
            throw new NotImplementedException();
        }

        public IComparableP Minimo()
        {
            throw new NotImplementedException();
        }

        public bool Pertenece(object elemento) { return false; }
    }
}
