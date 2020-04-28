using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clase1_.net_core
{
    class Persona: IComparableP
    {
        string nombre;
        int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public Persona() { }
        public string getNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int getDni
        {
            get { return dni; }
            set { dni = value; }
        }

        public bool SosIgual(IComparableP variable)
        {

           Persona per =(Persona)variable;
            // IComparableP p = new Persona(nombre , dni);
            //ColeccionMultiple cole= (ColeccionMultiple)variable;
            // return cole.cola_coleccion.Contiene(p) || cole.pila_colecion.Contiene(p);

            // IComparableP p = new Persona(this.nombre , this.dni);
            //ColeccionMultiple cole= (ColeccionMultiple)variable;
            //return cole.Contiene(p) ;
           //Persona pers = new Persona(this.nombre, this.dni);
            
            return per.dni==this.dni;


            //throw new NotImplementedException();
        }

        public virtual bool SosMayor(IComparableP variable)
        {
            return this.dni < ((Persona)variable).dni;
        }

        public virtual bool SosMenor(IComparableP variable)
        {
            return this.dni > ((Persona)variable).dni;
        }


        public override string ToString()
        {
            //return base.ToString();
           return "nombre "+this.nombre+" dni "+this.dni;
        }

    }
}
