// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
/*int count = ReadInt("Введите количество членов ряда Фибоначчи: ");
int firstNumber = 0;
int secondNumber = 1;

if(count > 0)
Console.Write(firstNumber + " ");
if(count > 1)
Console.Write(secondNumber + " ");

for (int i = 2; i < count; i++)
{
int nextNumber = firstNumber + secondNumber;
firstNumber = secondNumber;
secondNumber = nextNumber;
Console.Write(nextNumber + " ");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
*/

int count = ReadInt("Введите количество членов ряда Фибоначчи: ");
int[] fibonacci = new int[count];

if(count > 0)
fibonacci[0] = 0;
if(count > 1)
fibonacci[1] = 1;

for (int i = 2; i < count; i++)
{
fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
WriteArray(fibonacci);

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
