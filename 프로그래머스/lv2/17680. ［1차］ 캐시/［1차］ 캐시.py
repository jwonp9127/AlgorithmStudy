def solution(cacheSize, cities): 
    answer = 0
    cache = []

    cities = list(map(lambda s: s.upper(), cities))
    
    for city in cities:
        if city in cache:
            answer += 1
            ind = cache.index(city)
            cache =  cache[:ind] + cache[ind+1:] + [city]
        else:
            answer += 5
            cache.append(city)
            if len(cache) > cacheSize:
                cache.pop(0)
    return answer