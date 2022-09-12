//Программа  спрашивает сколько у пользователя на руках карт.
Console.WriteLine("Программа подсчёта суммы карт в игре «21» \nВведите кол-во Ваших карт");


// С помощью метода byte.Parse число преобразуется в целочисленную переменную
int userInput = int.Parse(Console.ReadLine());                                                    


Console.WriteLine("Обозначения для карт с картинками \nВалет = J  \nДама = Q \nКороль = K \nТуз = T  ");
Console.WriteLine("Введите первую карту");


// объявление переменной для суммы карт
int cardSum = 0;                           

for (int i = 0; i < userInput; i++)
{

	// объявление переменной для ввода пользователем номинала карты
	string cardValue = Console.ReadLine();   
	int parsedNumber;


	// попытка конвертации в числовое значение
	if (int.TryParse(cardValue, out parsedNumber))
	{
		// при успешной конвертации складываем значение в переменную суммы карт
		if (parsedNumber > 5 & parsedNumber < 11)
		{
			cardSum = cardSum + parsedNumber;
		}
		else 
		{
			Console.WriteLine("Вы ввели неверное число");
			i--;
		}

	}
	else
	{
		// обработка картинок
		switch (cardValue)
		{
			case "J":
			case "Q":
			case "K":
			case "T":
				cardSum = cardSum + 10;
				break;

			default:
				Console.WriteLine("Вы ввели неверное число");
				i--; break;
		}

		

	}
	Console.WriteLine("Введите номинал следующей карты");
}
//Вывод на экран
Console.WriteLine($"Сумма карт равна {cardSum}");