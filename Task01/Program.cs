﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое целое число:");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int second_number = Convert.ToInt32(Console.ReadLine());
int square = second_number * second_number;
if (square == first_number)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
