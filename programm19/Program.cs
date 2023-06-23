// НАписать на вход число которое и выдает сумму от 1 до этого числа 
Console.Write ("Enter the number: ");
int number =Convert.ToInt32(Console.ReadLine());

int sum=0;
/*int i=1;

while (i<= number)
{
sum+=i;
i++;
}*/

for (int i=0; i<=number; i++)
{
    sum+=i;
}
Console.Write ("sum: "+sum);