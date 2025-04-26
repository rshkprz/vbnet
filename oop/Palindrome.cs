using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Palindrome
    {
        public bool CheckPalindrome(string inputString)
        {
            int left = 0;
            int right = inputString.Length - 1;

            while (left < right)
            {
                if (inputString[left] != inputString[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
