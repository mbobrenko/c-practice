// Напишите программу, котрая по заднному номеру четверти, показывает диапазон возможных координат точек в этой четверти
int quarter = ReadInt("Enter the quarter ");


if (quarter ==1)
{Console.WriteLine("x>0 && y>0");}
else if (quarter ==2)
{ Console.WriteLine("x<0 && y>0");}
   
    else if(quarter ==3)
    {
    Console.WriteLine("x<0 && y<0");
    }
    else if(quarter ==4)
    {Console.WriteLine("x>0 && y<0");}

    Console.WriteLine("no quarter");

    switch (quarter)
{    case1:
        Console.WriteLine("x>0, y>0");
        break;
        case2:
         Console.WriteLine("x<0, y>0");
         break;
        case3:
        Console.WriteLine("x<0, y<0");
         break;
        case4:
        Console.WriteLine("x>0, y<0");
         break;
        default:
        Console.WriteLine("4 quarter only");
        break;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
