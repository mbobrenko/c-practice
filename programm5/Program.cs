// Напишите программу которая на вход принимает число и выдает его квадрат
Console.WriteLine("Enter the number: ");
int number=Convert.ToInt32(Console.ReadLine());
int negativeNumber = -number;
while(negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}
