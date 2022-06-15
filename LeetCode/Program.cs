// See https://aka.ms/new-console-template for more information

using LeetCode;
using System.Collections.Generic;
using static LeetCode.TwoLists;

public class Solution
{

    public static void Main()
    {

        string[] words = { "a", "b", "ba", "bca", "bda", "bdca" };
        var res = new LongestStrChain();
        var output = res.LongestStrChainFind(words);


        //Console.WriteLine("Hello, World!");
    }

    
}
