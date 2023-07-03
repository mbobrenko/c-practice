// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

Fill2DIntArrayRandomNumbers(numbers);
Write2DIntArray(numbers);
int[] sums = new int[numbers.GetLength(0)];
int indexSum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
for (int j = 0; j < numbers.GetLength(1); j++)
{
sums[indexSum] += numbers[i, j];
}
indexSum++;
}
WriteIntArray(sums);

void Fill2DIntArrayRandomNumbers(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}

void Write2DIntArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
} 