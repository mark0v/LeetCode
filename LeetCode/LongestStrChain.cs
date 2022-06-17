using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestStrChain
    {
        public int LongestStrChainFind(string[] words)
        {
            words = words.OrderBy(x => x.Length).ToArray();
            Dictionary<string, int> dict = new();
            int maxLen = 0;

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    int currLen = 1;
                    for (int i = 0; i < word.Length; i++)
                    {
                        StringBuilder sb = new StringBuilder(word);
                        sb.Remove(i, 1);
                        string modifiedWord = sb.ToString();
                        int modifiedLen = dict.ContainsKey(modifiedWord) ? dict[modifiedWord] + 1 : 1;
                        currLen = Math.Max(currLen, modifiedLen);
                    }
                    dict.Add(word, currLen);
                    maxLen = Math.Max(currLen, maxLen);
                }
            }

            return maxLen;
        }
    }

    //string[] words = { "a", "b", "ba", "bca", "bda", "bdca" };
    //var res = new LongestStrChain();
    //var output = res.LongestStrChainFind(words);
}
