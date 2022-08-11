/*----------------------------------------------------------------------------
Программа, которая перевернет одномерный массив(последний элемент - на первое место, 
первый - на последнее)
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



//1 метод
int[] ReverseArray(int[] inputArray)
{
    int length = inputArray.Length;
    int[] newArray = new int[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++)
    {
        newArray[length - 1 - i] = inputArray[i];
        // i =0 length - 1- i = 12
        //i = 1 length - 1  i = 11
    }
    return (newArray);
}


//2 метод

int[] ReverseSwapArray(int[] inputArray)
{
    int length = inputArray.Length;
    int buf;

    for (int i = 0; i < length / 2; i++)
    {
        buf = inputArray[i];
        inputArray[i] = inputArray[length - 1 - i];
        inputArray[length - 1 - i] = buf;
    }
    return (inputArray);
}






int[] bufferArray = FillingArray(13);
PrintIntArray(bufferArray);


int[] firstMethod = ReverseArray(bufferArray);
PrintIntArray(firstMethod);

int[] secondMethod = ReverseSwapArray(bufferArray);
PrintIntArray(secondMethod);