// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{



    int[] numBool = new int[size];
    {
        for (int i = 0; i < size; i++)

        {
            Console.Write($" Введите число {i + 1} ");
            numBool[i] = int.Parse(Console.ReadLine()!);

        }
        return numBool;

    }
}
void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(", ", array)}]");

}


PrintArray(CreateArray(8));
