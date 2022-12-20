// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int DeliteSecondDidgit(int number)
{
    int first = number / 100;
    int end = number % 10;
    int res = first * 10 + end;
    return res;

}

int maxDigit = DeliteSecondDidgit(number);
Console.WriteLine($"Удаляет вторую цифру числа => {maxDigit} ");
