using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab.lab2
{
    internal class Factorial
    {
        public int Facto(int numFactorial)
        {
            int fact = 1;
            for (int i = 1; i <= numFactorial; i++)
                fact = fact * i;
            return fact;
        }
    }
}
