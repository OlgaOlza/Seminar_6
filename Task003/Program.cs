// Задача 42. Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 - > 11
// 2 -> 10

// Вариант 1

// void PrintArray(int[] array, string elem1, string elem2)
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
// int[] Binary(int numb)
// {
//     int numb1 = numb;
//     int digits = 0;
//     while (numb1 > 0)
//     {
//         numb1 /= 2;
//         digits += 1;

//     }
//     int[] bin = new int[digits];
//     for (int i = 0; i < bin.Length; i++)
//     {
//         bin[bin.Length-i-1] = numb % 2;
//         numb /= 2;
//     }
//     return bin;
// }


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] binary = Binary(number);
// // Console.WriteLine(Binary(number));
// PrintArray(Binary(20), "", "");

// Вариант 2

void DefRes(int num) // число делим на 2 и аписываем остаток
{
    string temp = "";
    // int temp2 = 0
    while (num > 0)
    {
        temp = (num % 2).ToString() + temp;
        num = num / 2;
    }
    Console.WriteLine(temp);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");
DefRes(num);