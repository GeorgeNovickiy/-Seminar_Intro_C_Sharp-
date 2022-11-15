﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
Weekend(day);

void Weekend(int numberDay)
{
    if ((numberDay >= 1) && (numberDay <= 5)) Console.WriteLine("Этот день не является выходным.");
    else if ((numberDay >= 6) && (numberDay <= 7)) Console.WriteLine("Этот день является выходным");
    else Console.WriteLine("Такого дня недели нет");
}
