// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите число A");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числоB");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindExponent);

Console.WriteLine($"Число {number1} в степени {number2} равно {FindExponent(number1, number2)}");

int FindExponent(int number1, int number2)

{
    int exp = number1;
    for (int i = 1; i < number2; i++)
    {
        exp = exp * number1;

    }
    return exp;

}

