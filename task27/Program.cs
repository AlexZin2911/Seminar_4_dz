// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Checker()
{
    while (true)
    {
        Console.WriteLine("Введите число, цифры которого будем суммировать, или * * (Пробел), если передумали, и нажмите после ввода Enter");
        string num = Console.ReadLine()!;

        if (num == " ")
        {
            Console.WriteLine($"До скорого!");
            System.Environment.Exit(0);
            return -1;
        }
        else if (int.TryParse(num, out int isItNum))
            return isItNum;
    }
}
while (true)
{
    string num = Checker().ToString();
    int sum = 0;

    Console.Write($"Сумма цифр в числе {num} = ");

    foreach (char a in num)
    {
        sum += a - '0';
    }

    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length - 1)
        {
            Console.Write($"{num[i]} + ");
        }
        else
        {
            Console.Write($"{num[i]} = ");
        }
    }

    Console.WriteLine($"{sum}");
}