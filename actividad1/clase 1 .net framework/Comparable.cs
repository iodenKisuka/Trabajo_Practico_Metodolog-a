using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    interface Comparable<T>
    {
        bool SosIgual(T comparable);
        bool SosMenor(T comparable);
        bool sosMayor(T comparable);
    }
}
