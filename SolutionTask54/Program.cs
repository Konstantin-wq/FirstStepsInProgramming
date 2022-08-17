/*--------------------------------------------------------------------------------------------
Программа, которая меняет первую и последнюю строки массива местами
----------------------------------------------------------------------------------------------
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


// Метод меняет местами первую и последнюю строки
//Принимает двумерный массив и возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    {
         int j = 0;


        while (j < inputArray.GetLength(1))
        {
            //Блок ротации элементов
            bufferElement = inputArray[0, j];
            inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
            inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
            j++;
 
        }
        
    }

    return inputArray;
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






int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);

Console.WriteLine();

PrintTwoDimArray(RotateRowFirstLast(twoDimArray));
