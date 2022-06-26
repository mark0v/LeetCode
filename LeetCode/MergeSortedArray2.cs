using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray2
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int id1 = m - 1, id2 = n - 1;

            for (int i = m + n - 1; i >= 0; i--)
            {
                if (id2 < 0)
                    nums1[i] = nums1[id1--];
                else if (id1 < 0)
                    nums1[i] = nums2[id2--];
                else if (nums1[id1] >= nums2[id2])
                    nums1[i] = nums1[id1--];
                else
                    nums1[i] = nums2[id2--];
            }
        }
    }
    //int m = 3; int n = 3;
    //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    //int[] nums2 = { 2, 5, 6 };

    //var res = new MergeSortedArray2();

    //res.Merge(nums1, m, nums2, n);
}
