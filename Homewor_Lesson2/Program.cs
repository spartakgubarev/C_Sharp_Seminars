// Урок 2.Массивы и функции в программировании

// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.Write("Введите 3-х значное число, компьютер покажет вторую цифру ");
// int number = Convert.ToInt32(Console.ReadLine());
// int remainderDivision = number % 100;
// int seconNumber = remainderDivision / 10;
// string length = Convert.ToString(number);
// Console.Write($"В средине цифра - {seconNumber}    ");


// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Clear();
// Console.Write("Введите трехзначное число или больше, компьютер выдаст третью цифру ");
// string number = Console.ReadLine();
// if (number.Length < 3) Console.WriteLine("Третьей цифры нет.");
// else
// {
//     int thirdNumber = Convert.ToInt32(number) / Convert.ToInt32(Math.Pow(10, number.Length - 3)) % 10;
//     // (число / 10^(длина строки -3(третья цифра))) из всего берем остаток от деления на 10
//     Console.WriteLine($"Третья цифра - {thirdNumber}");
// }

// Задача 13!!!!! МОЖНО КОНЕЧНО И ТАК !!!!!
// Console.Write("Введите трехзначное число или больше, компьютер выдаст третью цифру ");
// string number = Console.ReadLine();
// if (number.Length < 3) Console.Write("Третьей цифры нет.");
// else Console.Write(number[2]);


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.Clear();
// Console.Write("Введите день недели в цифровом формате от 1 до 7: ");
// int numberWeek = Convert.ToInt32(Console.ReadLine());
// if (numberWeek == 6 ^ numberWeek == 7) Console.Write(numberWeek + " - да");
// else Console.Write(numberWeek + " - нет");
