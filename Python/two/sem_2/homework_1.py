# Напишите программу, которая получает целое число и возвращает его шестнадцатеричное строковое представление.
# Функцию hex используйте для проверки своего результата


def foo_hex():
    num = hex_num = int(input("Введи число: "))
    digits = "0123456789abcdef"
    res = ""
    while num > 0:
        res = digits[num % 16] + res
        num = num // 16
    return f'результат функции {res}, результат метода hex {hex(hex_num)[2:]}'

if __name__ == '__main__':
    print(foo_hex())