def solution(str1, str2):
    
    answer = 0
    str1s = []
    str2s = []
    hab = 0
    gyo = 0

    for i in range(len(str1)-1):
        cand = str1[i] + str1[i+1]
        if cand.isalpha():
            str1s.append(cand.upper())
    for i in range(len(str2)-1):
        cand = str2[i] + str2[i+1]
        if cand.isalpha():
            str2s.append(cand.upper())
    
    for abc in set(str1s):
        if abc in str2s:
            hab += max(str1s.count(abc), str2s.count(abc))
            gyo += min(str1s.count(abc), str2s.count(abc))
        else:
            hab += str1s.count(abc)
    for abc in set(str2s):
        if abc not in str1s:
            hab += str2s.count(abc) 
    if hab == 0:
        answer = 65536
    else:   
        answer = int(65536 * gyo / hab)
        
    return answer