def solution(numbers, target):
    numbers = list(map(int, numbers))
    answer = 0
    cal = [[0]]
    for i in range(len(numbers)):
        cal.append([])
        for j in range(0, len(cal[i])):
            cal[i + 1].append(cal[i][j] + numbers[i])
            cal[i + 1].append(cal[i][j] - numbers[i])
    
    for number in cal[-1]:
        if number == target:
            answer += 1

    return answer