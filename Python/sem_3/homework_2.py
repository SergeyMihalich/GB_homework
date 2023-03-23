from random import randrange


# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
#
# *Пример:*
#
# 5
# 1 2 3 4 5
# 6
# -> 5


def inp(index):
    return int(input(f'Введи число "{index}": '))


def calculation():
    n, x = inp('n'), inp('x')
    a = [randrange(0, n + 1) for _ in range(n)]
    z = abs(a[0] - x)
    rez = 0
    for i in set(a):
        if abs(i - x) < z:
            z = abs(i - x)
            rez = i
    print(rez)



if __name__ == '__main__':
    calculation()
