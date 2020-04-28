using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Alumno:Persona
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

        public Alumno(string n, int d,int l,int p):base (n,d)
        {
            this.legajo = l;
            this.promedio = p;
        }


        public bool SosIgual(Alumno comparable)
        {
            throw new NotImplementedException();
        }
       override public bool SosMenor(Alumno comparable)
        {
            return Alumno < comparable;
        }
      override public bool sosMayor(Persona comparable)
        {
            return Alumno > comparable;
        }
    }






    }
}
