// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)[1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

int[] revertNumbers = new int[size];
for(int i = 0; i < revertNumbers.Length; i++)
{
revertNumbers[i] = numbers[numbers.Length - 1 - i];
}
WriteArray(revertNumbers);

void FillArrayRandomNumbers(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
}
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
