using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Persona : Comparable<Persona>
    {
        string nombre;
        int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public string getNombre{
            get { return nombre; }
            set { nombre = value; }
           }
        public int getDni
        {
            get { return dni; }
            set { dni = value; }
        }


      public bool SosIgual(Persona comparable) {
            return dni.Equals(comparable);
        }
        public bool SosMenor(Persona comparable) {
            return this.dni > comparable.dni;
        }
       public bool sosMayor(Persona comparable) {
            return this.dni < comparable.dni;
        }

       
       /* public bool sosMayor(Persona comparable)
        {
            throw new NotImplementedException();
        }*/
    }
}
