﻿// Задача №5
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N
// 4-> "-4,-3,-2,-1,0,1,2,3,4"
// 2-> "-2,-1,0,1,2"

Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int a = -x;
while(a <= x)
{
    Console.Write(a+" ");
    a++;
}

