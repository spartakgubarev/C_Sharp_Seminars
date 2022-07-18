// Задача 46: Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// Console.WriteLine("Введите двумерный массив m x n : ");
// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().NextDouble() * 50;
//         Console.Write($"{matrix[i, j]} " + "\t"); // \t табуляция
//     }
//     Console.WriteLine("");
// }


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m + n
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// Console.WriteLine("Введите двумерный массив m и n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = i + j;
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }


// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.
// Console.WriteLine("Введите двумерный массив m и n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// void RandomMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(9);
//         }
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// void FindParityIndex(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }
// RandomMatrix(matrix);
// PrintMatrix(matrix);
// FindParityIndex(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);



// Задача 51: Найти сумму элементов главной диагонали.
// Например, задан масси:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Console.WriteLine("Введите двумерный массив m и n:");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// string sum = string.Empty;
// int[,] matrix = new int[rows, columns];
// void RandomPrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void SumDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     Console.Write($"Сумма элементов главной диагонали: ");
//     for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
//     {
//         sum += matrix[i, i];
//         Console.Write($"{matrix[i, i]} ");
//     }
//     Console.WriteLine($" = {sum}");
// }
// RandomPrintMatrix(matrix);
// SumDiagonal(matrix);
