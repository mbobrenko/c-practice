// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
/* функция ack(n, m)
пока n ≠ 0
если m = 0
m:= 1
иначе
m:= ack(n, m - 1)
n:= n - 1
вернуть m + 1*/

//Final homework
int numberM = ReadInt("Введите число m: ");
int numberN = ReadInt("Введите число n: ");

Console.Write("m,n Ack(m,n) = ");
Console.WriteLine(Ack(numberM, numberN));

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0)
            return Ack(m - 1, 1);
        else
            return Ack(m - 1, Ack(m, n - 1));
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
