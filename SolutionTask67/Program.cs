/*----------------------------------------------------------------------
Напишите программу, которая на вход принимает два числа A и B,
и возводит число A в целую степень B c помощью рекурсии
------------------------------------------------------------------------
*/

int numberA = ReadNumber("Задайте число A:");
int numberB = ReadNumber("Задайте число B:");

Console.WriteLine(PowNumber(numberA, numberB));
Console.WriteLine(MyPow(numberA, numberB));

int MyPow(int a, int b)
{
    if(b == 2)
    {
        return a*a;
    }
    if(b == 1)
    {
        return a;
    }
    if(b%2 == 0)
    {
        return MyPow(a,b/2)*MyPow(a, b/2);
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a, (b/2)+1);
    }
}




int PowNumber(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumber(a, --b);
}

int ReadNumber(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()?? "");
}