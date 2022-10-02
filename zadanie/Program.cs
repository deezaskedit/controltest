const int numofl = 4; //создаем константу чтобы не брать из неоткуда число)

int GetArraySize()
{
    int size = 0; //изначальная переменная
    while(size < 1)// цикл
    {
        try//почитал в интернете про try, должно все получится
        {
            Console.Write("Введите количество элементов в массиве:");
            size = Convert.ToInt32(Console.ReadLine); //Сохраняем в переменную size

            if(size < 1) Console.WriteLine("Введите значение больше единицы:");
        }
        catch(System.FormatException) // если вылезет ошибка
            {
                Console.WriteLine("Введите число!");//выводим сообщение на экран
            }
    }
    return size;

}