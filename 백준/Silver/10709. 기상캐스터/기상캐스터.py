H, W = map(int, input().split())

for row in range(H):
    sky = input()
    after = []
    for i in range(W):
        if sky[i] == 'c':
            after.append('0')
        else:
            for j in range(i, -1, -1):
                if sky[j] == 'c':
                    after.append(str(i-j))
                    break
            if len(after) < i+1:
                after.append('-1')
    print(' '.join(after))

