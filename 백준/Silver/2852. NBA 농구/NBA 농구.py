def timetosec(time):
    return int(time[0]) * 600 + int(time[1]) * 60 + int(time[3]) * 10 + int(time[4])

def sectotime(sec):
    return ''.join([str(sec//600), str((sec % 600)//60) , ':', str((sec % 60)//10), str(sec%10)])

n = int(input())

tscore = [0, 0] # team 1, team 2
ttime = [0, 0] # sec
last_time = '00:00'

for i in range(n):
    team, time = input().split()
    team = int(team) - 1

    if n == 0:
        tscore[team] += 1

    else:
        if tscore[0] > tscore[1]:
            ttime[0] += timetosec(time) - timetosec(last_time)
        elif tscore[0] < tscore[1]:
            ttime[1] += timetosec(time) - timetosec(last_time)
        last_time = time
        tscore[team] += 1

if tscore[0] > tscore[1]:
    ttime[0] += timetosec('48:00') - timetosec(last_time)
elif tscore[0] < tscore[1]:
    ttime[1] += timetosec('48:00') - timetosec(last_time)
    

print(sectotime(ttime[0]))
print(sectotime(ttime[1]))
