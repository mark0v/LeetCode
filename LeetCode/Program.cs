// See https://aka.ms/new-console-template for more information

using LeetCode;
using System.Collections.Generic;
using static LeetCode.TwoLists;

public class Solution
{

    public static void Main()
    {

        int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};

        var search = new MaxSubArray();
        var res = search.MaxSubArrayFind(nums);

        //Console.WriteLine("Hello, World!");
    }

    
}
