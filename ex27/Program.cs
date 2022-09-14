// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int FindSumLength(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        sum = sum + digit;
        num = num / 10;

    }
    return sum;

}
Console.Write(" Введите число ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе равна {FindSumLength(num)}");
