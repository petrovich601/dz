﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число N:");
int nam = Convert.ToInt32(Console.ReadLine());
int nam3 = nam3 = nam / 100;
int nam2 = (nam - (nam3 *100)) / 10;
Console.WriteLine(nam2);