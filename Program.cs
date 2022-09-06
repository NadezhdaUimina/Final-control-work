string[] СheckingTheArray(string[] array) //проверка существующего массива на усливия задачи
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)  //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


string[] array = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Массив в котором длина строк меньше либо равна 3 символа: ");
string[] newArray = СheckingTheArray(array);
PrintArray(newArray);