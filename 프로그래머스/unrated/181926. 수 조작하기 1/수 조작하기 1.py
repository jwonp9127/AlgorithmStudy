def solution(n, control):
    for con in control:
        n = n + 1*(con=='w')+10*(con=='d')-1*(con=='s')-10*(con=='a')
    return n