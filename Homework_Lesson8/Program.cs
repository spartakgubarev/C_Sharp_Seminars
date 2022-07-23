// Урок 8. Как не нужно писать код. Часть 2
// На оценку "5" нужно сделать МИНИМУМ 4 задачи.

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
// Console.Clear();
// Console.WriteLine("Задайте 2-х мерный массив.");
// Console.Write("Задайте количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = RandomArray(rows, columns);
// int[,] RandomArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(100);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void SortingRows(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < rows; i++)
//     {
//         int sortedSize = 0;
//         while (sortedSize < columns)
//         {
//             int index = 0;
//             while (index < columns - 1 - sortedSize)
//             {
//                 if (matrix[i, index] > matrix[i, index + 1])
//                 {
//                     int temp = matrix[i, index];
//                     matrix[i, index] = matrix[i, index + 1];
//                     matrix[i, index + 1] = temp;
//                 }
//                 index++;
//             }
//             sortedSize++;
//         }
//     }
// }
// PrintArray(array);
// SortingRows(array);
// PrintArray(array);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка
// Console.Clear();
// int[,] array = RandomArray(5, 7);
// int[,] RandomArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(10);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] matrix)
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
// int FindMinSumRows(int[,] matrix)
// {
//     int minRows = int.MaxValue;
//     int indexRows = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         if (minRows > sum)
//         {
//             minRows = sum;
//             indexRows = i;
//         }
//     }
//     return indexRows;
// }
// PrintArray(array);
// int indexRows = FindMinSumRows(array);
// Console.WriteLine(indexRows + " строка");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
// Console.Clear();
// int rows = 4;
// int columns = 4;
// int[,] array1 = RandomArray(rows, columns);
// int[,] array2 = RandomArray(rows, columns);
// int[,] RandomArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(10);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int multiplication = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             multiplication = matrix1[i, j] * matrix2[i, j];
//             Console.Write($"{multiplication}\t");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array1);
// Console.WriteLine();
// PrintArray(array2);
// Console.WriteLine("Произведение двух матриц равно:");
// MultiplicationMatrix(array1, array2);



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
// Console.Clear();
// int x = 2, y = 2, z = 2; // x-строка, y-колонка, z-ширина
// int[,,] arrayCube = RandomMatrixCube(x, y, z);
// int[,,] RandomMatrixCube(int x, int y, int z)
// {
//     int n = 10; // увеличение рандома для неповтоярющихся элементов
//     int[,,] array = new int[x, y, z];
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 array[i, j, k] = new Random().Next(n, n + 10);
//                 n += 10;
//             }
//         }
//     }
//     return array;
// }
// void PrintMatrixCube(int[,,] matrixCube)
// {
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 Console.Write($"{matrixCube[i, j, k]} ({i},{j},{k})\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// PrintMatrixCube(arrayCube);



// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// // 10 9 8 7
// Console.Clear();
// int rows = 4;
// int columns=4;
// int[,] matrix = new int[rows, columns];
// int count=1;


// for (int j = 0; j < columns-1; j++)
// {
//     matrix[0,j]=count++;
// }

// for (int i = 0; i < rows-1; i++)
// {
//     matrix[i,rows-1]=count++;
// }

// for (int j = columns-1; j >= 0; j--)
// {
//     matrix[rows-1,j]=count++;
// }

// for (int i = rows-1; i >= 0; i--)
// {
//     matrix[i,rows-1]=count++;
// }



// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"{matrix[i, j]}\t");
//     }
//     Console.WriteLine();
// }


// Задача 61: Вевести первые строки N строк треугольника Паскаля. Сделать вывод в
// виде равнобедренного треугольника.