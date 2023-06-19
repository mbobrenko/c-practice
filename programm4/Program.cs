/*Написать программу которая выдает по цифре дни недели*/
Console.Write("Enter the number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
//Convert.ToInt32 - конвертировать число в строку//
if(dayNumber == 1)
{
    Console.WriteLine("Monday");
  
}
if(dayNumber == 2)
{
    Console.WriteLine("Tuesday");
  
}
if(dayNumber == 3)
{
    Console.WriteLine("Wednesday");
  
}
if(dayNumber == 4)
{
    Console.WriteLine("Thursday");
  
}
if(dayNumber == 5)
{
    Console.WriteLine("Friday");
  
}
if(dayNumber == 6)
{
    Console.WriteLine("Saturday");
  
}
if(dayNumber == 7)
{
    Console.WriteLine("Sunday");
  
}
