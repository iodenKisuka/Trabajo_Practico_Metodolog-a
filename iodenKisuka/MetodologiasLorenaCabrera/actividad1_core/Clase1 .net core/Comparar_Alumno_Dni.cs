using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Comparar_Alumno_Dni : IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable).GetDni == ((Alumno)comparable2).GetDni)
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable2).GetDni < ((Alumno)comparable).GetDni)
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable2).GetDni > ((Alumno)comparable).GetDni)
                return true;
            else
                return false;
        }
    }
}
