# Выполненная работа

1. Открыл папку HomeWork
2. Инициализировал папку Homework, как репозиторий - командой **git init**
3. Проверил статус репозитория - командой **git status**
4. Создал файл ExecutedWork.md. Далее:

   * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
   * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Created new file ExecutedWork.md"**

5. Создал файл BlockDiagram.drawio. Далее:

   * Проиндексировал изменения в файле BlockDiagram - командой **git add BlockDiagram.drawio**
   * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Created new file BlockDiagram.drawio"**

6. Создал файл Program.py. Далее:

   * Проиндексировал изменения в файле Program - командой **git add Program.py**
   * Зафиксировал изменения файла Program - командой **git commit -m "Created new file Program.py"**

7. Написал блок-схему к программе Program в файле BlockDiagram.drawio. Далее:

   * Сохранение файла - командой Ctrl+S
   * Проиндексировал изменения в файле BlockDiagram - командой **git add BlockDiagram.drawio**
   * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Written block-diagram for Program.py"**

8. В файле Program.py набрал и проверил программный код вывода последовательности чисел от -N до N (N вводиться с клавиатуры). Далее:

   * Сохранение файла - командой Ctrl+S
   * Проиндексировал изменения в файле Program - командой **git add Program.py**
   * Зафиксировал изменения файла Program - командой **git commit -m "Written program output numbers from -N to N"**

9. Написал блок-схему к программе ImprovedProgram в файле BlockDiagram.drawio. Далее:

   * Сохранение файла - командой Ctrl+S
   * Проиндексировал изменения в файле BlockDiagram - командой **git add BlockDiagram.drawio**
   * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Add block-diagram for ImprovedProgram.py"**

10. Создал файл ImprovedProgram.py. Далее:

    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла ImprovedProgram - командой **git commit -m "Created new file ImprovedProgram.py"**

11. В файле ImprovedProgram.py набрал и проверил программный код вывода последовательности чисел от -N до N с условием N>0 и N<10 (N вводиться с клавиатуры). Далее:

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Written program for output numbers from -N to N with condition N>0 and N<10"**

12. Записал в файл ExecutedWork.md свои действия при выполнении домашней работы. Далее:

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Written executed work"**

13. Исправлена ошибка в файле ExecutedWork.md

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Fixed a bug"**

14. Добавлен пункт в файле ExecutedWork.md

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Add 13 and 14 items"**

15. В файле Program удалены не нужные ";". Далее:

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле Program - командой **git add Program.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Delete unnecessary symbol ;"**

16. В файле ImprovedProgram удалены не нужные ";". Далее:

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле Program - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Delete unnecessary symbol ;"**

17. В файл ExecutedWord добавлены 2 пункта. Далее:

    * Сохранение файла - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Add 15, 16 and 17 items"**

18. Вывел в терминал перечень созданных коммитов - командой **git log --oneline**. Далее сделал скриншот экрана.

19. Созданы четыре ветки для работы с файлами:

    * Ветка br_bl (для работы с файлом BlockDiagram.drawio) - командой **git checkout -b br_bl**
    * Ветка br_ex (для работы с файлом ExecutedWork.md) - командой **git checkout -b br_ex**
    * Ветка br_pr (для работы с файлом Program.py) - командой **git checkout -b br_pr**
    * Ветка br_im (для работы с файлом ImprovedProgram.py) - командой **git checkout -b br_im**

20. В файл Program добавлено условие проверки вводимой цифры для построения последовательности. Для этого:

    * Проверил в какой ветки нахожусь - командой **git branch**
    * Перешел в ветку br_pr - командой **git checkout br_pr**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле Program - командой **git add Program.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Added condition in text program Program.py"**

21. В файл ExecutedWord добавлены 3 пункта. Для этого:

    * Перешел в ветку br_ex - командой **git checkout br_ex**
    * Внес изменения в текст и сохранил файл - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Added 19, 20 and 21 items"**

22. В файл Program добавлены комментарии к тексту программы. Для этого:

    * Перешел в ветку br_pr - командой **git checkout br_pr**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле Program - командой **git add Program.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Added comments in text program Program.py"**

23. Осуществил слияние веток br_pr и master. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Провел слияние веток - командой **git merge br_pr**

24. В файл ExecutedWord добавлены 3 пункта. Для этого:

    * Перешел в ветку br_ex - командой **git checkout br_ex**
    * Внес изменения в текст и сохранил файл - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Added 22, 23 and 24 items"**

25. В файл ImprovedProgram добавлены комментарии к тексту программы. Для этого:

    * Перешел в ветку br_im - командой **git checkout br_im**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Added comments in text program ImprovedProgram.py"**

26. В файле ImprovedProgram изменено условие задачи, ввод числа ограничен 15, вместо 9. Для этого:

    * Перешел в ветку br_im - командой **git checkout br_im**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла Program - командой **git commit -m "Changed the task condition, from 9 to 15"**

27. В файл ImprovedProgram изменено условие проверки вводимой цифры для построения последовательности. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла ImprovedProgram - командой **git commit -m "Changed condition in text program ImprovedProgram.py"**

28. Осуществил слияние веток br_im и master. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Провел слияние веток - командой **git merge br_pr**. В результате выполнения команды, git попросил вручную определить какое будет слияние веток, выбран параметр **accept incoming change**
    * Сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add ImprovedProgram.py**
    * Зафиксировал изменения файла ImprovedProgram - командой **git commit -m "Merge error. Merge branchs br_im and master, accept incoming change"**

29. В файл ExecutedWord добавлены 5 пунктов. Для этого:

    * Перешел в ветку br_ex - командой **git checkout br_ex**
    * Внес изменения в текст и сохранил файл - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Added 25, 26, 27, 28 and 29 items"**

30. В файле BlockDiagram в блок-схему к программе Program.py добавлено условие проверки введенного с клавиатуры значения переменной N. Для этого:

    * Перешел в ветку br_bl - командой **git checkout br_bl**
    * Внес изменения в блок-схему и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле BlockDiagram - командой **git add BlockDiagram.drawio**
    * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Added condition in block-diagram to program Program.py"**

31. В файле BlockDiagram в блок-схеме к программе ImprovedProgram.py изменено условие, ввод числа ограничен 15, вместо 9. Для этого:

    * Внес изменения в блок-схему и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле BlockDiagram- командой **git add BlockDiagram.drawio**
    * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Changed condition in block-diagram to program ImprovedProgram.py"**

32. В файле BlockDiagram добавлено описание блок-схем. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Внес изменения в текст программы и сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле ImprovedProgram - командой **git add BlockDiagram.drawio**
    * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Added descriptions block-diagrams"**

33. Осуществил слияние веток br_bl и master. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Провел слияние веток - командой **git merge br_bl**. В результате выполнения команды, git попросил вручную определить какое будет слияние веток, выбран параметр **accept incoming change**
    * Сохранил изменения - командой Ctrl+S
    * Проиндексировал изменения в файле BlockDiagram - командой **git add BlockDiagram.drawio**
    * Зафиксировал изменения файла BlockDiagram - командой **git commit -m "Merge error. Merge branchs br_bl and master, accept incoming change"**

34. В файл ExecutedWord добавлены 5 пунктов. Для этого:

    * Перешел в ветку br_ex - командой **git checkout br_ex**
    * Внес изменения в текст и сохранил файл - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Added 30, 31, 32, 33 and 34 items"**

35. Осуществил слияние веток br_ex и master. Для этого:

    * Перешел в ветку master - командой **git checkout master**
    * Провел слияние веток - командой **git merge br_ex -m "Merge branchs br_ex and master"**.

36. В файл ExecutedWord добавлены 2 пункта. Для этого:

    * Внес изменения в текст и сохранил файл - командой Ctrl+S
    * Проиндексировал изменения в файле ExecutedWork - командой **git add ExecutedWork.md**
    * Зафиксировал изменения файла ExecutedWork - командой **git commit -m "Added 35 and 36 items"**

## Работа с удаленным репозиторием

1. Копирование существующего удаленного репозитория на локальную машину. Для этого необходимо:

    * Открыть в браузере сайт **GitHub.com**
    * В поиске найти интересующий аккаунт (должен быть с открытым доступом) и перейти в него
    * В открывшемся аккаунте нажать на вкладку **Repositories** и выбрать из предложенного перечня необходимый репозиторий. Репозиторий должен быть с открытым доступом
    * В открывшемся репозитории перейти на вкладку **<> Сode**, далее нажать на зеленую кнопку **<> Code**, из всплывшего меню скопировать **https://...** ссылку
    * Перейти в VS Code на локальной машине
    * В VS Code открыть папку, в которую будет копироваться удаленный репозиторий
    * Область открытой папки проверить на то, чтобы данную папку не отслеживал git - команда **git status**. Если данную папку git не отслеживает, то в неё можно копировать удаленный репозиторий, иначе нельзя, необходимо выбрать другую папку
    * Копируем удаленный репозиторий в папку - команда **git clone https://...**. (https://... - скопированная на GitHub.com ссылка на удаленный репозиторий)
    * Перейти в репозиторий - команда **cd < имя репозитория >** или закрыть терминал и открыть его заново. Если данный пункт на сделать, то не сможем работать с репозиторием

2. Копирование репозитория с локальной машины на удаленную машину (GitHub.com). Для этого необходимо:

    * Открыть в браузере сайт GitHub.com
    * Перейти в свой аккаунт
    * Создать новый репозиторий:

        * Нажать кнопку **+**, всплывшем меню выбрать пункт **New repository**
        * В окне **Repository name** ввести имя нового репозитория
        * Нажать на зеленую кнопку **Create repository**

    * Отправить с локальной машины репозиторий на удаленную машину:

        * Команда - **git remote add origin https: // GitHub.com / <имя_аккаунта> /  <имя_репозитория_на_GitHub>.git**
        * Команда - **git branch -M main**
        * Команда - **git push -u origin main**

    * Вернуться в свой аккаунт на сайте GitHub.com и обновить страницу, отправленный репозиторий отобразится на странице сайта

3. Актуализация версии репозитория на локальной машине с его версией на удаленной машине

    * Команда - **git pull**

4. Работа с чужим удаленным репозиторием

    * Открыть в браузере сайт **GitHub.com**
    * В поиске найти интересующий аккаунт (должен быть с открытым доступом) и перейти в него
    * В открывшемся аккаунте нажать на вкладку **Repositories** и выбрать из предложенного перечня необходимый репозиторий. Репозиторий должен быть с открытым доступом
    * Скопировать к себе в аккаунт выбранный репозиторий:

      * Нажать кнопку **Fork**
      * В открывшейся странице внести необходимые настройки (Например, изменить имя репозитория) и нажать зеленую кнопку **Create Fork**
  
    * Нажать на зеленую кнопку **<> Code**, из всплывшего меню скопировать **https://...** ссылку
    * Перейти в VS Code на локальной машине
    * В VS Code открыть папку, в которую будет копироваться удаленный репозиторий
    * Область открытой папки проверить на то, чтобы данную папку не отслеживал git - команда **git status**. Если данную папку git не отслеживает, то в неё можно копировать удаленный репозиторий, иначе нельзя, необходимо выбрать другую папку
    * Копируем удаленный репозиторий в папку - команда **git clone https://...**. (https://... - скопированная на GitHub.com ссылка на удаленный репозиторий)
    * Перейти в репозиторий - команда **cd < имя репозитория >** или закрыть терминал и открыть его заново. Если данный пункт на сделать, то не сможем работать с репозиторием
    * Внести изменения в репозиторий
    * Отправить с локальной машины корректированный репозиторий на удаленную машину:

        * Команда - **git remote add origin https: // GitHub.com / <имя_аккаунта> /  <имя_репозитория_на_GitHub>.git**
        * Команда - **git branch -M main**
        * Команда - **git push -u origin main**

    * Вернуться в свой аккаунт на сайте GitHub.com и обновить страницу, изменения репозитория отобразятся на странице сайта
    * Перейти по вкладке **Pull requests**
    * На открывшейся странице нажать на зеленую кнопку **New pull request**, переход в аккаунт, из которого скачали репозиторий
    * На открывшейся странице нажать на зеленую кнопку **Create pull request**
    * Написать commit и, пожеланию, написать комментарий к изменениям репозитория
    * Снова нажать на зеленую кнопку **Create pull request**
