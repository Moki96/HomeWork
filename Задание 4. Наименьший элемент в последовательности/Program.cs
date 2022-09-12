Console.WriteLine("Введите длину последовательности");

int sequence = int.Parse(Console.ReadLine());


// на момент инициализации выбрано максимальное значение числа, для того чтобы
// любое из чисел, которые будет вводить пользователь, окажется меньше, чем это значение.

int minimumNumber = int.MaxValue;     
for (int i = 0; i < sequence; i++)
{
	Console.WriteLine("Введите целые числа(как положительные, так и отрицательные)");
	int b = int.Parse(Console.ReadLine());

	//Проверка на меньшее число
	if (b < minimumNumber)
	{
		minimumNumber = b;                            
	}
}
// вывод результата
Console.WriteLine($"наименьшее число {minimumNumber}");         