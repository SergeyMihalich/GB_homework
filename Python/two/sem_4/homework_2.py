# Напишите функцию принимающую на вход только ключевые параметры и возвращающую словарь,
# где ключ — значение переданного аргумента, а значение — имя аргумента.
# Если ключ не хешируем, используйте его строковое представление.
# reverse_kwargs(rev=True, acc="YES", stroka=4) -> {True: "rev", "YES": 'acc', 4: "stroka"}

def foo(**kwargs):
    return {res if res.__hash__ is not None else str(res): itm for itm, res in kwargs.items()}


if __name__ == '__main__':
    print(foo(rev=True, acc="YES", stroka=4))
