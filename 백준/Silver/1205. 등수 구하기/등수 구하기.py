N, tscore, P = input().split()
N, tscore, P = int(N), int(tscore), int(P) 
if N == 0:
    print(1)
else:
    trank = 0
    ranking_scores = list(map(int, input().split()))

    ranking_scores.append(tscore)

    for i in range(len(ranking_scores)-1):                  # sort
        for j in range(i+1, len(ranking_scores)):
            if ranking_scores[i] < ranking_scores[j]:
                tmp = ranking_scores[i]
                ranking_scores[i] = ranking_scores[j]
                ranking_scores[j] = tmp

    if len(ranking_scores) <= P or ranking_scores[-1] < tscore:
        for score in ranking_scores:
            if score > tscore:
                trank += 1
        trank += 1
    else:
        trank = -1
    
    print(trank)
    
    


