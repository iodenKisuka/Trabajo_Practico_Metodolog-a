using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    interface Coleccionable<T>
    {
        int cuantos();
        Numero minimo();
        Numero maximo();
        void agregar(T comparable);
        bool contiene(Comparable<object> t);
    }
}
