﻿// See https://aka.ms/new-console-template for more information

using LeetCode;

public class Solution
{    

    public static void Main()
    {

        //var instMergeSortedArraySolution = new MergeSortedArray();
        //instMergeSortedArraySolution.Merge();
        //var instPalindrime = new RemovePalindromicSubsequences();       
        //var pal = instPalindrime.RemovePalindromeSub2("aaaaa");


        //var dic = new TwoSum();
        //int[] nums = { 1, 2, 3, };
        //var res = dic.TwoSumFind(nums, 4);

        //int[] pivotArray = { 1, 2, 3, 2, 2, 4 };
        //var pivot = new PivotIndex();        
        //Console.WriteLine(pivot.PivotIndexFind(pivotArray));

        //var palindromNum = new PalindromeNumber();        
        //var isPalindrom = palindromNum.IsPalindrome(2246422);
        //Console.WriteLine("Hello, World!");

        //var romInt = new RomanToInteger();        
        //var number = romInt.RomanToInt("LVIII");

        //string [] words = { "ptshjk", "ptswkln", "ptdln" };
        //var prefix = new LongestCommonPrefix();        
        //prefix.LongestCommonPrefixFind(words);


        //string words = "((){}[])";
        //var str = new ValidParentheses();
        //bool res = str.IsValid(words);

        int[] SortesArray = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var result = new RemoveDuplicatesSortedArray();
        var num = result.RemoveDuplicates(SortesArray);


        //Console.WriteLine("Hello, World!");
    }

    
}
