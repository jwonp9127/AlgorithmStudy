inps = input().upper()
spels = [[],[]]
max = 0

for inp in inps:
    if inp not in spels[0]:
        spels[0].append(inp)
        spels[1].append(1)
    else:
        spels[1][spels[0].index(inp)] += 1

for spel_n in spels[1]:
    if spel_n > max:
        max = spel_n

if spels[1].count(max) == 1:
    print(spels[0][spels[1].index(max)])
else:
    print('?')