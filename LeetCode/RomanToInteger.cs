using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToInteger
    {
        private readonly Dictionary<char, int> dict = new Dictionary<char, int> { 
            { 'I', 1 }, 
            { 'V', 5 }, 
            { 'X', 10 }, 
            { 'L', 50 }, 
            { 'C', 100 }, 
            { 'D', 500 }, 
            { 'M', 1000 } };

        public int RomanToInt(string s)
        {

            //special situations
            s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");

            int result = 0;

            foreach (var ch in s)
            {
                result += dict[ch];
            }

            return result;
        }
    }
}
