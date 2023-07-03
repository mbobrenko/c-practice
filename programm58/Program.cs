// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int number = ReadInt("Введите число: ");
Console.WriteLine("Сумма цифр заданного числа равна: " + Sum(number));

int Sum(int n)
{
if (n > 0)
return n % 10 + Sum(n / 10);

return 0;
}

int ReadInt(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine());
}