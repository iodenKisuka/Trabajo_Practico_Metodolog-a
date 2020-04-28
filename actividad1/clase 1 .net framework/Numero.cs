using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_1.net_framework
{
    class Numero: Comparable<Numero>
    {
        int valor;
        public Numero() { }
        public Numero(int valor)
        {
            this.Valor = valor;
        }

        
       int Valor { get; set; }

        public bool SosIgual(Numero comparable)
        {
            if (comparable.Valor == this.Valor)
                return true;
            else
                return false;
        }


        public bool sosMayor(Numero comparable)
        {
            if (comparable.Valor < this.Valor)
                return true;
            else
                return false;
        }



        public bool SosMenor(Numero comparable)
        {
            if (comparable.Valor > this.Valor)
                return true;
            else
                return false;
        }
    }




}

