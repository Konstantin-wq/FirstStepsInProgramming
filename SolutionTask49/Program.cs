/*------------------------------------------------------------------------------
Задайте двумерный массив.Найдите элементы, у которых оба индекса четные,
и замените эти элементы на их квадраты
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




//Метод для раскраски массива разными цветами
//Объявляем массив цветов
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


int[,] UpdateTwoDimArray(int[,] inputArray)
{
    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    {
        int i = 0; int j = 0;
        while (i < inputArray.GetLength(0))
        {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    outArray[i, j] = inputArray[i, j] * inputArray[i, j];
                }
                else
                {
                    outArray[i,j] = inputArray[i,j];
                }
                j++;
            }
            i++;

        }

    }

    return outArray;
}



int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintRandomColourTwoDimArray(twoDimArray);
//--------------------------------------------------

//Два равнозначных блока вывода на экран

PrintRandomColourTwoDimArray(UpdateTwoDimArray(twoDimArray));
//--------------------------------------------------------------


int[,] bufTwoDimArray = UpdateTwoDimArray(twoDimArray);
PrintRandomColourTwoDimArray(bufTwoDimArray);