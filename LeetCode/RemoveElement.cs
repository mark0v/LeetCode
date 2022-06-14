using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveElement
    {
        public int FindAndRemove(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                while (j < nums.Length && nums[j] == val)
                    j++;

                if (j < nums.Length)
                    nums[i++] = nums[j];
            }

            return i;
        }
    }
}
