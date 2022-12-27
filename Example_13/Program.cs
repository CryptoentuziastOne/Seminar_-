/*Задача №13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Например:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int index = 0;
int counter = 0;
int numberB = 0; 
numberB = number;
int index_two = 1;
int numberC = 0;
int ten = 10;
int result = 0;

if (number < 100)
{
    Console.WriteLine($"Это число [{number}] является двухзначным третьей цифры нет");
}
else if (number >= 100 && number < 1000)
{
    result = number % 10;
    Console.WriteLine($"Это число [{number}] является трёхзначным и третьей цифрой в нём будет [{result}]");
}
else if (number >= 1000 && number < 10000)
{
    result = (number / 10) % 10;
        Console.WriteLine($"Это число [{number}] является четырёхзначным и третьей цифрой в нём будет [{result}]");
}
while (numberB != 0)
{
    numberB = numberB / 10;
    index++;     
}
int stepen = index - 3;
while (index_two < stepen)
{
    numberC = ten * 10;
    ten = numberC;
    index_two = index_two + 1;
}
int three = number / numberC;
result = three % 10;

Console.WriteLine($"Это число [{number}] является {index}-значным и третьей цифрой в нём будет [{result}]");


/*Console.WriteLine(number);
Console.WriteLine(stepen);
Console.WriteLine(index);
Console.WriteLine(numberC);
Console.WriteLine(three);
Console.WriteLine(result);*/

