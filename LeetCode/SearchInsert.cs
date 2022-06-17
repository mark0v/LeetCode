using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsert
    {
        public int SearchInsertFind(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }
    }

    //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //int target = 9;

    //var serach = new SearchInsert();
    //var res = serach.SearchInsertFind(nums, target);

}
