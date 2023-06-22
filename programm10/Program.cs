// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите первое число: ");

if(Sqr(firstNumber) == secondNumber || Sqr(secondNumber) == firstNumber)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

int Sqr(int number)
{
return number * number;
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
