using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Comparar_Alumno_Promedio : IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable2).GetPromedio == ((Alumno)comparable).GetPromedio)
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable2).GetPromedio > ((Alumno)comparable).GetPromedio)
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparable comparable, IComparable comparable2)
        {
            if (((Alumno)comparable2).GetPromedio < ((Alumno)comparable).GetPromedio)
                return true;
            else
                return false;
        }
    }
}
