/*----------------------------------------------------------------------------
Программа, которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования
------------------------------------------------------------------------------
*/

//Заполняем массив
int[] FillingArray(int arrayLength)

{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
    {
        outArray[i] = numberSintezator.Next(1, 100);
        i++;
    }
    return outArray;

}

//Печатаем массив
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



//Метод через CopyTo
int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    inputArray.CopyTo(buferArray,0);
    return buferArray;
}



int[] testArray = FillingArray(13);
PrintIntArray(testArray);

int[] outArray = (int[])CopyArrayStandartTool(testArray);
PrintIntArray(outArray);