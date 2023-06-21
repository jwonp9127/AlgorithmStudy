n = int(input())
init = input().split()
switch = list(map(int, init))
numStudents = int(input())

for i in range(numStudents):
    s, selectSwitch = input().split()
    s, selectSwitch = int(s), int(selectSwitch)
    if s == 1:  # 남학생
        for i in range(n):
            if (i + 1) % selectSwitch == 0:
                switch[i] = 1 - switch[i]
    else:       # 여학생
        switch[selectSwitch - 1] = 1 - switch[selectSwitch - 1]
        
        j = 1
        while(selectSwitch - 1 - j >= 0 and selectSwitch - 1 + j < n):
            if switch[selectSwitch - 1 - j] == switch[selectSwitch - 1 + j]:
                switch[selectSwitch - j - 1], switch[selectSwitch + j - 1] = 1 - switch[selectSwitch - j - 1], 1 - switch[selectSwitch + j - 1]
            else:
                break
            j += 1
        
switch = list(map(str, switch))

for i in range(n//20 + 1):
    print(' '.join(switch[i*20:i*20+20]))