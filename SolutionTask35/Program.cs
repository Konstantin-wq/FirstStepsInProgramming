/*----------------------------------------------------------------
Программа, которая находит количество элементов массива из 123 случайных чисел значения которых 
лежат в отрезке [10,99].
------------------------------------------------------------------
*/ 

int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(-1000,1000);
        i++;
    }
    return outArray;
}

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

int CalculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int  resultCount = 0;
    int i = 0;
    while (i <inputArray.Length)
    {
        if(inputArray[i] >=downBorder && inputArray[i]<=upBorder)
        {
            Console.Write(inputArray[i]+ " ");
            resultCount++;
            
        }
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine(CalculateTask(bufferArray,10,99));
