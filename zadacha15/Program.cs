﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");

int x = Convert.ToInt32(Console.ReadLine());

if (x >0 && x < 6) Console.WriteLine("Этот день не является выходным");
else if (x >5 && x < 8) Console.WriteLine ("Этот день является выходным");
else Console.WriteLine("День введен не верно");

 