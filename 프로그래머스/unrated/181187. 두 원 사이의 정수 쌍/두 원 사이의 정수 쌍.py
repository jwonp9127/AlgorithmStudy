import math

def solution(r1, r2):
    answer = 0
    for i in range(1, r2+1):
        M = math.floor(math.sqrt(r2**2 - i**2))
        if i > r1:
            m = 0
        else:
            m = math.ceil(math.sqrt(r1**2 - i**2))

        answer += (M - m + 1) * 4

    return answer