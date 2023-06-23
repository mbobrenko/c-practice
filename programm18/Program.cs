// Проверить полидром 
int number = 12321; 

int first= number/10000;
int second =number/1000 % 10;
int third = number /100 %10;
int four = number /10 % 10;
int fifth = number %10;

if (first == fifth && second ==four)
{
Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
