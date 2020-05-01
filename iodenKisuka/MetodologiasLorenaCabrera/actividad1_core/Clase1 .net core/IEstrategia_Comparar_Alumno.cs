using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IEstrategia_Comparar_Alumno
    {
        /*            //dato generico porque ingresa tanto un int como un string y var no me anda,
                //y string o int no son objetos
               void Comparar_Alumno(int dato);
               void Comparar_Alumno(string dato);   **/
        public bool SosIgual(IComparable comparable, IComparable comparable2);
        public bool SosMenor(IComparable comparable, IComparable comparable2);
        public bool SosMayor(IComparable comparable, IComparable comparable2);

    }
}
