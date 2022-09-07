using System; // Подключенное пространство имен

namespace HomeWork.ConsoleApp // Объявление пространства имен для данного кода
{
	class Program // Объявление класса Program
	{
		static void Main(string[] args) // Объявление метода Main
		{
			#region Приложение по определению четного или нечетного числа
			Console.WriteLine("Приложение по определению чётного или нечётного числа. \n Укажите число для проверки "); // На экране программа с помощью оператора Console.WriteLine предлагает пользователю ввести целое число.

			int number = int.Parse(Console.ReadLine()); // С помощью метода int.Parse число преобразуется в целочисленную переменную

			if (number % 2 == 0)                             // С помощью оператора деления с остатком определяется, чётное число или нечётное.
			{
				Console.WriteLine($"Число {number} является четным ");
			}
			else                                                             // Вывод на экран в зависимоти от условия
			{
				Console.WriteLine($"Число {number} является нечетным");
			}

			#endregion

			Thread.Sleep(1500);        // задержка перед тем, как очистить консоль
			Console.Clear();         // чистим консоль

			#region Подсчет карт 21

			Console.WriteLine("Программа подсчёта суммы карт в игре «21» \nВведите кол-во Ваших карт");            //Программа  спрашивает сколько у пользователя на руках карт.

			int userInput = int.Parse(Console.ReadLine());                                                    // С помощью метода byte.Parse число преобразуется в целочисленную переменную


			Console.WriteLine("Обозначения для карт с картинками \nВалет = J  \nДама = Q \nКороль = K \nТуз = T  ");
			Console.WriteLine("Введите первую карту");

			int cardSum = 0;                            // объявление переменной для суммы карт

			for (int i = 0; i < userInput; i++)
			{
				var cardValue = Console.ReadLine();  // я так и не понял как определять через TryParse, сейчас ищу информацию. По этому использовал неявный тип var


				switch (cardValue)
				{
					case "6":
						cardSum = cardSum + 6;
						break;
					case "7":
						cardSum = cardSum + 7;
						break;
					case "8":                                                     //  обработка "цифровых" карт
						cardSum = cardSum + 8;
						break;
					case "9":
						cardSum = cardSum + 9;
						break;
					default:
						cardSum = cardSum + 10;
						// обработка для карты 10 или "картинок" т.к. они равны 10ти
						break;
				}
				Console.WriteLine("Введите номинал следующей карты");


			}
			Console.WriteLine($"Сумма карт равна {cardSum}");                                       //Вывод на экран

			#endregion


			Thread.Sleep(1500);        // задержка перед тем, как очистить консоль
			Console.Clear();         // чистим консоль


			#region Проверка простого числа

			{
				Console.WriteLine("Введите число для определения простоты");

				bool meaning = true;
				int a = 0;
				int i = 2;
				number = int.Parse(Console.ReadLine());

				while (meaning)
				{
					a = number % i;
					i++;

					if (a != 0)
					{
						Console.WriteLine("Простое ");
						break;
					}
					else
					{
						Console.WriteLine("Не простое");
						break;
					}
				}
			}

			#endregion


			Thread.Sleep(1500);        // задержка перед тем, как очистить консоль
			Console.Clear();         // чистим консоль



            #region Определение наименьшего числа

            Console.WriteLine("Введите длину последовательности");

			int sequence = int.Parse(Console.ReadLine());

			int minimumNumber = int.MaxValue;     // на момент инициализации выбрано максимальное значение числа, для того чтобы любое из чисел, которые будет вводить пользователь, окажется меньше, чем это значение.

			for (int i = 0; i < sequence; i++)
			{
				Console.WriteLine("Введите целые числа(как положительные, так и отрицательные)");
				int b = int.Parse(Console.ReadLine());

				if (b < minimumNumber)
				{
					minimumNumber = b;                             //Проверка на меньшее число
				}
			}

			Console.WriteLine($"наименьшее число {minimumNumber}");         // вывод результата


			#endregion


			Thread.Sleep(1500);        // задержка перед тем, как очистить консоль
			Console.Clear();         // чистим консоль


            #region Угадывание числа


            Console.WriteLine("Игра угадайка \nВведите диапазон загадываемого числа");

			int maxNumber = int.Parse(Console.ReadLine());                                     

			Random random = new Random();                                         //Создание рандома
			
			int userNumber;                                                       // Создание переменной - ввода пользователя
			int hiddenNumber = random.Next(1, maxNumber + 1);                     //Создание рандомного числа в заданном пользователем диапазоне

			Console.WriteLine("Число загадано, теперь попробуйте угадать");

			while (true)
            {
				userNumber = int.Parse(Console.ReadLine());

				if ( userNumber == hiddenNumber)                                                     
                {
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Поздравляю, число угадано!");
					Console.ForegroundColor = ConsoleColor.White;
					break;
					
				}
				else if (userNumber > hiddenNumber )
                {                                                                                                          // Сравнение числа с загаданным, и вывод результата на экран
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

            #endregion









        }
    }
}

	
