def solution(players, callings):
    rank = {}
    result = []
    
    for ind in range(len(players)):
        rank[players[ind]] = ind
    for call in callings:
        tmp = rank.get(call)
        rank[players[tmp]], rank[players[tmp-1]] = tmp-1, tmp
        players[tmp], players[tmp-1] = players[tmp-1], players[tmp]
        
    return players