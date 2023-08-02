def solution(num_list):
    odd = ''
    even = ''
    for num in num_list:
        if num % 2 == 0:
            even = even + str(num)
        else:
            odd = odd + str(num)
    return int(even)+int(odd)