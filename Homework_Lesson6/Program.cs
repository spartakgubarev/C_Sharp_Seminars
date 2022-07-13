// Урок 6. Двумерные массивы и рекурсия

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,сколько чисел
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Write("Сколько чисел будете вводить? ");
// int numberCount = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int[] array = new int[numberCount];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{i + 1} = ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i] > 0) count++;
// }
// Console.Write($"{String.Join(";", array)} -> {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.WriteLine("Программа ищет пересение двух прямых y=k1*x+b1 и y=k2*x+b2.");
// Console.Write("Введите k1 = ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b1 = ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2 = ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2 = ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// double x = -(b1 - b2) / (k1 - k2);
// double y = k2 * x + b2;
// Console.WriteLine($"k1= {k1}, b1= {b1}, k2= {k2}, b2= {b2} -> ({x} ; {y})");
