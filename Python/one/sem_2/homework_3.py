# Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.


n = int(input("Введи число 'n': "))
cnt = 0
arr = []
while 2 ** cnt <= n:
    arr.append(2 ** cnt)
    cnt += 1
print(arr)