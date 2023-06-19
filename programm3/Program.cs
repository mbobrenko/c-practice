/*Написать программу, которая на вход принимает два числа и проверяет является ли первое число квдратом второго*/
Console.Write("Enter first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int sqr = numberTwo*numberTwo;
if(numberOne == sqr)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
/*Написать программу которая выдает по цифре дни недели*/
