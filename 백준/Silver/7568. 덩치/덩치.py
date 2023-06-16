n = int(input()) # 사람 수
big_rank = [1 for i in range(n)]
bodies = []

for i in range(n):
    bodies.append(list(map(int, input().split()))) #(weight, height)

for i in range(n):
    for j in range(n):
        if bodies[j][0] > bodies[i][0] and bodies[j][1] > bodies[i][1]:
            big_rank[i] += 1

print(*big_rank)
