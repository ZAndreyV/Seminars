// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Write("Введите 2 числа:");
int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SquareNumber(first_number, second_number) ? "Да" : "Нет");

bool SquareNumber(int num1,int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}