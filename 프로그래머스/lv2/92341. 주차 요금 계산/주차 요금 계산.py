def solution(fees, records):
    records = list(map(lambda s: s.split(), records))
    koc = list(set(map(lambda s: s[1], records)))
    koc.sort()
    reclen = len(records)
            
    answer = []
    
    for num in koc:
        car = []
        car_time = 0
        fee = 0
        for i in range(reclen):
            if records[i][1] == num:
                car.append(records[i][0])
        if len(car)%2 == 1:
            car.append('23:59')
        for i in range(len(car)):
            if i%2 == 0:
                car_time += time_cal(car[i], car[i+1])
        if car_time <= fees[0]:
            answer.append(fees[1])
        else:
            answer.append(fees[1] + ((car_time - fees[0])//fees[2] + ((car_time - fees[0])%fees[2] != 0))*fees[3])

    return answer

def time_cal(bef, aft): #분단위
    return int(aft[0]) * 600 + int(aft[1]) * 60 + int(aft[3]) * 10 + int(aft[4]) - int(bef[0]) * 600 - int(bef[1]) * 60 - int(bef[3]) * 10 - int(bef[4])