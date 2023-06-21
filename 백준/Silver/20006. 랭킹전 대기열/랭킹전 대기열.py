p, m = input().split()
p, m = int(p), int(m)

waiting_rooms = []
waiting_rooms_level = []

for i in range(p):
    level, name = input().split()
    level = int(level)
    is_enter = 0
    if len(waiting_rooms) == 0:
        waiting_rooms.append([name])
        waiting_rooms_level.append([level])
    else:
        for j in range(len(waiting_rooms)):
            if len(waiting_rooms[j]) != m+1 and waiting_rooms_level[j][0] - 10 <= level <= waiting_rooms_level[j][0] + 10:
                waiting_rooms[j].append(name)
                waiting_rooms_level[j].append(level)
                is_enter = 1
                break
        if is_enter == 0:
            waiting_rooms.append([name])
            waiting_rooms_level.append([level])
    
    for j in range(len(waiting_rooms)):
        if len(waiting_rooms[j]) == m:
            waiting_rooms[j].append('s')
            break
        
for i in range(len(waiting_rooms)):
    if len(waiting_rooms[i]) == m + 1:
        print("Started!")
        waiting_rooms[i].pop(-1)
    else:
        print("Waiting!")
    
    index = sorted(waiting_rooms[i])
    for ind in index:
        print(waiting_rooms_level[i][waiting_rooms[i].index(ind)], ind)



