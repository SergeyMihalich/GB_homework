import re

cont = {
    '1': 'имя',
    '2': 'фамилия',
    '3': 'отчество',
    '4': 'телефон',
}


def writing_person(lastname=None, name=None, surname=None, phone=None):
    if (lastname, name, surname, phone) is None:
        lastname = input('фамилия: ')
        name = input('имя: ')
        surname = input('отчество: ')
        phone = input('телефон: ')
    with open('phonebook.txt', 'a', encoding='utf-8') as pb:
        pb.writelines(f'фамилия: {lastname}; имя: {name}; отчество: {surname}; телефон: {phone}.\n')


def search():
    flag = True
    persons = {}
    ask = input(
        '''по каким данным ищем?
        1 - имя,
        2 - фамилия,
        3 - отчество,
        4 - телефон,
        введи нужное число: ''')

    if ask not in '1234':
        print('нет такой команды, попробуй еще раз')
        search()

    ask_2 = input('по какому значению ищем?: ')

    with open('phonebook.txt', 'r', encoding='utf-8') as pb:
        i = 1
        for line in pb:
            if f'{cont[ask]}: {ask_2}' in line:
                flag = False
                persons[i] = line
                i += 1
    if flag:
        print('нет такого контакта')
    return persons


def print_phonebook():
    with open('phonebook.txt', 'r', encoding='utf-8') as pb:
        persons_data = pb.read().split('\n')
    return persons_data


def load():
    new_phonebook = input('введи путь к файлу: ')
    with open(new_phonebook, 'r', encoding='utf-8') as npb:
        with open('phonebook.txt', 'a+', encoding='utf-8') as opb:
            for line in npb:
                if line not in opb:
                    opb.write(line)


def transform():
    ask = input(
        '''
        1 - добавить контакт,
        2 - изменить контакт,
        3 - удалить контакт.
        введи нужное число: 
        '''
    )

    if ask == '1':
        writing_person()
    elif ask == '2':
        change_person('chen')
    elif ask == '3':
        change_person()
    else:
        print('нет такой команды, попробуй еще раз')
        transform()


def change_person(do='del'):
    persons_data = print_phonebook()
    persons = search()
    print(persons)
    while True:
        ask = int(input('выбери номер кого удалить?: ' if do == 'del' else 'выбери номер кого изменить?: '))
        if 1 >= ask <= len(persons):
            break
    with open('phonebook.txt', 'w', encoding='utf-8') as npb:
        for person in persons_data:
            flag = persons[ask].__contains__(person)
            if flag == False and person != '':
                npb.write(f'{person}\n')
    if do == 'chen':
        while True:
            ask_1 = input(
                '''что хочешь изменить?
                1 - имя,
                2 - фамилия,
                3 - отчество,
                4 - телефон,
                введи нужное число: ''')

            if ask_1 not in '1234':
                print('нет такой команды, попробуй еще раз')
                continue

            ask_2 = input(f'введи новое {cont[ask_1]}: ')
            dp = re.split(';|:', persons[ask])

            if ask_1 == '1':
                writing_person(lastname=dp[1].strip(), name=ask_2, surname=dp[5].strip(), phone=dp[7].strip()),
                break

            elif ask_1 == '2':
                writing_person(lastname=ask_2, name=dp[3].strip(), surname=dp[5].strip(), phone=dp[7].strip()),
                break

            elif ask_1 == '3':
                writing_person(lastname=dp[1].strip(), name=dp[3].strip(), surname=ask_2, phone=dp[7].strip()),
                break

            elif ask_1 == '4':
                writing_person(lastname=dp[1].strip(), name=dp[3].strip(), surname=dp[5].strip(), phone=ask_2),
                break


def main():
    ask = input(
        '''что тебе надо?
        1 - вывести справочник,
        2 - добавить/изменить/удалить контакт ,
        3 - найти контакт,
        4 - импортировать справочник,
        введи нужное число: ''')

    if ask == '1':
        print(print_phonebook())
    elif ask == '2':
        transform()
    elif ask == '3':
        print(search())
    elif ask == '4':
        load()
    else:
        print('нет такой команды, попробуй еще раз')
        main()


if __name__ == '__main__':
    # writing_person()
    # search()
    # print_phonebook()
    # load()
    main()
