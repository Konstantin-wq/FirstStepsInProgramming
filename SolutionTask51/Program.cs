/*------------------------------------------------------------------------------------------
№47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
--------------------------------------------------------------------------------------------
*/

// Заполняем двумерный массив
double[,] FillTwoDimArray(int countRow, int countColumn)

{
    System.Random numberSynteztor = new System.Random();

    int i = 0; int j = 0;

    double[,] outArray = new double[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSynteztor.NextDouble() * 40 - 20;
            j++;

        }
        i++;
    }

    return outArray;
}


//Объявляем массив с палитрой цветов

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};


//Выводим массив на экран и округляем значения элементов массива

void PrintRandomColourTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            //Округляем значения массива до 3 знаков после запятой
            Console.Write(Math.Round(inputArray[i, j],3) + "\t");    
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;

    }
    Console.ResetColor();
}


double[,] twoDimArray = FillTwoDimArray(4, 6);
PrintRandomColourTwoDimArray(twoDimArray);