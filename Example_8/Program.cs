// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a = 1;
if(n > 0)
while (a <= n)
{   
    if((a % 2) == 0)
    { 
         Console.Write($"{a} " );
    }

    a++;
}
