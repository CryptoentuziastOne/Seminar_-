/* Задача № 14
 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.
Например:
14 -> нет
46 -> нет
161 -> да
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0)
{   
    if (number % 23 == 0)
    {
        Console.Write($"Число {number} кратное числам 7 и 23" );
    }
    else
    {
        Console.Write($"Число {number} НЕ кратное числам 7 и 23" );
    }
}
else 
{
    Console.Write($"Число {number} НЕ кратное числам 7 и 23" );
}