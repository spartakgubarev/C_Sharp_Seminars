// Урок 4. Функции продолжение

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите числа А и В, компьютер возвед А в степень В");
// Console.Write("Введите А - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите В - ");
// int b = Convert.ToInt32(Console.ReadLine());
// int sum = 1;
// for (int i = 1; i <= b; i++)
// {
//     sum *= a;
// }
// Console.WriteLine($"{a} в степени {b} = {sum}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("Введите число, программа посчитает сумму всех чисел - ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = number % 10;
// while (number / 10 != 0)
// {
//     sum += (number / 10) % 10;
//     number /= 10;
// }
// Console.WriteLine($"Сумма всех чисел - {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите размер массива - ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayMy = new int[sizeArray];
int[] arrayComputer = new int[sizeArray];
for (int i = 0; i < sizeArray; i++)
{
    Console.Write($"Введите число 0 до 9 [{i}] = ");
    arrayMy[i] = Convert.ToInt32(Console.ReadLine());
    arrayComputer[i] = new Random().Next(10);
}
Console.WriteLine($"[{String.Join(",", arrayMy)}] - Ваш массив");
Console.WriteLine($"[{String.Join(",", arrayComputer)}] - мой массив");
for (int b = 0; b < sizeArray; b++) if (arrayMy[b] == arrayComputer[b]) Console.WriteLine(
    $"Имеются совпадения в массиве [{b}], число - {arrayMy[b]}");
