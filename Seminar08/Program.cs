// Задача 53: Задайте двумерный массив.
// Наишите программу, которая поменяет местами первую и последнюю строку массива.
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // строчки - m, столбцы - n, min, max
// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++) // строчки
//     {
//         for (int j = 0; j < n; j++) // столбцы
//         {
//             result[i, j] = new Random().Next(min, max + 1); // [min, max] 
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// void ChangesRows(int[,] matrix)
// {
//     int rowCount = matrix.GetLength(0) - 1; // последняя строка
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[rowCount, i];
//         matrix[rowCount, i] = temp;
//     }
// }
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// ChangesRows(array);
// Console.WriteLine();
// PrintArray(array);


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.**
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     int count = 1;
//     for (int i = 0; i < m; i++) // строчки
//     {
//         for (int j = 0; j < n; j++) // столбцы
//         {
//             result[i, j] = count++;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// void ReversalMatrix(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.Write("Матрицу перевернуть невозможно!");
//     else
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[j, i];
//                 matrix[j, i] = matrix[i, j];
//                 matrix[i, j] = temp;
//             }
//         }
//         Console.WriteLine();
//         PrintArray(matrix);
//     }
// }
// int[,] array = GetArray(rows, columns);
// PrintArray(array);
// ReversalMatrix(array);



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший
// элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// int minValue = int.MaxValue; // значение минимального элемента
// int minIndexRows = 0; // задание индекса минимального элемента (строчка)
// int minIndexColumns = 0; // задание индекса минимального элемента (столбец)
// for (int i = 0; i < rows; i++) // строчки
// {
//     for (int j = 0; j < columns; j++) // столбцы
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//         if (minValue > matrix[i, j])
//         {
//             minValue = matrix[i, j];
//             minIndexRows = i;
//             minIndexColumns = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимум: " + minValue);
// Console.WriteLine("Результат: ");
// for (int i = 0; i < rows; i++)
// {
//     if (i != minIndexRows)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (j != minIndexColumns)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

