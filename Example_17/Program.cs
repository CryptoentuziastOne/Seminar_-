/* Задача N17/
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X=/ 0 и Y =/ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
    }
int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}

int userX = getUserValue ("Введите X");
int userY = getUserValue ("Введите Y");
int quarter = getQuarterNumber(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX}, {userY}] находится в {quarter} четверти");
}
    else
{
     Console.WriteLine($"Точка [{userX}, {userY}] находится на оси координат");
}

   

