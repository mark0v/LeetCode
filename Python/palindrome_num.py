
x = 121


class Solution:
    def isPalindrome(self, x: int) -> bool:
        a = list(str(x))
        b = list(str(x))
        b.reverse()
        print(True if a == b else False)


result = Solution()
result.isPalindrome(x)
