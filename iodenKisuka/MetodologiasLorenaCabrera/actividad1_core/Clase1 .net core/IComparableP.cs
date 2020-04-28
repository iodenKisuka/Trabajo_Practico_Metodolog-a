using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IComparableP
    {
        bool SosIgual(IComparableP variable);
        bool SosMenor(IComparableP variable);
        bool SosMayor(IComparableP variable);
        
    }
}
