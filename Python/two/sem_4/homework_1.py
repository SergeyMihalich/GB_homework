# Напишите функцию для транспонирования матрицы.
# Пример: [[1, 2, 3], [4, 5, 6]] -> [[1,4], [2,5], [3, 6]]

import numpy


def foo(matrix):
    res = numpy.array(matrix)
    return res.T


if __name__ == '__main__':
    print(foo([[1, 2, 3], [4, 5, 6]]))
