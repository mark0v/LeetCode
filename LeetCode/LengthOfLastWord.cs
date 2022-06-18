using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordFind(string s)
        {
            if (s == null || s == string.Empty)
                return 0;

            int res = 0,
                i = s.Length - 1;

            while (i > -1 && s[i] == ' ')
                i--;

            while (i > -1 && s[i] != ' ')
            {
                res++;
                i--;
            }

            return res;
        }
    }
    //string s = "Hello World!";
    //var res = new LengthOfLastWord();
    //int output = res.LengthOfLastWordFind(s);
}
