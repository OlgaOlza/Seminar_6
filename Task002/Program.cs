// Задача 40. Напишите программу, которая принимает на вход
// 2 числа и проверяет, может ли существовать 
// треугольник со сторанами такой длины 

// Вариант 1

// Console.WriteLine("Введите сторону тренировка x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону тренировка y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону тренировка z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// bool FindTricle(int a, int b, int c)
// {
//      return a + b > c && c + a > b && c + b > a;
// }
// Console.WriteLine(FindTricle(x, y, z) ? "Треугольник существует" : "Треугольника нет");

// Вариант 2

void Tricle(int a, int b, int c)
{
    if ((a + b > c) && (b + c > a) && (c + a > b))
        Console.WriteLine("Треугольник существует");
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInfo("Введите первую сторону: ");
int b = GetInfo("Введите вторую сторону: ");
int c = GetInfo("Введите трутью сторону: ");

Tricle(a, b, c);