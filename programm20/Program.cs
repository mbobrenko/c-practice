// Напишите программу которая принимает на вход число и выдает цифр в числе 
Console.Write("enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number>0)
{
    number/=10;
    count++;
}
Console.WriteLine($"sum is {count}");