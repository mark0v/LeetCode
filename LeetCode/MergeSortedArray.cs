using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray
    {
        public int[] A = { 1, 2, 3, 0, 0, 0 };
        public int m = 3;
        public int n = 3;
        public int[] B = { 1, 4, 5 };
        public void Merge()
        {            
            Console.WriteLine(string.Join(", ", A));
            Console.WriteLine(string.Join(", ", B));

            for (int i = m + n - 1, a = m - 1, b = n - 1; i >= 0 && b >= 0; i--)
            {
                Console.WriteLine("----------Iteration---------");
                Console.WriteLine(string.Join(", ", A));

                if (a >= 0 && A[a] > B[b]) A[i] = A[a--];
                else A[i] = B[b--];
            }
        }
    }
}
