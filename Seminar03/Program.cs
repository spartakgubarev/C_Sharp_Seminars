// Задача 17. Напишите программу, которая принимает на вход координаты точки (X, Y),
// причем X не равно 0 и Y не равно 0 и
// выдает номер четверти плоскости, в которой находится эта точка.
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Четверть: 1");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("Четверть: 2");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть: 3");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть: 4");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Write("Введите четверть круга координат от 1 до 4: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1) Console.WriteLine($"X=(0;+00); Y=(0;+00)");
// if (number == 2) Console.WriteLine($"X=(-00;0); Y=(0;+00)");
// if (number == 3) Console.WriteLine($"X=(-00;0); Y=(-00;0)");
// if (number == 4) Console.WriteLine($"X=(0;+00); Y=(-00;0)");

// Задача 21: Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Console.Write("Введите координа точки А по X= ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координа точки А по Y= ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координа точки B по X= ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координа точки B по Y= ");
// int by = Convert.ToInt32(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow(Math.Abs(ax - bx), 2) + Math.Pow(Math.Abs(ay - by), 2));
// Console.WriteLine($"Расстояние = {distance}");

// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.Write("Введите число N, компьютер посчитает квадрат N от 1 до N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     int b = i * i;
//     Console.Write(b + ", ");
// }
