// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int lineA = ReadInt("Введите сторону A: ");
int lineB = ReadInt("Введите сторону B: ");
int lineC = ReadInt("Введите сторону C: ");

if(CheckSide(lineA, lineB, lineC) && CheckSide(lineB, lineA, lineC) && CheckSide(lineC, lineB, lineA))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool CheckSide(int checkSide, int a , int b)
{
return checkSide < a + b;
}
