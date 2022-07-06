// int [] array = {1,2,3,4,5};
// Console.WriteLine ($"[{String.Join(",",array)}]");

// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 7 - > 28
// 4 - > 10
// 8 - > 36
// Console.Write("Программа считает сумму всех чисел, введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма чисел равна {sum}");

// Console.Write("Программа считает сумму всех чисел, введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int sum = 0;
// while (i <= number)
// {
//     sum += i;
//     i++;
// }
// Console.WriteLine($"Сумма чисел равна {sum}");



// Задача 26: Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.Write("Введите любое число, я отвечу сколько цифр в числе: ");
// string number = Console.ReadLine();
// Console.WriteLine($"Количество цифр - {number.Length}");
// та же задача
// Console.Write("Введите любое число, я отвечу сколько цифр в числе: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (number != 0)
// {
//     number /= 10;
//     count++;
// }
// Console.WriteLine(count);


// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// Console.Write("Введите число, я выведу произведение от 1 до N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// for (int i = 2; i <= number; i++)
// {
//     factorial *= i;
// }
// Console.WriteLine($"Факториал {number}! = {factorial}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
// }
// Console.Write($"[{String.Join(",", array)}]");
// та же
// int[] array = GetBinaryArray(20);
// Console.WriteLine($"[{String.Join(" ", array)}]");
// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }
