def solution(park, routes):
    answer = []
    current = []
    
    rows = len(park)
    cols = len(park[0])
        
    for row in park:
        for col in row:
            if col == 'S':
                current = [park.index(row), row.index(col)]

    for route in routes:
        condition1, condition2 = 0, 0
        change = [((route[0]=='S')-(route[0]=='N'))*int(route[2]),
                    ((route[0]=='E')-(route[0]=='W'))*int(route[2])]
        condition1 = current[0] + change[0] < rows and current[0] + change[0] >= 0 and current[1] + change[1] < cols and current[1] + change[1] >= 0
        
        for moving in range(int(route[2])):
            rot = [((route[0]=='S')-(route[0]=='N'))*(moving+1), ((route[0]=='E')-(route[0]=='W'))*int(moving+1)]
            if condition1 == 0 or park[current[0]+rot[0]][current[1]+rot[1]] == 'X':
                condition2 = 0
                break
            condition2 = 1
        
        
        if condition2:
            current = [current[0]+change[0], current[1]+change[1]]
    
    return current


    