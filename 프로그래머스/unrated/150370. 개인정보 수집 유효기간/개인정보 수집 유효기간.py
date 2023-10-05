def solution(today, terms, privacies):
    answer = []
    lterms = []
    tyear, tmonth, tday = today.split('.')
    tyear, tmonth, tday = int(tyear), int(tmonth), int(tday)
    a = "2022.12.31 A"
    b, c = a.split(' ')
    
    for i in range(len(terms)):
        lterms.append(terms[i].split(' '))
    
    for i in range(len(privacies)):
        year_month_day, term = privacies[i].split(' ')
        year, month, day = year_month_day.split('.')
        year, month, day = int(year), int(month), int(day)
        
        for t in terms:
            tt = t.split(' ')
            if tt[0] == term:
                aft = int(tt[1])
                break
                
        term_day = day_count([year, month, day], aft)
        
        if is_before(term_day, [tyear, tmonth, tday]):
            answer.append(i+1)

    return answer

def day_count(bday, aft):
    mm, my = 0, 0
    
    if bday[2] - 1 < 1:
        mm = 1
        bday[2] = bday[2] + 28
    
    if bday[1] + aft % 12 - mm < 1:
        my = 1
        bday[1] = bday[1] + 12
        
    if bday[1] + aft % 12 - mm > 12:
        my = my - 1
        bday[1] = bday[1] - 12
    
    return [bday[0]+aft//12-my, bday[1]+aft%12-mm, bday[2]-1]

def is_before(a, b): # a가 b보다 이전인지 알려주는 함수
    if a[0] < b[0]:
        return 1
    elif a[0] == b[0] and a[1] < b[1]:
        return 1
    elif a[0] == b[0] and a[1] == b[1] and a[2] < b[2]:
        return 1
    else:
        return 0
        
        