﻿// Написать программу, которая на вход принимает число а выдает квадрат
/*int number = Convert.ToInt32(Console.ReadLine());*/
Console.WriteLine("Enter the number ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
Console.WriteLine(number);
int sqr = number * number;
Console.Write(number + " ");
Console.WriteLine(sqr);