# Треугольник существует только тогда, когда сумма любых двух его сторон больше третьей. Дано a, b, c - стороны предполагаемого треугольника. Требуется сравнить длину каждого отрезка-стороны с суммой двух других. Если хотя бы в одном случае отрезок окажется больше суммы двух других, то треугольника с такими сторонами не существует. Отдельно сообщить является ли треугольник разносторонним, равнобедренным или равносторонним.

def foo():
    triangle = {'A': None,
                'B': None,
                'C': None,
                }

    i = 0
    while i < len(triangle):
        side = list(triangle.keys())[i]
        length = input(f'Введи длину стороны "{side}": ')
        if int(length) > 0:
            triangle[side] = int(length)
            i += 1
            continue
        print("Введи ПОЛОЖИТЕРЬНОЕ ЧИСЛО")

    if triangle['A'] + triangle['B'] < triangle['C'] \
            or triangle['A'] + triangle['C'] < triangle['B'] \
            or triangle['C'] + triangle['B'] < triangle['A']:
        return "Такой треугольник существовать не может"
    elif triangle['A'] == triangle['B'] \
            or triangle['A'] == triangle['C'] \
            or triangle['C'] == triangle['B']:
        if triangle['A'] == triangle['B'] \
                and triangle['B'] == triangle['C'] \
                and triangle['A'] == triangle['C']:
            return "Это равносторонний треугольник"
        return "Это равнобедренный треугольник"
    else:
        return "Это разносторонний треугольник"

if __name__ == '__main__':
    print(foo())