/* Задача № 11
Напишите программу, которая выводит случайное 
трёхзначное чмсло и удаляет вторую цифру этого числа.
Например:
456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();
int GetNumbeFromRange(int start, int end)
{
    int number = new Random().Next(start,end + 1);
    return number;
}
int DeleteSecondDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int result = digit1 * 10 + digit3;
    return result;
}
/*for(int i = 0; i < 10; i++)
{
    int randomNumber =GetNumbeFromRange(100, 999);
    int numberWithoutSecond = DeleteSecondDigit (randomNumber);
    Console.WriteLine($"Число {randomNumber} без второй цифры {numberWithoutSecond}");
}*/
int randomNumber =GetNumbeFromRange(100, 999);
int numberWithoutSecond = DeleteSecondDigit (randomNumber);
Console.WriteLine($"Число {randomNumber} без второй цифры {numberWithoutSecond}");