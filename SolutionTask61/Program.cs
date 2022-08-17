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
        Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
        i++;

    }

}

int[,] MultiplicationOfArray(int[,] inputArray1,  int[,] inputArray2)
{
    int[,] outPutArray = new int[inputArray1.GetLength(0),inputArray1.GetLength(1)];
    
    for (int i = 0; i < inputArray1.GetLength(0); i++)
{
    for (int j = 0; j < inputArray1.GetLength(1); j++)
    {
        for (int k = 0; k < inputArray1.GetLength(1); k++)
        {
            outPutArray[i, j] = outPutArray[i, j] + (inputArray1[i, k] * inputArray2[k, j]);
        }
    }
}
return outPutArray;
}


int[,] firstTwoDimArray = FillTwoDimArray(3, 3);
int[,] secondTwoDimArray = FillTwoDimArray(3,3);

Console.WriteLine("Матрица №1:");
PrintTwoDimArray(firstTwoDimArray);

Console.WriteLine("Матрица №2:");
PrintTwoDimArray(secondTwoDimArray);
if(firstTwoDimArray.GetLength(1) != secondTwoDimArray.GetLength(0))
{
    Console.WriteLine("Матрицы перемножить невозможно!");
}
else
{
Console.WriteLine();
int [,] resultArray = MultiplicationOfArray(firstTwoDimArray,secondTwoDimArray);
Console.WriteLine("Результат умножения матриц: ");
PrintTwoDimArray(resultArray);
}