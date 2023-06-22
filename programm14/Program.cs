// Напишите программу которая принимает координаты и выдает номер четверти плоскости в которой она находиться ]
while(true)
{ 
    int x = ReadInt("enter x: ");
    int y = ReadInt("enter y: ");
    if (x!=0 && y!=0)
    {
     Console.Write("hey");
    }
    else 
    {
    Console.Write("x y не 0");
    continue;
    }
    if (x>0 && y>0)
    {
    Console.Write("1");
    }
    else if (x<0 && y>0)
    {
    Console.Write("2");
    }
    else if (x<0 && y<0)
    {Console.Write("3");}
    else if (x>0 && y<0)
    {Console.Write("4");}
    break;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}