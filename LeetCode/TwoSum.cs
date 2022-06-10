﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode
{
    internal class TwoSum
    {
        public int[] TwoSumFind(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[2];
        }
    }
}
