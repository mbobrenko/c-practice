// Напишите программу которая принимает на вход число и выдает Произведение от 1 до этого числа
int number = Convert.ToInt32(Console.ReadLine());
int result =1;

for (int i=1; i<=number; i++)
{
    result*= i;
}
Console.WriteLine($"Sum is{result}");
