// Урок 5. Функции продолжение
// Внимание, внимание! Начиная с этого дз при оценке учитывается оформление и
// названия переменных. Будьте внимательны)

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.Write("Введите количество элементов в массиве: ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// int evenNumbers = 0;
// int[] array = new int[arrayLength];
// for (int i = 0; i < arrayLength; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0) evenNumbers++;
// }
// Console.WriteLine($"Массив: [{string.Join(",", array)}] -> {evenNumbers}");
// попытка метода
// Console.Write("Введите количество элементов в массиве: ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// int[] array = RandomArray(arrayLength);
// Console.WriteLine($"Массив: [{string.Join(",", array)}] -> {EvenNumbersArray(array)}");

// int EvenNumbersArray(int[] array)
// {
//     int evenNumbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) evenNumbers++;
//     }
//     return evenNumbers;
// }

// int[] RandomArray(int arrayLength)
// {
//     int[] array = new int[arrayLength];
//     for (int i = 0; i < arrayLength; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.Write("Введите количество элементов в массиве - ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arrayLength];
// int sumOddElement = 0;
// for (int i = 0; i < arrayLength; i++)
// {
//     array[i] = new Random().Next(-99, 100);
//     if (i % 2 != 0) sumOddElement += array[i];
// }
// Console.Write($"Массив: [{String.Join(",", array)}] -> {sumOddElement}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Console.Write("Введите количество элементов в массиве: ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[arrayLength];
// double max = 0;
// double min = 0;
// for (int i = 0; i < arrayLength; i++)
// {
//     Console.Write($"Введите array {i} = ");
//     array[i] = Convert.ToDouble(Console.ReadLine());
//     if (i == 0)
//     {
//         max = array[i];
//         min = array[i];
//     }
//     if (array[i] < min) min = array[i];
//     if (array[i] > max) max = array[i];
// }
// Console.Write($"Массив: [{String.Join(";", array)}] -> разница max-min= {max - min}");
