/*-----------------------------------------------------------------------------------------------
Задайте двумерный массив размера m x n, каждый элемент в массиве
находится по формуле Amn = m+n. Вывести массив на экран
-------------------------------------------------------------------------------------------------
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
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
        i++;

    }
    Console.ResetColor();
}

//Массив который по условию задачи выдаст сумму индексов
void UpdateTwoDimArray(ref int[,] inputArray)
{
    {
        int i = 0; int j = 0;
        while (i < inputArray.GetLength(0))
        {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                inputArray[i,j] = i+j;
                j++;
            }
            i++;

        }

    }


}



int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintRandomColourTwoDimArray(twoDimArray);


UpdateTwoDimArray(ref twoDimArray);
PrintRandomColourTwoDimArray(twoDimArray);
