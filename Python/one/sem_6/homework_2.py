# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону
# (т.е. не меньше заданного минимума и не больше заданного максимума)
from random import randint

list = [randint(-10, 11) for _ in range(20)]
print(list)
min = int(input('введи минимум: '))
max = int(input('введи максимум: '))
for i in range(len(list)):
    if min <= list[i] <= max:
        print(i)