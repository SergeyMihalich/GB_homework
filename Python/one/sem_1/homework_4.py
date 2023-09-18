# Задача 8: Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек,
# если разрешается сделать один разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника).
# *Пример:*
# 3 2 4 -> yes
# 3 2 1 -> no


def inp(itm):
    res = int(input(f'введите число {itm} '))
    return res


while True:
    n, m, k = inp('n'), inp('m'), inp('k')

    print('YES' if k < m * n and k % m == 0 or k % n == 0 else 'NO')