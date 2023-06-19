//Пользователь ввел число вывести послднюю цифру этого числа

Console.WriteLine("Enter the number: ");
int number=Convert.ToInt32(Console.ReadLine());
if(number>99)
{if(number<1000)
    {
    int lastDigit = number % 10;
    Console.WriteLine(lastDigit);
    }
}