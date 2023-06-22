var firstNumber = Readint("Enster the first number: ");
int secondNumber = Readint("Enter the second number: ");
int remainder = firstNumber % secondNumber;
int message;
if (remainder == 0)
{
Console.WriteLine("Multiple");
}
else
{
Console.WriteLine($"{firstNumber} Not multiple {secondNumber}, {remainder}");
Console.WriteLine("Not multiple, "+ remainder);
}
int Readint(string message);
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}