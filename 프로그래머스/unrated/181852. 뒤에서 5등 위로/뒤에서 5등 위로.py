def solution(num_list):
    for _ in range(5):
        num_list.remove(min(num_list))
    return sorted(num_list)