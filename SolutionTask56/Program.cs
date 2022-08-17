/*---------------------------------------------------------------------------------------------------------
Составить частотный словарь элементов двумерного массива
Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных
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
            outArray[i, j] = numberSynteztor.Next(0, 10);
            j++;
        }
        i++;
    }

    return outArray;
}


// Метод меняет местами первую и последнюю строки
//Принимает двумерный массив и возвращает модифицированный входной массив

int[] FrequencyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];
    {
        int i = 0; int j = 0;


        while (i < inputArray.GetLength(0))
        {
            j = i;
            while (j < inputArray.GetLength(0))
            {
                //Собираем частоту появления элементов
                resultArray[inputArray[i,j]]++;
                j++;
            }
            i++;
        }
        


    }

    return resultArray;
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

//Печатаем одномерный массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}





int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

int[] frequency = FrequencyCollect(twoDimArray,10);
PrintIntArray(frequency);