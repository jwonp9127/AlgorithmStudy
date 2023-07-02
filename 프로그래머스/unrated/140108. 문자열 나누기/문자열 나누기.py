def solution(s):
    answer = 0
    i = 0
    x = 1
    nx = 0
    
    while(len(s) > 0):
        i += 1

        if i > len(s)-1:
            answer += 1
            break
        
        if s[0] == s[i]:    x += 1
        else:               nx += 1
        
        if x == nx:
            answer += 1
            s = s[i+1:]
            i = 0
            x = 1
            nx = 0
    
    return answer