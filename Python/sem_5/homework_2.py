# Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел.
# Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.
# *Пример:*
#
# 2 2
# 4

def sum(a, b):
    if a > 0:
        b += 1
        return sum(a - 1, b)
    return b


def inp(x):
    while True:
        a = input(f'введи положительное число {x}: ')
        if a.isdigit() and int(a) >= 0:
            return int(a)
        print(f'"{a}" не похоже на положительное число, попробуй еще раз')


if __name__ == '__main__':
    a, b = inp('a'), inp('b')
    print(sum(a, b))
