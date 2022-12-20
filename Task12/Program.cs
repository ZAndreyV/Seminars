// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое целое число:");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int second_number = Convert.ToInt32(Console.ReadLine());
 
 void Multiplisity(int first_number, int second_number)
 {
    if (first_number % second_number == 0) Console.WriteLine("Число кратно");
    else Console.WriteLine($"Число не кратно, остаток {first_number % second_number}");
 }

Multiplisity(first_number,second_number);
