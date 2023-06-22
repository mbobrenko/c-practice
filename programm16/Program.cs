// See https://aka.ms/new-console-template for more information
int aX = ReadInt("Enter x coordinate a point: ");
int aY = ReadInt("Enter y coordinate a point: ");
int bX = ReadInt("Enter x coordinate b point: ");
int bY = ReadInt("Enter y coordinate b point: ");

int sqrSideX = (aX-bX)* (aX-bX);
int sqrSideY = (aY-bY)* (aY-bY);
double distance =Math.Sqrt(sqrSideX+sqrSideY);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
