/*Задача №12 Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. 
 Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 == 0)
{
    Console.Write($"Число {number2} кратное числу {number1}" );
}
else 
{
    int Ostatok = number1 % number2;
     Console.Write($"Число {number2} НЕ кратное числу {number1} Остаток {Ostatok}" );
}
