//Задача №1 
//Напишите программу,которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> Да
// a = 2; b = 10 -> Нет
// a = 9; b = -3 -> Да
// a = -3; b = 9 -> Нет

Console.Clear();
Console.Write("Введите число № один: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число № два: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA == numberB * numberB)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет"); 
}



