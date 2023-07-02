str = input()
for i in range(len(str)):
    if str[i].isupper():
        str = str[:i] + str[i].lower() + str[i+1:len(str)]
    else:
        str = str[:i] + str[i].upper() + str[i+1:len(str)]
print(str)