def solution(lines):
    total = []
    candi = []
    answer = 0
    for line in lines:
        for i in range(line[0], line[1]):
            total.append(i)
    for i in total:
        if total.count(i) > 1:
            candi.append(i)
    candi = list(set(candi))
    # print(candi)
    # for i in range(len(candi)-1):
    #     answer += 1
    
    return len(candi)