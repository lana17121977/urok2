﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите целое  число x");
int x = Convert.ToInt32(Console.ReadLine());
if (x <= 99) Console.WriteLine("Третьей цифры нет");
else
{
    while (x > 999)
        {
            x = x / 10;
        }
    int x3 = x % 10;
    Console.WriteLine("Третья цифра числа равна " + x3);
}    
