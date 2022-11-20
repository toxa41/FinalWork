// Создать массив строк.
// Вычислить необходимые значения.
// Создать новый массив с необходимыми значениями.
// Вывести на экран.

Console.WriteLine("Создадим массив из нескольких значений.\nКакое колличество значений будем вводить?");
int countArrayValue = int.Parse(Console.ReadLine());

string [] startArray = new string [countArrayValue];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArrayValue; i++)
	{
		Console.WriteLine($"Введите {i} значение:");
		array[i] = Console.ReadLine();
	}
	return array;
}
