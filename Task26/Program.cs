// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int amountOfNumbers = AmountOfNumbers(number);
Console.WriteLine($"{amountOfNumbers}");


int AmountOfNumbers(int num)
{
    int result = 0;
    while (num != 0)
    {
        num = num / 10;
        result = result + 1;

    }
    return result;
}

