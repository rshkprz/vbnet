using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab.lab2
{
    internal class Sum
    {
        public int sumNatural(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int sumArray(int nA, int[] arr)
        {
            int sum1 = 0;
            for (int j = 0; j < nA; j++)
            {
                sum1 += arr[j];
            }
            return sum1;
        }
    }
}
