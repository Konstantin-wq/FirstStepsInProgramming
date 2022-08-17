/*---------------------------------------------------------------------------
Задайте прямоугольный двумерный массив.Напишите программу, 
которая будет находить строку с наименьшей суммой элементов
-----------------------------------------------------------------------------
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

int FindRow(int[,] inputArray)
{
    int i = 0; int j = 0;  int minValue = int.MaxValue; int indexRow = 0;

    for (i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (j = 0; j < inputArray.GetLength(1); j++)
        
            sum += inputArray[i, j];

            if (sum < minValue)
            {
                minValue = sum;
                indexRow= i;
            }
        

    }
    return indexRow;
}



int[,] twoDimArray = FillTwoDimArray(4, 3);
Console.WriteLine("Изначальный массив:");
PrintTwoDimArray(twoDimArray);

int ind = FindRow(twoDimArray);

Console.WriteLine("Миниимальная сумма элементов в строке " + (ind+1) +"." + " Индекс строки = " + "["+ ind+"]");