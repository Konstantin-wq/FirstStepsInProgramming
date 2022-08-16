/*---------------------------------------------------------------------------------------------------------
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.
-------------------------------------------------------------------------------------------------------------
*/

//Объявлем массив с палитрой цветов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};




// Метод заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)

{
    System.Random numberSynteztor = new System.Random();

    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSynteztor.Next(0, 101);
            j++;
        }
        i++;
    }

    return outArray;
}


//Метод вычисления среднего арифметического по столбцам
double[] CalcAvg(int[,] inputArray)
{

    double[] average = new double[inputArray.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum = sum + inputArray[j, i];
            average[i] = sum / inputArray.GetLength(1);

        }
    }
    return (average);
}


//Нахождение среднего арифметического по главной диагонали
double CalcDiagTwoDimArray(int[,] inputArray)
{
    double outSumDiagonal = 0;
    double avg = 0;
    int k = 0;
    {
        int i = 0; int j = 0;
        while (i < inputArray.GetLength(0))
        {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                if (i == j)
                {
                    outSumDiagonal = outSumDiagonal + inputArray[j, i];
                    k = k + 1;

                }
                j++;
            }
            i++;

        }

    }
    avg = outSumDiagonal / k;

    return avg;
}



//Выод массива на экран
void PrintRandomColourTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
        i++;

    }
    Console.ResetColor();
}


//Метод печати среднего арифметического значения
void PrintAvgSum(double[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + "\t");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}


//Выводим на экран главную диагональ
void PrintMainDiag(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if(i == j)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;

    }
    Console.ResetColor();
}


int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintRandomColourTwoDimArray(twoDimArray);

double[] averageSum = CalcAvg(twoDimArray);
PrintAvgSum(averageSum);


double sum = CalcDiagTwoDimArray(twoDimArray);
Console.WriteLine("Среднее арифметическое элементов главной диагонали: " + sum);

int[,] twoDimArrayMainDiag = twoDimArray;
PrintMainDiag(twoDimArray);