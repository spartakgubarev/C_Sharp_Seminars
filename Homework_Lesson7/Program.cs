// Урок 7. Как не нужно писать код. Часть 1

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.Clear();
// //Console.WriteLine(Math.Round(new Random().NextDouble(),2));
// Console.WriteLine("Задайте двумерный массив размером m x n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[rows, columns];
// void RandomMatrix(double[,] matrix)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(-10, 11), rnd.Next(2));
//         }
//     }
// }
// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// RandomMatrix(matrix);
// PrintMatrix(matrix);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.Clear();
// Console.WriteLine("Задайте двумерный массив размером m x n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// void RandomMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(21);
//         }
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void FindPositionMatrix(int[,] matrix)
// {
//     Console.Write($"Введите строку - от 0 по {matrix.GetLength(0) - 1} ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"Введите столбец - от 0 по {matrix.GetLength(1) - 1} ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     if (rows >= 0 & rows <= matrix.GetLength(0) - 1 &&
//         columns >= 0 & columns <= matrix.GetLength(1) - 1) Console.WriteLine("Ваш элемент - " +
//                 matrix[rows, columns]);
//     else Console.WriteLine("Такого элемента в массиве нет.");
// }
// void FindMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     Console.Write($"Введите искомое число - ");
//     int findNumber = Convert.ToInt32(Console.ReadLine());
//     bool find = false;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == findNumber)
//             {
//                 Console.WriteLine($"Искомое число в строке {i}, столбце {j}");
//                 find = true;
//             }
//         }
//     }
//     if (find == false) Console.WriteLine($"{findNumber} -> такого числа в массиве нет.");
// }
// RandomMatrix(matrix);
// PrintMatrix(matrix);
// FindPositionMatrix(matrix);
// FindMatrix(matrix);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.Clear();
// Console.WriteLine("Задайте двумерный массив размером m x n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// void RandomMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void AverageColumns(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         double sumAverage = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sumAverage += matrix[j, i];
//         }
//         Console.WriteLine($"Среднее арифм. столбца {i} = {Math.Round(sumAverage / matrix.GetLength(0), 1)}");
//     }
// }
// RandomMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// AverageColumns(matrix);
