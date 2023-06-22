int number =ReadInt("Enter a number: ");
int i=1;

while (i<=number)
{
    Console.Write(i*i+"");
    i++;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
