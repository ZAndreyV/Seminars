﻿/* 7. Напишите программу, которая принемает на вход трёх значное число
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Введите трёх значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
   Console.Write($"Последняя цифра в числе {number} равна {number % 10}");
else 
   Console.Write("Вы ввели не трёх значное число");
