// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string range = Range(quarter);
Console.WriteLine(range);

string Range(string num)
{
    if (num == "1") return "xc > 0 && yc > 0";
    if (num == "2") return "xc < 0 && yc > 0";
    if (num == "3") return "xc < 0 && yc < 0";
    if (num == "4") return "xc > 0 && yc < 0";
    else return ("Out of range");

}


// Math.Pow(2, 2);
// double d = Math.Sqrt(355);

// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);
