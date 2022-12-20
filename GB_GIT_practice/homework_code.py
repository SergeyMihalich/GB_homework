num_1 = int(input('введите значение от 0 до 10'))
if 0 <= num_1 <= 10:
	num_2 = num_1 * (-1)
else: print('введеное значение выходит за пределы заданного диапазона')

array = []
while num_2 <= num_1:
	array.append(num_2)
	num_2 += 1


print(array)