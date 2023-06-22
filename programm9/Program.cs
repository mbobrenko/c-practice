int number = ReadInt("Введите число: ");

int firstDivider = 7;
int secondDivider = 23;

if(IsMultiple(number, firstDivider) && IsMultiple(number, secondDivider))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
bool IsMultiple(int first, int second)
{
return first % second == 0;
}
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}