def clean(map, r, c):
    if map[r+1][c] != 0 and map[r-1][c] != 0 and map[r][c+1] != 0 and map[r][c-1] != 0:
        return 'clean'
    
def back(r, c, d):
    if d == 0:
        return (r+1, c)
    elif d == 1:
        return (r, c-1)
    elif d == 2:
        return (r-1, c)
    else:
        return (r, c+1)

def front(r, c, d):
    if d == 0:
        return (r-1, c)
    elif d == 1:
        return (r, c+1)
    elif d == 2:
        return (r+1, c)
    else:
        return (r, c-1)

[N, M] = list(map(int, input().split()))
[r, c, d] = list(map(int, input().split())) # 초기좌표, 방향(0~3: 북 동 남 서)

cur = [r, c, d]
zzz = []
for row in range(N):
    zzz.append(list(map(int, input().split())))

done = 0
clear = 0

while(done == 0):
    if zzz[cur[0]][cur[1]] == 0:
        zzz[cur[0]][cur[1]] = 2
        clear += 1
    if clean(zzz, cur[0], cur[1]) == 'clean':
        curback = back(cur[0], cur[1], cur[2])
        if 0 <= curback[0] < N and 0 <= curback[1] < M and zzz[curback[0]][curback[1]] != 1:
            cur[0], cur[1] = curback[0], curback[1]
        else:
            done = 1
    else:
        if cur[2] == 0:
            cur[2] = 3
        else:
            cur[2] -= 1
        curfront = front(cur[0], cur[1], cur[2])
        if zzz[curfront[0]][curfront[1]] == 0:
            cur[0], cur[1] = curfront[0], curfront[1]

print(clear)