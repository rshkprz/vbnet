using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab
{
    internal class Check
    {
        public int isLarge(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else { return num3; }
        }

        public bool isOddEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            { return false; }
        }

        public bool isLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else { return false; }
        }

        public bool isPrime(int numPrime)
        {
            int count = 0;
            for (int i = 1; i <= numPrime; i++)
            {
                if (numPrime % i == 0)
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
