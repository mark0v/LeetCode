using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxSubArray
    {
		public int MaxSubArrayFind(int[] nums)
		{
			int sum = 0;
			int maxSum = nums[0];

			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
				if (nums[i] > sum)
				{
					sum = nums[i];
				}
				if (sum > maxSum)
				{
					maxSum = sum;
				}
			}
			return maxSum;
		}
	}
}
