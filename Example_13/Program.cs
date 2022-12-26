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
//int index = 0;
int counter = 1;
int newnumber = 1;
//Console.WriteLine(newnumber);

while (newnumber > 0)
{
    newnumber = number / 10;
    counter = counter + 1;
    //Console.WriteLine(counter);
   
}
Console.WriteLine(counter);