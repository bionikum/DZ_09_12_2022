﻿// Наишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите натуральное число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
    result = result * a;
Console.WriteLine(result);