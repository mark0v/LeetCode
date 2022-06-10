using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        //public bool IsPalindrome(int x)
        //{
        //    string first = x.ToString();             //turn to string (easy to reverse)
        //    char[] charArr = first.ToCharArray();   //the original target
        //    char[] reverseArr = first.ToCharArray();

        //    Array.Reverse(reverseArr);

        //    return charArr.SequenceEqual(reverseArr); //compare two array
        //}

        public bool IsPalindrome(int x)
        {
            string k = x.ToString();

            for (int i = 0; i < k.Length / 2; i++)
            {
                if (k[i] != k[k.Length - 1 - i])
                {
                    return false;           // if any char not the same, return false
                }
            }
            return true;
        }
    }
}
