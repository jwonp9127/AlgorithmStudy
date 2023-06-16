import sys
n = int(sys.stdin.readline())
S = set()

for i in range(n):
    inps=sys.stdin.readline().split()

    if len(inps) == 1:
        if inps[0] == 'all':
            S = set([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20])
        elif inps[0] == 'empty':
            S = set()
    else:
        commend, num = inps[0], int(inps[1])
        if commend == 'add':
            S.add(num)
        elif commend == 'remove':
            S.discard(num)
        elif commend == 'check':
            print((num in S)*1)
        elif commend == 'toggle':
            if num not in S:
                S.add(num)
            else:
                S.discard(num)
