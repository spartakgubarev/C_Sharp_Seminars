// Урок 3. Массивы и функции в программировании
// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.Write("Введите 5-ти значное число, проверим, является ли полиндромом: ");
// string numbers = Console.ReadLine();
// if (numbers[0] == numbers[4] && numbers[1] == numbers[3]) Console.WriteLine(numbers + " -> да");
// else Console.WriteLine(numbers + " -> нет");


// Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Write("Введите АХ= ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите АY= ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите АZ= ");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите BХ= ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите BY= ");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите BZ= ");
// int bz = Convert.ToInt32(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow(Math.Abs(ax - bx), 2) +
//                             Math.Pow(Math.Abs(ay - by), 2) +
//                             Math.Pow(Math.Abs(az - bz), 2));
// Console.WriteLine($"Расстояние между точками = {distance}");


// Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Write("Введите N, я посчитаю куб N от 1 до N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{i * i * i} ");
// }
