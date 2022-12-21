/* Задача № 9
Напишите программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
Например:
78 -> 8
12 -> 2
85 -> 8
*/
Console.Clear();

int GetNumbeFromRange(int start, int end)
{
    int number = new Random().Next(start,end + 1);
    return number;
}
int GetMaxDigital(int number)
{
    int digit1 = number % 10;
    int digit2 = number / 10;
    int max = 0;
    if (digit1 > digit2)
    {
        max = digit1;
    }
    else 
    {
        max = digit2;
    }
    return max;
}
/*for(int i = 0; i < 10; i++)
{
    int randomNumber = GetNumbeFromRange(10,99);
    int maxDigit = GetMaxDigital(randomNumber);
    Console.WriteLine($"Для числа {randomNumber} максимальной цифрой является {maxDigit}");
}*/

int randomNumber = GetNumbeFromRange(10,99);
int maxDigit = GetMaxDigital(randomNumber);
Console.WriteLine($"Для числа {randomNumber} максимальной цифрой является {maxDigit}");