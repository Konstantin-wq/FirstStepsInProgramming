/*---------------------------------------------------------------------------------------------------------
Программа, которая меняет строки на столбцы, в случае если 
это невозможно, программа выводит сообщение для пользователя
-----------------------------------------------------------------------------------------------------------
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

int[,] RotateTwoDimArray(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(0))
        {
            //Блок ротации элементов
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;

        }
        i++;
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
        while (j < inputArray.GetLength(0))
        {
            Console.Write(inputArray[i, j] + "\t ");
            j++;
        }
        Console.WriteLine(); //альтернативный способ Console.WriteLine("\n");
        i++;

    }

}


int[,] twoDimArray = FillTwoDimArray(3, 3);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив нельзя перевернуть");
}
else
{
    PrintTwoDimArray(RotateTwoDimArray(twoDimArray));
}
Console.WriteLine();


