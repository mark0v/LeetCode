using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PivotIndex
    {
        public int PivotIndexFind(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int sum = nums.Sum();
            int leftsum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((sum = (sum - nums[i])) == leftsum)
                    return i;
                else
                    leftsum += nums[i];
            }

            return -1;
        }
    }
}
