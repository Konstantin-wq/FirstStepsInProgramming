/*----------------------------------------------------------------------------------------------
Спирально заполнить массив размерностью 4х4
-------------------------------------------------------------------------------------------------
*/

// Метод заполнения двумерного массива по спирали(ход заполнения "по часовой стрелке")
int[,] FillSpiralTwoDimArray(int countRow, int countColumn)

{
    int i = 0; int j = 0; int number = 1;
    int amountsOfNUmbers = countRow * countColumn;
    int[,] outArray = new int[countRow, countColumn];


    while (number <= amountsOfNUmbers)
    {
        outArray[i, j] = number;
        //Условия заполнения массива
        if (i <= j + 1 && i + j < countRow - 1)
        {
            j++;
        }

        else if (i < j && i + j >= countRow - 1)
        {
            i++;
        }
        else if (i >= j && i + j > countRow - 1)
        {
            j--;
        }
        else
            i--;
        number++;
    }


    return outArray;
}



//Вывод массива на экран
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t ");
            j++;
        }
        Console.WriteLine();
        i++;

    }

}


int[,] spiralTwoDimArray = FillSpiralTwoDimArray(4, 4);
PrintTwoDimArray(spiralTwoDimArray);