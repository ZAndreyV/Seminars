﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)  Console.Write(arr[i] + ", ");
        else  Console.Write(arr[i]);
    }
    Console.Write("]");
}


int[] MultiplyArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length%2 != 0) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            newArr[i]= arr[i] * arr[arr.Length - 1-i];
        else newArr[i] = arr[i];
        // newArr[i] = arr[i] * arr[arr.Length-1-i];
    }
    return newArr;

}

int[] array = CreatArrayRndInt(4, -9, 9);
PrintArray(array);
int[] newarray = MultiplyArray(array);
PrintArray(newarray);


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
}

