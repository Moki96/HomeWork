Console.WriteLine("Введите число для определения простоты");

bool meaning = true;
int a = 0;
int i = 2;
int number = int.Parse(Console.ReadLine());

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
