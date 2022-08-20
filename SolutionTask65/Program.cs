/*------------------------------------------------------------------------------
Задайте значения M и N. Программа, которая выведет все натуральные числа от M до N

--------------------------------------------------------------------------------
*/

int numberM = ReadData("Задайте число M:");
int numberN = ReadData("Задайте число N:");


if (numberM < numberN)
{
    NaturalNumberPrinter(numberM, numberN);
}
else
{
    NaturalNumberPrinter(numberN, numberM);
}



int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}



void NaturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNumberPrinter(m + 1, n);

}



