// Task #1
// Напишите программу,
// которая на вход принимает число и
// выдает его квадрат (число умножоенное на само себя).
// Например:
// 4-> 16
// - 3-> 9
// - 7-> 49
// Console.Write("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int result = value * value;
// Console.Write("Квадрат данного числа равен: ");
// Console.WriteLine(result);


// Task #2
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет
// Console.Write("Введите первое число: ");
// int firstInteger = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите второе число: ");
// int secondInteger = Convert.ToInt32(Console.ReadLine());
// if (secondInteger * secondInteger == firstInteger)
// {
//     Console.WriteLine("Число " + secondInteger + " является квадратом "+ firstInteger);
// }
// else
// {
//     Console.WriteLine("Число " + secondInteger + " не является квадратом "+ firstInteger);
// }



// Task #3
// Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// Console.Write("Введите число от 1 до 7 (номер недели): ");
// int numberDay = Convert.ToInt32(Console.ReadLine());
// if (numberDay >=1 && numberDay <= 7) // && - and
// {
//     if (numberDay == 1) Console.WriteLine(" - понедельник");
//     if (numberDay == 2) Console.WriteLine(" - вторник");
//     if (numberDay == 3) Console.WriteLine(" - среда");
//     if (numberDay == 4) Console.WriteLine(" - четверг");
//     if (numberDay == 5) Console.WriteLine(" - пятница");
//     if (numberDay == 6) Console.WriteLine(" - суббота");
//     if (numberDay == 7) Console.WriteLine(" - воскресенье");
// }
// else
// {
//     Console.WriteLine("Неверно введен день недели");
// }


// Task #4
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые числа в промежужтке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int negativeN = n * (-1); // 4*(-1) = -4, -4+1 = -3, -3+1 = -2
// // (-N) до N
// while (negativeN <= n)
// {
//     Console.WriteLine(negativeN);
//     negativeN++; // negativeN = negativeN +1
// }


// Task #4
// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 10;
Console.Write("Последняя цифра: " + ostatok);