// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

int start = ReadInt("Введите M: ");
NaturalNumber(start, 1);

void NaturalNumber(int m, int n=1)
{
if (m < n)
return m;
{
if (m > n)
return m-1;
NaturalNumber(m - 1, n);
}
if (m == n)

}


int ReadInt(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine());
}


int NumbersMinMax(int m, int n)
{
if (n == m)
return n;
else
{
Console.Write(NumbersMinMax(m, n - 1) + ", ");
}
return n;
}

int NumbersMaxMin(int n, int m)
{
if (m == n)
return m;
else
{
Console.Write(NumbersMaxMin(n, m + 1) + ", ");
}
return m;
}


