using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Alumno : Persona
    {
        int legajo;
        int promedio;
        public int getLegajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int getPromedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }


        public override string ToString()
        {
            return base.ToString()+" legajo "+ this.legajo;
        }

       /** public override bool SosMayor(IComparableP variable)
        {
            return this.legajo < ((Alumno)variable).legajo;
        }

        public override bool SosMenor(IComparableP variable)
        {
            return this.legajo < ((Alumno)variable).legajo;
        } **/



    }
}
