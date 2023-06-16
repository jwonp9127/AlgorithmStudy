
def solution(inps):
    nots=[]
    for i in range(1, 31):
        if i not in inps:
            nots.append(i)
    return nots


def input_list(type):
    if type == 'summit':
        inps = []
        while len(inps)<28:
            inp = input()
            if inp == "":
                break 
            else:
                inps.append(int(inp))

    if type == 'vs':
        import sys
        f=open('input.txt', 'r')
        inps=list(map(int, f.readlines()))

    return inps

def output_list(rets, type):
    if type == 'summit':
        for ret in rets:
            print(ret)
    if type == 'vs':
        import sys
        sys.stdout = open('output.txt', 'w')
        for ret in rets:
            print(ret)
        sys.stdout.close()

typ = 'summit'
output_list(solution(input_list(typ)), typ)