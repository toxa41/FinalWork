// Создать массив строк.
// Вычислить необходимые значения.
// Создать новый массив с необходимыми значениями.
// Вывести на экран.

Console.WriteLine("Создадим массив из нескольких значений.\nКакое колличество значений будем вводить?");
int countArrayValue = int.Parse(Console.ReadLine());

string[] startArray = new string[countArrayValue];

string[] FillArray(string[] array)
{
    for (int i = 0; i < countArrayValue; i++)
    {
        Console.Write($"Введите {i + 1} значение: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] array)
{
    int countNecessaryValue = 0;
    int limitSymbol = 3;
    string arrayValue = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= limitSymbol) countNecessaryValue++;
    }

    string[] endArray = new string[countNecessaryValue];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= limitSymbol)
        {
            endArray[index] = array[i];
            index++;
        }
    }
    return endArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Введенные числа больше 3 символов! Массив пустой.");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  [{array[i]}]");
    }
}

FillArray(startArray);

string[] endArray = SortArray(startArray);

Console.WriteLine("\n Первоначальный массив:");
PrintArray(startArray);

Console.WriteLine("\n Массив значений с длинной (<) либо = (3) символа:");
PrintArray(endArray);