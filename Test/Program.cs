Console.WriteLine("Игра угадайка \nВведите диапазон загадываемого числа");

int maxNumber = int.Parse(Console.ReadLine());

Random random = new Random();                                         //Создание рандома

                                                      // Создание переменной - ввода пользователя
int hiddenNumber = random.Next(1, maxNumber + 1);                     //Создание рандомного числа в заданном пользователем диапазоне

Console.WriteLine("Число загадано, теперь попробуйте угадать");

while (true)
{
	string userInput = Console.ReadLine();
	int userNumber;

	// Сравнение числа с загаданным, и вывод результата на экран
	if (int.TryParse(userInput, out userNumber))
    {
		if (userNumber == hiddenNumber)
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Поздравляю, число угадано!");
			Console.ForegroundColor = ConsoleColor.White;
			break;

		}
		else if (userNumber > hiddenNumber)
		{                                                                                                          
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Введеное число больше загаданного. Попробуйте еще раз.");
			Console.ForegroundColor = ConsoleColor.White;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Введеное число меньше загаданного. Попробуйте еще раз.");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
	else
    {
		Console.WriteLine("Приложение закрывается");
    }
	

	
	

}