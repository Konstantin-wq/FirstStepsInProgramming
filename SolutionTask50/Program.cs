/*------------------------------------------------------------------------------
Задайте двумерный массив.Найти сумму элементов, находящихся на главной
диагонали (с индексами (0,0); (0,1) и т.д)
--------------------------------------------------------------------------------
*/


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


// Метод вычисления элементов на главной диаганали
int CalcDiagTwoDimArray (int[,] inputArray)
{
    int outSumDiagonal = 0;
    {
        int i = 0; int j = 0;
        while (i < inputArray.GetLength(0))
        {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                if(i==j)
                {
                    outSumDiagonal = outSumDiagonal + inputArray[i,j];
                }
                j++;
            }
            i++;

        }

    }

    return outSumDiagonal;
}





ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};
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



int[,] twoDimArray = FillTwoDimArray(10,10);
PrintRandomColourTwoDimArray(twoDimArray);

int sum = CalcDiagTwoDimArray(twoDimArray);
Console.WriteLine(sum);




