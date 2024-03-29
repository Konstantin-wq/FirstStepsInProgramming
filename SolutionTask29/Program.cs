﻿/*-----------------------------------------------------------------------
Программа, которая принимает на вход число и выдает сумму цифр в числе
Сделать оценку времени алгоритма через вещественные числа и строки
-------------------------------------------------------------------------
*/

//Вводим число с консоли

Console.WriteLine("Введите ваше число: ");
string? inputNumber = Console.ReadLine(); 
if (inputNumber != null)

{
    DateTime timePointInt = DateTime.Now;
    DateTime timePointChar = DateTime.Now;

//Метод нахождения суммы цифр через int
void MethodInt()
{    
    int a = int.Parse(inputNumber);
    int b = 0;
    while (a >0)
    {
        b = b+a%10;
        a = a/10;
    }
    Console.WriteLine(b);
}

//Метод нахождения суммы цифр с использованием char
void MethodChar()
{
    char[] value = inputNumber.ToCharArray();
    
    int sum = 0;
    for (int i = 0; i<value.Length; i++)
    {
        int number = (int)char.GetNumericValue(value[i]);
        sum+=number;
    }

    Console.WriteLine(sum);
}

//Расчет времени работы алгоритмов
timePointInt = DateTime.Now;
MethodInt();
Console.WriteLine(DateTime.Now - timePointInt);

timePointChar = DateTime.Now;
MethodChar();
Console.WriteLine(DateTime.Now - timePointChar);

//Сравнение скорости работы алгоритмов
void Comparison()
{
    
if (timePointInt>timePointChar)
{
    
      Console.Write("Время работы программы через строки ,быстрее чем через вещественные числа");
}
if (timePointInt<timePointChar)
{
    Console.WriteLine("Время работы программы через строки, медленнее чем через вещественные числа");
}
else
{
    Console.WriteLine("Время работы программы одинаково ");
}    
}


Comparison();








}