/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.Clear();
Console.WriteLine("Задача 27");

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int number = GetNumber("Введите число ");
int Sum = 0;
while (number > 0)
{
    Sum = Sum + (number % 10);
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе равна: {Sum}");