# Напишите программу, которая принимает две строки вида “a/b” - дробь с числителем и знаменателем.
# Программа должна возвращать сумму и произведение* дробей.
# Для проверки своего кода используйте модуль fractions.

from fractions import Fraction


def reduction(num, denom):
    for i in range(min(num, denom))[1:]:
        if num % i == 0 and denom % i == 0:
            res_num = num // i
            res_denom = denom // i
    return f'{res_num}/{res_denom}'


def foo():
    frac1 = input('Введи первую дробь: ')
    frac2 = input('Введи вторую дробь: ')

    num1, denom1 = map(int, frac1.split("/"))
    num2, denom2 = map(int, frac2.split("/"))

    sum_frac_num = num1 * denom2 + num2 * denom1
    sum_frac_denom = denom1 * denom2
    sum_frac = reduction(sum_frac_num, sum_frac_denom)

    prod_frac_num = num1 * num2
    prod_frac_denom = denom1 * denom2
    prod_frac = reduction(prod_frac_num, prod_frac_denom)

    return f'{frac1} + {frac2} = мой метод {sum_frac}, метод fractions {Fraction(frac1) + Fraction(frac2)}\n' \
           f'{frac1} * {frac2} = мой метод {prod_frac}, метод fractions {Fraction(frac1) * Fraction(frac2)}'


if __name__ == '__main__':
    print(foo())
