// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int a = ReadInt("Введите число: ");
int b = ReadInt("Введите степень: ");
Console.WriteLine($"{a} в степени {b} = {Pow(a, b)}");

int Pow(int a, int pow)
{
if(pow == 0)
return 1;

return a * Pow(a, pow - 1);
}

int ReadInt(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine());
}
