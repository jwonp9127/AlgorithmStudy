def solution(msg):
    dic = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
    answer = []
    msg = list(map(lambda s: s.upper(), msg))
    i = 0
    while(i < len(msg)):
        word = ""
        for j in range(i, len(msg)):
            word += msg[j]
            if word not in dic:
                dic.append(word)
                answer.append(dic.index(word[:-1])+1)
                i = j
                break
            elif j == len(msg)-1:
                answer.append(dic.index(word)+1)
                i = j+1
    
    return answer