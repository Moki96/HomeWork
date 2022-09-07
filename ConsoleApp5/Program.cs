#region Консольная игра угадайка
static void exit()
{
    Environment.Exit(0);
}
static void time(int Interval)
{
    Thread.Sleep(Interval * 1000);
}




Console.WriteLine("Привет новый пользователь");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Меня зовут МокАйти Консоль-Бот v. 1.1. "); Console.WriteLine();
Console.WriteLine("Я создан для отработки полученых знаний по синтаксису языка программирования С# моего создателя");

Console.WriteLine("Сергея Мокрушина");


Console.ForegroundColor = ConsoleColor.Gray;

Console.WriteLine();
Console.WriteLine("А как тебя зовут?");

string nameClient = Console.ReadLine();
Console.Clear();
Console.WriteLine("Какая у тебя Фамилия?");

string lastNameClient = Console.ReadLine();
Console.Clear();
Console.WriteLine("Сколько тебе лет?");

var age = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (age >= 6)
{
    Console.WriteLine($"Приветствую тебя {nameClient} {lastNameClient}");
}
else
{
    Console.WriteLine($"Данная программа имеет возрастной порог 6+, удачи тебе {nameClient} {lastNameClient}");
    Environment.Exit(0);
    Console.ReadKey();
}

Console.Clear();
Console.WriteLine($"{nameClient} , Давай поиграем в игру - Угадайка?");
Thread.Sleep(1000);
Console.WriteLine("Ответьте да или нет.");

string answer1 = Console.ReadLine().ToLower();

for (; ; )
{

    if (answer1 == "да")
    {
        Console.WriteLine("Отлично!");
        break;
    }
    else if (answer1 == "нет")
    {
        Console.WriteLine($"Жаль, тогда давай прощаться {lastNameClient} {nameClient}");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Введите пожалуйста да или нет");
       
        string answerElse = Console.ReadLine().ToLower();

        if (answerElse == "да")
        {
            Console.WriteLine("Отлично!");
            break;
        }
        else
        Console.WriteLine($"{nameClient} Что ж, придется с тобой попрощаться!");
        Environment.Exit(0);
    }
}
Thread.Sleep(500);
restartApp: Console.WriteLine("Давай начнем");
Thread.Sleep(500);
Console.Clear();
Console.WriteLine("Выбери уровень сложности:");
Console.WriteLine("1 - Легкий \n2 - Средний \n3 - Сложный");

byte complicacy = byte.Parse(Console.ReadLine());
switch (complicacy)
{
    case 1:
        Console.WriteLine("Выбран Легкий Уровень сложности");
        break;
    case 2:
        Console.WriteLine("Выбран Средний Уровень сложности");
        break;
    case 3:
        Console.WriteLine("Выбран Сложный Уровень сложности");
        break;
            }
Console.WriteLine("Идет генерация чисел");

for (int i = 0; i < 25; i++)
{
    Thread.Sleep(70);
    Console.Write(".");
}

Console.WriteLine("Генерация завершена");
Thread.Sleep(500);
Console.Clear();

Random rand = new Random();


    if (complicacy == 1)
    {
        
        Console.WriteLine($"{nameClient}, тебе необходимо угадать число от 1 до 25, которое я загадал");
        Thread.Sleep(500);

    }
    else if (complicacy == 2)
    {
        
        Console.WriteLine($"{nameClient}, тебе необходимо угадать число от 1 до 50, которое я загадал");
        Thread.Sleep(500);
    }
    else if (complicacy == 3)
    {
        
        Console.WriteLine($"{nameClient}, тебе необходимо угадать число от 1 до 100, которое я загадал");
        Thread.Sleep(500);
    }
    else
    {
        Console.WriteLine(".");
    }
    int count = 0;
    int userNumber;
int iiNumber = ((complicacy == 3) ? rand.Next(1, 101) : (complicacy == 1) ? rand.Next(1, 26) : (complicacy == 2) ? rand.Next(1, 51) : 1) ;


    for (; ; )
    {
        Console.WriteLine("\nВведите предполагаемое число: ");
        count++;
        userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber < iiNumber)
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine();
        
    }
        else if (userNumber > iiNumber)
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введеное число больше загаданного. Попробуйте еще раз.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine();
    }
        else
        {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nameClient}, поздравляю! Число угадано верно! \nЧисло попыток {count}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("Надеюсь тебе понравилась наша маленькая игра");
        
  
        break;
            
        }
    }
    
static void Text(string stroka)
{
    string sText = string.Empty;
    Console.WriteLine(stroka);
}
Console.WriteLine();
Console.WriteLine("Повторим?");
    Console.WriteLine();
    Console.WriteLine("Выбери вариант ответа \n1. Повторить игру \n2.Сыграть в следующую игру \n3.Выйти из приложения");

    string answerRestart = Console.ReadLine();

switch (int.Parse(answerRestart))
    {
    case 1:
        goto restartApp;
            break;
    case 2:
        Text("Хорошо, тогда идем дальше");
        break;
    case 3:
        exit();
        break;
}
  






#endregion
