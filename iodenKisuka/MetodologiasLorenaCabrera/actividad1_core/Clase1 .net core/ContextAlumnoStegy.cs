using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
     class ContextAlumnoStegy
    {
        IEstrategia_Comparar_Alumno estrategia;

        public ContextAlumnoStegy(IEstrategia_Comparar_Alumno estrategia)
        {
            this.estrategia = estrategia;
        }
    }
}
