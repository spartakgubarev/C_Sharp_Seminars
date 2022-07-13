// Напишите программу, которая перевернет
// одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5 ] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 11);
// }
// Console.WriteLine($"Array: [{String.Join(";", array)}]");
// int[] ReverseArray(int[] array)
// {
//     int[] reverse = new int[array.Length];
//     for (int index = 0; index < array.Length; index++)
//     {
//         reverse[index] = array[array.Length - 1 - index];
//     }
//     return reverse;
// }
// array = ReverseArray(array);
// Console.WriteLine($"ArrayReverse: [{String.Join(";", array)}]");


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины
// Console.Write("Программа проверит возможность существования треугольника, введите АВ= ");
// int sideTriangleAB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ВС= ");
// int sideTriangleBC = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите СА= ");
// int sideTriangleCA = Convert.ToInt32(Console.ReadLine());
// if (sideTriangleAB < sideTriangleBC + sideTriangleCA
//     & sideTriangleBC < sideTriangleAB + sideTriangleCA
//     & sideTriangleCA < sideTriangleBC + sideTriangleAB)
//     Console.WriteLine("Треугольник существует.");
// else Console.WriteLine("Треугольник не существует.");


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.Write("Программа выведеет числа Фибоначи, введите N= ");
// int count = Convert.ToInt32(Console.ReadLine());
// int lastElement = 0;
// int secondElement = 1;
// int fibonacciN = 0;
// Console.Write($"Если N = {count} -> {lastElement} {secondElement} ");
// for (int i = 1; i <= count - 2; i++)
// {
//     fibonacciN = lastElement + secondElement;
//     lastElement = secondElement;
//     secondElement = fibonacciN;
//     Console.Write($"{fibonacciN} ");
// }


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// void ConversionBinary(int number)
// {
//     string result = string.Empty;
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         number /= 2;
//     }
//     Console.WriteLine(result);
// }
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// ConversionBinary(inputNumber);
