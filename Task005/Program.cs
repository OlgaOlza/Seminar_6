﻿// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// Вариант 1

// int[] CreateRandomArray(int size, int min, int max)//Метод обьявления массива случайными элементами
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array, string elem1, string elem2)//Метод вывода массива
// {
//     Console.Write(elem1);
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//             Console.Write($"{array[i]},");
//         else
//             Console.Write($"{array[i]}");
//     }
//     Console.Write(elem2);
// }
// int [] CopyArray(int[]array)
// {int[]copyArray = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     copyArray[i]= array[i];
// }
// return copyArray;

// }
// Console.WriteLine("Введите длинну массива: ");
// int sizeMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int minMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int maxMass = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateRandomArray(sizeMass, minMass, maxMass);
// PrintArray(arr, "[","] --> origin" );
// PrintArray(CopyArray(arr), "[","] --> new");


// Вариант 2





int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
   int[] array = new int[size];
     for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue + 1);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] arrayNew = new int[array.Length];
    for (int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = array[i];
    }
    return arrayNew;
}

int[] array = MakeNewRandomArray(10, 1, 10);
int[] newArray = NewArray(array);
Console.Write($"{string.Join(",", array)} -> {string.Join(",", newArray)}");