using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOpcional
{
    internal class clOperaciones
    {
       private double n1;
       private double n2;

        public clOperaciones(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public double sumar()
        {
            return n1 + n2;
        }

        public double restar()
        {
            return n1 - n2;
        }

        public double multiplicar()
        {
            return n1 * n2;
        }

        public double dividir()
        {
            double result = n1 / n2;
            return result;
        }
    }
}
