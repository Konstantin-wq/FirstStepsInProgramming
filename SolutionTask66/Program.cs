﻿/*-------------------------------------------------------------------------------
Напишите которая будет принимать на вход число,
и возвращать сумму его цифр 
----------------------------------------------------------------------------------

*/


int number = ReadData("Задайте число:");
Console.WriteLine(Sum(number));


int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}




int Sum(int num)
{
    if (num > 0)
    {
        return num % 10 + Sum(num / 10);
    }
    else
    {
        return 0;
    }

}
