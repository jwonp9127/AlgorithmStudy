TestCase = int(input()) # number of test case
winners= []
for i in range(TestCase):
    noplayer = int(input())
    players = list(map(int, input().split()))
    canplayers = []
    canteam = []
    teamscore = []

    for player in players:
        if players.count(player) >= 6:
            canplayers.append(player)
    
    for i in range(len(canplayers)):
        if canplayers[i] not in canteam:
            canteam.append(canplayers[i])
            teamscore.append([i+1])
        else:
            teamscore[canteam.index(canplayers[i])].append(i+1)
    
    winner_cand = [canteam[0], sum(teamscore[0][0:4])]

    for i in range(1, len(canteam)):
        if winner_cand[1] > sum(teamscore[i][0:4]):
            winner_cand = [canteam[i], sum(teamscore[i][0:4])]
        elif winner_cand[1] == sum(teamscore[i][0:4]):
            winner_cand.append(canteam[i])

    winner = winner_cand[0]    

    if len(winner_cand) >= 3:
        winner_cand.pop(1)
        for i in range(0, len(winner_cand)-1):
            for j in range(i+1, len(winner_cand)):
                if teamscore[canteam.index(winner_cand[i])][4] > teamscore[canteam.index(winner_cand[j])][4]:
                    winner = winner_cand[j]
    
    winners.append(winner)

for win in winners:
    print(win)
