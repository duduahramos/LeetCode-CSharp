using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class PalindromeNumber9
    {
        public static bool Run(int x)
        {
            bool isPalindrome = true;
            string val = x.ToString();

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] != val.Reverse().ToList()[i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

    }
}
