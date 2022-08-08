/*-----------------------------------------------------------------------------------------------------
Программа, которая заменяет элементы массива (положительные на отрицательные и наооборот)
-------------------------------------------------------------------------------------------------------
*/ 

int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while(i<12)
    {
        outArray[i] = numberSintezator.Next(-9,10);
        i++;
    }
    return outArray;
}

int[] CalculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while(i<12)
    {
        outputArray[i] = inputArray[i]*(-1);
        i++;
    }
          
    return outputArray;
}

int[] InvertArrayTilda(int[] inputArray)
{
    int i = 0;
    while(i <inputArray.Length)
    {
        inputArray[i] = (~inputArray[i])+1;
        i++;
    }
    return inputArray;
}

void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while (i <inputArray.Length - 1)
    {
    Console.Write(inputArray[i] + ", ");
    i++;
    }
    Console.WriteLine(inputArray[i]);
}


int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray =   CalculateTask(bufferArray);

PrintIntArray(resultArray);


resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);
