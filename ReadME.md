Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Вначале происходит ввод массива (через консоль или он задан в программе).
Эту часть буду решать обеими способами. Второй способ более простой и не просит описания.
Для первого способа создам метод, который будет запрашивать число в формате int, 
буду делать проверку на переполнение и, что число положительное. Формировать массив с определенным кол-вом элементов и
интерактив с пользователем (пользователь будет вводить элементы массива в формате string).
Исходный массив сформирован.

Далее буду писать метод, который будет вначале определять сколько в веденном ранее массиве элементов имеют длину не более 3 (это будет магическое число, но я назначу ему переменную, чтобы в случае необходимости сделать эту переменную входным значением для метода).
Знаю длину нового массива и начинаю вычленять из исходного массива элементы, длина которых не более 3, вычлененное значение сразу записываю в новый массив.
Получаю новый массив.

И наконец, будет метод печати массива. Буду формировать в текстовую переменную свой массив и сделаю исключение для запятой у последнего элемента.
Метод печати готов.

Обращусь к каждому методу, проверю работу программы.