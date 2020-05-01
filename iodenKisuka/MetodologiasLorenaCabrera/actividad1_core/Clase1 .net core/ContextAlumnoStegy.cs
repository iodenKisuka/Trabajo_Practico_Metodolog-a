using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Clase1_.net_core
{
    class ContextAlumnoStegy : IEstrategia_Comparar_Alumno
    {
        IEstrategia_Comparar_Alumno estrategia;

        public ContextAlumnoStegy(IEstrategia_Comparar_Alumno estrategia)
        {
            this.estrategia = estrategia;
        }

        public bool SosIgual(IComparable comparable, IComparable comparable2)
        {
            return this.estrategia.SosIgual(comparable, comparable2);
        }

        public bool SosMayor(IComparable comparable, IComparable comparable2)
        {
            return this.estrategia.SosIgual(comparable, comparable2);
        }

        public bool SosMenor(IComparable comparable, IComparable comparable2)
        {
            return this.estrategia.SosIgual(comparable, comparable2);
        }
    }
}
