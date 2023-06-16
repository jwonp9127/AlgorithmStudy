def solution(dots):
    answer = 0
    slopes = []
    jjak = [(0, 1, 2, 3), (0, 2, 1, 3), (0, 3, 1, 2)]
    
    for i in range(3):
        if slope(dots[jjak[i][0]], dots[(jjak[i][1])]) == slope(dots[(jjak[i][2])], dots[(jjak[i][3])]):
            answer = 1
    return answer

def slope(a, b):
    return (b[1]-a[1])/(b[0]-a[0])