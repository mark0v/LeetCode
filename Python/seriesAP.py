# Given the firs two terms A1 and A2 of an arifmetic series. Find the Nth term of the series.
# Input: A1=2, A2=4
# N=4
# Output:
# 8
# The series is: 2,4,6,8,10
# Thus 4th term is 8
def seriesAP(A1, A2, N):
    step = A2-A1
    n_term = A1+(N-1)*step
    return n_term


n_term = seriesAP(2, 4, 6)
print(n_term)
