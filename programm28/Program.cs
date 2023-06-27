﻿// See https://aka.ms/new-console-template for more information
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 10);
WriteArray(numbers);

int searchNumber = ReadInt("Введите искомое число: ");
bool exist = false;

for(int i = 0; i < numbers.Length; i++)
{
if (searchNumber == numbers[i])
{
exist = true;
break;
}
}
if(exist)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");


void FillArrayRandomNumbers(int[] array, int min, int max)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
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