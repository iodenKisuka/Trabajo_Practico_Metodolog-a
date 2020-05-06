using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class FabricaDeNumeros
    {
        IComparableP numero;
        public IComparableP CrearNumeroAlAzar()
        {
            Random rnd = new Random();
            int valor_elegido_al_azar = rnd.Next(0, 100);
            numero = new Numero(valor_elegido_al_azar);
            return numero;
      }

        public IComparableP CrearNumeroPorTeclado()
        {
            numero = new Numero(LectorDeDatos.numeroPorTeclado());
            return numero;
        }

    }
}
