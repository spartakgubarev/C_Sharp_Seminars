// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Clear();
// Console.WriteLine("Введите M и N, я посчитаю сумму чисел от M до N");
// Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int minM, int maxN)
// {
//     if (minM == maxN) return minM;
//     return minM + SumNumber(minM + 1, maxN);
// }
// Console.WriteLine(SumNumber(m, n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// Console.Clear();
// int m = 3;
// int n = 5;

// int FunctionAkkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return FunctionAkkerman(m - 1, 1);
//     return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
// }

// Console.WriteLine(FunctionAkkerman(m, n));