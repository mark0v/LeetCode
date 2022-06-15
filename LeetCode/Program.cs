// See https://aka.ms/new-console-template for more information

using LeetCode;
using System.Collections.Generic;
using static LeetCode.TwoLists;

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

        //int[] SortesArray = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        //var result = new RemoveDuplicatesSortedArray();
        //var num = result.RemoveDuplicates(SortesArray);

        //int[] nums = { 0, 1, 1, 1, 2, 3, 1 };
        //var result = new RemoveElement();
        //---------------------------------------
        LinkedList l1 = new LinkedList();
        //l1.Add(new Node("1"));  
        l1.Add(new Node("2"));
        l1.Add(new Node("3"));
        l1.Add(new Node("4"));
        l1.Add(new Node("5"));
        l1.Add(new Node("8"));
        l1.Add(new Node("100"));
        l1.Add(new Node("120"));


        LinkedList l2 = new LinkedList();
        l2.Add(new Node("10"));
        l2.Add(new Node("30"));
        l2.Add(new Node("34"));
        LinkedList list = new LinkedList();
        list.MergeSortedList(l1.Head, l2.Head);
        //list.PrintNodes();
        Console.ReadLine();



        //Console.WriteLine("Hello, World!");
    }

    
}
