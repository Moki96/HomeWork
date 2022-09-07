Console.WriteLine("Проведем тестирование цикла Вайл");
Random randGame = new Random();
Random Bot = new Random();


byte game = Convert.ToByte(randGame.Next(2, 25));
Console.WriteLine("Давай ссыграем в игру. \n Наш бот загадает число от 1 до 25. \nНаша задача приветси это число к нулю." +
    " \nТы и компьютер по очереди вычитаете из этого числа от 1 до 4");
Console.WriteLine("Выйграет тот, кто быстрее дойдет до 0");
Console.WriteLine($"Загаданное число {game}");


while (game >= 1)
{
    Console.WriteLine("Твой ход");
    byte otvetPlayer = Convert.ToByte(Console.ReadLine());
    game = (byte)(game - otvetPlayer);

    if (game >= 4)
    {
        byte otvetBot = Convert.ToByte(Bot.Next(4, 5));
        Console.WriteLine($"Число равно {game} , Ход компьютера");
        game = (byte)(game - otvetBot);
    }
    else if (game == 3)
        {
        byte otvetBot = Convert.ToByte(Bot.Next(3, 4));
        Console.WriteLine($"Число равно {game} , Ход компьютера");
        game = (byte)(game - otvetBot);
    }
else if (game == 2 )
    {
        byte otvetBot = Convert.ToByte(Bot.Next(2, 3));
        Console.WriteLine($"Число равно {game} , Ход компьютера");
        game = (byte)(game - otvetBot);
    }
    else
    {
        byte otvetBot = Convert.ToByte(Bot.Next(1, 2));
        Console.WriteLine($"Число равно {game} , Ход компьютера");
        game = (byte)(game - otvetBot);
    }
    
    Console.WriteLine($"Число равно {game} , Твой ход");

}