n = int(input())
for i in range(n):
    inps = input().split()
    case_num = int(inps[0])
    heights = list(map(int, inps[1:]))
    aord = [heights[0]]
    steps = 0
    for i in range(1, 20): # 학생 20명
        higher = []
        for j in range(0, i):
            if heights[i] < aord[j]:
                higher.append(aord[j])
        if len(higher) > 0:
            index_min = aord.index(higher[0])
            for k in range(1, len(higher)):
                if aord.index(higher[k]) < index_min:
                    index_min = aord.index(higher[k])
            aord = aord[:index_min]+[heights[i]]+aord[index_min:]
            steps += len(aord[index_min+1:])
        else:
            aord.append(heights[i])
    print(case_num, steps)



    