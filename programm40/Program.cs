// Пользовтель вводит с клавиатуры М чисел.Посчитайте сколько чисел больше 0 ввел пользователь
Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';

WriteArray(ParseArray(input, splitSymbol));

int[] ParseArray(string inputNumbers, char split)
{
int numbersCount = 1;
for(int i = 0; i < inputNumbers.Length; i++)
{
if(inputNumbers[i] == split)
numbersCount++;
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for(int i = 0; i < inputNumbers.Length; i++)
{
if(inputNumbers[i] == split)
{
numbers[numberIndex++] = Convert.ToInt32(subString);
subString = "";
}
else
{
subString += inputNumbers[i];
}
}
numbers[numberIndex] = Convert.ToInt32(subString);
return numbers;
}
void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}