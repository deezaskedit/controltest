const int numofl = 4; //создаем константу чтобы не брать из неоткуда число)

int GetArraySize()//создание первого метода
{
    int size = 0; //изначальная переменная
    while (size < 1)// цикл
    {
        try//почитал в интернете про try, должно все получится
        {
            Console.Write("Введите количество элементов в массиве:");
            size = Convert.ToInt32(Console.ReadLine()); //Сохраняем в переменную size

            if (size < 1) Console.WriteLine("Введите значение больше единицы:");
        }
        catch (System.FormatException) // если вылезет ошибка
        {
            Console.WriteLine("Введите число!");//выводим сообщение на экран
        }
    }
    return size;

}

string[] CreateArray()// создание 2 метода
{
    int size = GetArraySize();//метод с размером
    string[] newarray = new string[size];//создаем новый массив
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");//вводим строку в массив
        string? textarray = Console.ReadLine();//записываем и переписываем переменную(? взял с интернета, вроде как убирает ошибку)

        if (textarray == null) newarray[i] = string.Empty; // делаем чтобы на null не ругался терминал
        else newarray[i] = textarray;//присваиваем текст

    }
    return newarray;//результат
}
string[] MainArray(string[] newarray) //создаем 3 отдельный метод типа стринг
{
    string[] sec_array = new string[newarray.Length];//создаем массив с такой же длинной
    for (int i = 0; i < newarray.Length; i++)
    {
        if(newarray[i].Length < numofl) sec_array[i] = newarray[i];//записываем при условии
    }
    return sec_array;// результат
}
void ShowArray(string[] newarray) // объявляем метод
{
    for(int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] != null) // выводим только в случае если массив не пустой
        {
            if(i == newarray.Length - 1) Console.Write($"[{newarray[i]}]"); // последняя строка без запятой:))
            else Console.Write($"[{newarray[i]}], ");
        }
    }
    Console.WriteLine(); // пустая строка
}
string[] array = CreateArray();
Console.Write($"Первый массив: ");
ShowArray(array);
Console.Write($"Второй массив: ");
ShowArray(MainArray(array));