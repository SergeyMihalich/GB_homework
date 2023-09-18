from random import randrange


# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
#
# *Пример:*
#
# 5
# 1 2 3 4 5
# 3
# -> 1

def inp(index):
    return int(input(f'Введи число "{index}": '))


def calculation():
    n, x = inp('n'), inp('x')
    a = [randrange(0, n + 1) for _ in range(n)]

    print(a.count(x))


if __name__ == '__main__':
    calculation()
