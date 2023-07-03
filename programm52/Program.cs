// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.m = 3, n = 4.0,5 7 -2 -0,21 -3,3 8 -9,98 7,8 -7,1 9

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
Fill2DIntArrayRandomNumbers(numbers);
Write2DIntArray(numbers);

for(int k = 0; k < numbers.GetLength(0); k++)
{
for(int i = 0; i < numbers.GetLength(1); i++)
{
for(int j = 0; j < numbers.GetLength(1) - 1; j++)
{
if(numbers[i, j] < numbers[i, j + 1])
{
int temp = numbers[i, j];
numbers[i, j] = numbers[i, j + 1];
numbers[i, j + 1] = temp;
}
}
}
}
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

void Write2DIntArrayRandomNumbers(int[,] array)
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