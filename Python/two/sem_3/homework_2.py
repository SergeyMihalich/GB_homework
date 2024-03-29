# В большой текстовой строке подсчитать количество встречаемых слов и вернуть 10 самых частых.
# Не учитывать знаки препинания и регистр символов. За основу возьмите любую статью из википедии или из документации к языку.
#
# Ввод:
# текст отсюда(https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D1%80%D0%BB%D0%B8,_%D0%A1%D0%B8%D0%BB%D1%8C%D0%B2%D0%B0%D0%BD%D1%83%D1%81)
#
# Вывод:
#
# Слово "в", 22 раз
# Слово "и", 11 раз
# Слово "году", 9 раз
# Слово "с", 4 раз
# Слово "морли", 4 раз
# Слово "по", 3 раз
# Слово "степень", 3 раз
# Слово "института", 3 раз
# Слово "был", 3 раз
# Слово "памятников", 3 раз
import re
from collections import Counter

import requests
from bs4 import BeautifulSoup as bs


def foo():
    URL_TEMPLATE = "https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D1%80%D0%BB%D0%B8,_%D0%A1%D0%B8%D0%BB%D1%8C%D0%B2%D0%B0%D0%BD%D1%83%D1%81"
    r = requests.get(URL_TEMPLATE)
    soup = bs(r.text, "html.parser")
    get_articles = soup.find_all('p')
    get_words = ''
    for art in get_articles:
        get_words += art.text.lower()
    words = re.findall(r'\b\w+\b', get_words)
    res = Counter(words).most_common(10)
    print('результат:')
    for i in res:
        yield f'слово "{i[0]}", {i[1]} раз'


if __name__ == '__main__':
    print(*foo(), sep=';\n', end='.')
