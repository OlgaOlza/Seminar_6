// Задача 39 
// Напишите программу, которая перевернет одномерный
//  массив (Последний элемент будет на первом месте,
//   а первый на последнем и т.д )
//   [1 2 3 4 5] -> [5 4 3 2 1]
//   [6 7 3 6] -> [6 3 7 6]

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
// int[] arr = CreateRandomArray(4, -9, 9);
// //Array.Revers(array);
// void ReversArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// PrintArray(arr,"[","]");
// ReversArray(arr);
// PrintArray(arr,"[","]");


// Вариант 2

// Функция замена первого на последнее и т.д
void ReversedArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

// Функция, которая генерирует новый массив

int[] NewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue + 1);
    return array;
}
// конец 

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetInfo("Введите размер массива: ");
int[] array = NewRandomArray(number, 1, 9);
Console.Write("[" + string.Join(", ", array) + "] -> ");
ReversedArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
