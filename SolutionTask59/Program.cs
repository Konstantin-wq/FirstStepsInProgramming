/*----------------------------------------------------------------------------------------------
Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива
------------------------------------------------------------------------------------------------
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


// Метод сортирующий элементы строки
//Принимает двумерный массив и возвращает отсортированный по возрастанию входной массив(построчно)
int[,] SortRowTwoDimArray(int[,] inputArray)
{
    int[,] bufferArray = new int[inputArray.GetLength(0),inputArray.GetLength(1)];
    int i = 0; int j = 0; int k =0; int tmp = 0;
    int[] outputArray = new int[inputArray.GetLength(0)*inputArray.GetLength(1)];

    for(i = 0; i<inputArray.GetLength(0);i++)
    {
        for (j = 0; j<inputArray.GetLength(1);j++)
        {
            for (k = 0; k < inputArray.GetLength(1); k++)
                    {
                        if (inputArray[i, j] >= inputArray[i, k]) continue;
                        tmp = inputArray[i, j];
                        inputArray[i, j] = inputArray[i, k];
                        inputArray[i, k] = tmp;
                    }


        }
    }
    return inputArray;
}


// Метод сортирующий элементы строки
//Принимает двумерный массив и возвращает отсортированный по убыванию входной массив(построчно)
int[,] SortRowSeconVarTwoDimArray(int[,] inputArray)
{
    int[,] bufferArray = new int[inputArray.GetLength(0),inputArray.GetLength(1)];
    int i = 0; int j = 0; int k =0; int tmp = 0;
    int[] outputArray = new int[inputArray.GetLength(0)*inputArray.GetLength(1)];

    for(i = 0; i<inputArray.GetLength(0);i++)
    {
        for (j = 0; j<inputArray.GetLength(1);j++)
        {
            for (k = 0; k < inputArray.GetLength(1); k++)
                    {
                        if (inputArray[i, j] <= inputArray[i, k]) continue;
                        tmp = inputArray[i, j];
                        inputArray[i, j] = inputArray[i, k];
                        inputArray[i, k] = tmp;
                    }


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
Console.WriteLine("Изначальный массив:");
PrintTwoDimArray(twoDimArray);

Console.WriteLine();
Console.WriteLine("Сортировка строк по возрастанию:");
PrintTwoDimArray(SortRowTwoDimArray(twoDimArray));

Console.WriteLine();

Console.WriteLine("Сортировка строк по убыванию");
PrintTwoDimArray(SortRowSeconVarTwoDimArray(twoDimArray));