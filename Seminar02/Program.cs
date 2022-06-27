/* 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и
показывает наибольшую цифру числа
78 -> 8
12-> 2
Ex: 45 (4) < (5), max = 5
85 -> 8 
*/
// int number = new Random().Next(10, 100); // [10,100)
// Console.WriteLine($"Рандомное число: {number}"); // Интерполяция
// int digitOne = number / 10; // 45 -> 4
// int digitTwo = number % 10; // 45 -> 5
// Console.WriteLine($"Первая цифра нашего числа: {digitOne}");
// Console.WriteLine($"Вторая цифра нашего числа: {digitTwo}");
// int max = Math.Max(digitOne,digitTwo);
// // Функция Math.max сравнивает два числа и возвращает максимальное
// Console.WriteLine($"Самое больше число из двух {max}");


// Напишите программу, которая выводит случайное
//трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int number = new Random().Next(100,1000);
// Console.WriteLine("Случайное число: "+number);
// int digitOne = Convert.ToInt32(number/100);
// int digitTwo = Convert.ToInt32(number%10);
// int result = digitOne*10+digitTwo;
// Console.WriteLine(result);


// 12.Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// Console.Write("Введите первое число: ");
// int digitalOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int digitalTwo = Convert.ToInt32(Console.ReadLine());
// if (digitalOne % digitalTwo == 0) Console.WriteLine($"Число {digitalOne} кратно число {digitalTwo}");
// else Console.WriteLine($"{digitalOne} разделить на {digitalTwo} равно {digitalOne / digitalTwo} остаток " + digitalOne % digitalTwo);



// 14.Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// Console.Write("Введите число, компьютер проверит на кратность 7 и 23: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number %7==0 && number%23 == 0) Console.WriteLine($"Число {number} кратно 7 и 23");
// else Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");

// 14.Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// РЕШЕНИЕ ЧЕРЕЗ ФУНКЦИЮ!!!
// int number = Convert.ToInt32(Console.ReadLine());
// bool parityСheck(int number)
// {
//     return (number % 7 == 0 && number % 23 == 0); // True, False
// }
// Console.WriteLine(parityСheck(number));
