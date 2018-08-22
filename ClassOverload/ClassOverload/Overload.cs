using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOverload
{
    class Overload
    {
        private int a;
        private int b;
        private int c;
        private int d;
        
        public Overload()
        {
            a = 3;
            b = 4;
            c = 5;
        }
        public Overload(int inta, int intb, int intc)
        {
            a = inta;
            b = intb;
            c = intc;
        }

        public static int Add(int inta, int intb, int intc, int intd)
        {
            return inta + intb + intc + intd;
        }

        public int Multiply()
        {
            return a * b * c;
        }
    }
}
