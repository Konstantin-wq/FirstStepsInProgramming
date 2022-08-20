/*----------------------------------------------------------------------------------------------
Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов
в промежутке от M до N
------------------------------------------------------------------------------------------------
*/

int numberM = ReadData("Задайте число M:");
int numberN = ReadData("Задайте число N:");


if (numberM < numberN)
{

    SumNaturalNumber(numberM, numberN, 0);
}
else
{

    SumNaturalNumber(numberN, numberM, 0);
}



int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}


//Рекурсивный метод нахождения суммы 
void SumNaturalNumber(int m, int n, int sum)
{

    if (m > n)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + m;
    SumNaturalNumber(m + 1, n, sum);

}





