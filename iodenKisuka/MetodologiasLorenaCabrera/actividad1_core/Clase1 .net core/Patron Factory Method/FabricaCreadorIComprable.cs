using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Clase1_.net_core.Patron_Factory_Method
{
    class FabricaCreadorIComprable
    {
        public const int CrearNumero = 0;
        public const int CrearAlumno = 1;

        public static IComparableP CrearAleatorio(int tipo)
        {
            switch (tipo)
            {
                case CrearAlumno:
                    return new FabricaDeAlumnos().CrearAlumnoAlAzar();
                case CrearNumero:
                    return new FabricaDeNumeros().CrearNumeroAlAzar();
                default:
                    return null;
            }
        }
        public static IComparableP CrearPorTeclado(int tipo)
        {
            switch (tipo)
            {
                case CrearAlumno:
                    return new FabricaDeAlumnos().CrearAlumnoPorTeclado();
                case CrearNumero:
                    return new FabricaDeNumeros().CrearNumeroPorTeclado();
                default:
                    return null;
            }
        }

    }
}
