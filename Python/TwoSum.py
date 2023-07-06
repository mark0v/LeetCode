# Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

# You may assume that each input would have exactly one solution, and you may not use the same element twice.

nums = [2, 7, 11, 15, 1]
target = 13


# class Solution:

#     def twoSum(self, nums, target):
#         numMap = {}
#         length = len(nums)

#         # Build the hash table
#         for i in range(length):
#             numMap[nums[i]] = i

#         # Find the complement
#         for i in range(length):
#             complement = target - nums[i]
#             if complement in numMap and numMap[complement] != i:
#                 return [i, numMap[complement]]

#         return []  # No solution found

class Solution:
    def twoSum(self, nums, target):
        dict = {}
        for i, n in enumerate(nums):
            if n in dict:
                return dict[n], i
            else:
                dict[target-n] = i


result = Solution().twoSum(nums, target)
print(result)
