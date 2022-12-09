Console.Write("Введите число дня недели от 1 до 7: ");
int numberday = int.Parse(Console.ReadLine()!);

if (numberday < 1 || numberday > 7)
{
    Console.WriteLine ("Вы ввели неверное число");
}

if (numberday > 5 && numberday <= 7 )
{
    Console.WriteLine ("Да, этот день выходной!");
}

if (numberday <= 5 && numberday >= 1 )
{
    Console.WriteLine ("Нет, этот день не выходной");
}

