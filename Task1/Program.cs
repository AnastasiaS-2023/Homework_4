﻿// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write($"{Math.Pow(A, B)} ");