//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

//string[] NewArray = { "Sunй", "Mon", "Tuewew", "Wed", "Thu555", "Fri2", "S5" }; //тут ввод массива на старте алгоритма

string[] inputArray() //метод ввода массива пользователем
{
    Console.Write("Введите кол-во элементов массива:\t");
    int elementsAmount = int.Parse(Console.ReadLine());
    if (elementsAmount < 0 || elementsAmount > 2147483647)//тут я делаю проверку на ввод, показываю, что знаю лимит типа int, но работает, как работает
    {
        Console.Write($"кол-во элементов массива в формате int и не может быть больше 2147483647 и должно быть положительным!");
    }
    string[] array = new string[elementsAmount];//создаю массив с заданным кол-вом элементов
    for (int i = 0; i < array.Length; i++)//начинаю принимать значения с клавиатуры
    {
        Console.Write($"Введите элемент массива с индексом {i}:\t");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ArrayLimitElementLength(string[] inputArray)//метод поиска элементов определенной длинны и заполнение ими нового массива
{
    int count = 0;//кол-во переменных в новом массиве
    int elemenLimit = 3;//в задании не было ввода макс длины символа от пользователя, но в рамках борьбы с магическими числами введена эта переменная
    for (int j = 0; j < inputArray.Length; j++)//подсчет кол-ва переменных в новом массиве
    {
        if (inputArray[j].Length < elemenLimit + 1)
        {
            count += 1;
        }
    }
    string[] outputArray = new string[count];//новый массив с определенным кол-вом элементов
    int index = 0;//индекс нового массива
    int i = 0;//индекс исходного массива
    while (i < inputArray.Length)//перебор исходного массива и поиск элементов с необходимой длинной символов, их запись в новый массив
    {
        if (inputArray[i].Length < elemenLimit + 1)
        {
            outputArray[index] = inputArray[i];
            index += 1;
        }
        i += 1;
    }
    return outputArray;
}

string PrintArray(string[] array)//метод печати массива
{
    string txt = string.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == len - 1)
        {
            txt += $"{array[i]}";//убрал запятую после последнего символа
        }
        else
        {
            txt += $"{array[i]},";
        }
    }
    return $"[{txt}]";
}


string[] NewArray = inputArray();
string[] AnswerArray = ArrayLimitElementLength(NewArray);
Console.WriteLine($"Массив-ответ: {PrintArray(AnswerArray)}");
