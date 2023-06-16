def solution(array):
    max = [0, 0, -1]
    for x in array:
        if array.count(x) >= max[0] and x != max[2]:
            if max[0] == array.count(x):
                max[1] += 1
            else:
                max.pop()
                max[0] = array.count(x)
                max[1] = 1
                max.append(x)
            print(array)
    if max[1] > 1:
        return -1
    else:
        return max[2]