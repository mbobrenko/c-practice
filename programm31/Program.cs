//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76
int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);


void FillArrayRandomNumbers(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
int randomNumber = new Random().Next(100, 1000);
array[i] = Convert.ToDouble(randomNumber) / 100;
}
}

void WriteArray(double[] array)
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
