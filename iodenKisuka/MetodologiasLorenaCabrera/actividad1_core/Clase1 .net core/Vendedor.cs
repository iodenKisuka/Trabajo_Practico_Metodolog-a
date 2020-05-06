using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Vendedor: Persona
    {
        double sueldoBasico;
        double bonus;

        public Vendedor(string n, int d, double sueldoBasico, double bonus) : base(n, d)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = bonus;
        }

        public void Venta(double monto)
        {
            Console.WriteLine("Monto "+monto);
        }
        public void AumentaBonus()
        {
            bonus = bonus + 0.1;
        }

    }
}
