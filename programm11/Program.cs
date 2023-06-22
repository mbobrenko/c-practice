int number =45879554;
int searchDigit=4;
int count = 0; 
int temp =number; 
while (temp > 0)
{
    temp/=10;
    count++;
}

while (count > searchDigit)
{
    number/=10;
    count --;
}
Console.WriteLine(number%10);
