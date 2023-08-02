def solution(num_list):
    mul = 1
    for num in num_list:
        mul *= num
    return (len(num_list)>=11)*(sum(num_list))+(len(num_list)<=10)*mul