inps = []
times = []
answer = 0
for i in range(4):
    inp = list(map(lambda s: int(s.strip()), input().split()))
    inps.append(inp)

for i in range(1, 4):
    for j in range(inps[i][0], inps[i][1]):
        times.append(j)

for time in times:
    if times.count(time) == 1:
        answer += inps[0][0]
    elif times.count(time) == 2:
        answer += inps[0][1]
    else:
        answer += inps[0][2]

print(answer)
