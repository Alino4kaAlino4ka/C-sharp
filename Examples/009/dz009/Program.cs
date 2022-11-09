﻿// ВСЕ ЗАДАЧИ РЕШАТЬ ЧЕРЕЗ РЕКУРСИЮ!

// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите натуральное число");
// int n = Convert.ToInt32(Console.ReadLine());

// void RecNums(int num)
// {
//     if (num == 0) return;
//     if (num == 1)Console.Write($"{num}");
//     else 
//     {
//         Console.Write($"{num}, ");
//         RecNums(num - 1);
//     }
// }

// RecNums(n);




// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// Console.WriteLine("Введите натуральное число");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int m, int n)
// {
//     if (m == n) return n;
//     return n + SumRec(m, n - 1);
// }

// Console.WriteLine($"{SumRec(m, n)}");





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine();
Console.WriteLine($"A(m,n) = {AckermanFunction(m, n)}");


