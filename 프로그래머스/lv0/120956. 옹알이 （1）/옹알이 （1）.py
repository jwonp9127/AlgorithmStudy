def solution(babbling):
    sols = ["aya", "ye", "woo", "ma"]
    answer = 0
    cans = []

    for bab in babbling:
        ca = 0
        for sol in sols:
            if sol in bab:
                ca += len(sol)
                print(bab, sol)
        if len(bab) == ca:
            answer += 1
            print('b')

    return answer