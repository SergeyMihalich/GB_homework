# Дан список повторяющихся элементов. Вернуть список с дублирующимися элементами.
# В результирующем списке не должно быть дубликатов.
#
# [1, 2, 3, 1, 2] -> [1, 2]

# [1, 2, 2, 3, 3, 3, 4, 4, 4, 4]


def find_duplicates():
    lst = input('Введи список жлементов: ')
    return list(set([x for x in lst if lst.count(x) > 1 and x.isdecimal()]))


if __name__ == '__main__':
    print(find_duplicates())
