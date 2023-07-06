# Given a Nuber N. Find if the sum of digits of N is a Palindrome or not.
# N=56 -> so the sum = 11 thie is palindrome
#
#
#
def is_palindrom(N):
    sum_num = 0
    while (N > 0):
        sum_num += N % 10
        N //= 10
    rev_new_num = 0
    N = sum_num
    while (N > 0):
        rev_new_num = rev_new_num*10+N % 10
        N //= 10
    return 1 if rev_new_num == sum_num else 0


print(is_palindrom(56))
