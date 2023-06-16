n, k= map(int, input().split()) #n: 총 나라 수, k: 등수를 알고 싶은 나라
country = []
medals = []
higher = 0

for i in range(n):
    inps=list(map(int, input().split()))
    country.append(inps[0])
    medals.append(inps[1:])

for i in range(n):
    if medals[i][0] > medals[country.index(k)][0]:
        higher += 1
    elif medals[i][0] == medals[country.index(k)][0] and medals[i][1] > medals[country.index(k)][1]:
        higher += 1
    elif medals[i][0] == medals[country.index(k)][0] and medals[i][1] == medals[country.index(k)][1] and medals[i][2] > medals[country.index(k)][2]:
        higher += 1

print(higher + 1)