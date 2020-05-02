using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Clase1_.net_core
{
    class Diccionario <K,T>: IColeccionableTP, ITERABLE { 
    
        Dictionary<K ,T> diccionario;

        public ITERABLE actual()
        {
            throw new NotImplementedException();
        }

        public string Agregar(Clave_Valor clave) {
          string  asociacion_claveValor =""+clave.clave + clave.valor_asociado;
            return asociacion_claveValor;
        }

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

        public bool fin()
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

        public void primero()
        {
            throw new NotImplementedException();
        }

        public void siguiente()
        {
            throw new NotImplementedException();
        }

        public int ValorDe(int clave) { return clave; }
     
    }
}
