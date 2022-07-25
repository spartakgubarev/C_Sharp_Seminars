// Рекурсия - вызов функции
// n! = 1..n

// int Factorial(int number)
// {
//     // Базовый случай - выход из рекурсии
//     if (number == 1) return 1;
//     // Рекурсивный случай - вызов рекурсии
//     return (number * Factorial(number - 1));
// }

// Console.Write(Factorial(4));

// string Hello()
// {
//     Hello();
//     return "Hello";
// }

// Hello();



// Задача 63: Задайте значение N.
// Напишите  программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// // 1 - start, end - N
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.Write(PrintNumbers(1, N));



// Задача 65: Задайте значение M и N.
// Напишите  программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1, N = 5 -> "1, 2, 3, 4, 5"
// M = 4, N =  -> "4, 5, 6, 7, 8"
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// // M - start, end - N
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.Write(PrintNumbers(M, N));



// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Console.Write("Введите число, программа вернет сумму цифр: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumber(int n)
// {
//     if (n == 0) return 0;
//     return (n % 10 + SumNumber(n / 10));
// }
// Console.WriteLine(SumNumber(number));



// Задача 69: Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурвии.
// А = 3; В = 5 -> 243 (3^5)
// А = 2; В = 3 -> 8
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Exponentiation(int a, int b)
// {
//     if (b == 1) return a;
//     if (b == 0) return 1;
//     return a * Exponentiation(a, b - 1);
// }
// Console.WriteLine(Exponentiation(a, b));
