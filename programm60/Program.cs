// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//Final homework
int number = ReadInt("Введите число N: ");
int min = 1;

Console.Write ("Обратный порядок чисел: ");
Console.WriteLine(Numbers(number, min));

int Numbers (int n, int min)
{
    if (min == n)
        return min;
    else
        Console.Write(Numbers(n, min+1) + ", ");
    return min;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}