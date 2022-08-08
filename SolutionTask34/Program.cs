/*------------------------------------------------------------------------------------------
Программа, которая определяет присутствует ли заданное чмсло в массиве
--------------------------------------------------------------------------------------------
*/

int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
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

bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break;
        }
        i++;
    }
    return resultSearch;
}


int[] bufferArray = FillingArray();

PrintIntArray(bufferArray);

Console.WriteLine("ВВедите число для поиска: ");
int searchNumber  = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateTask(bufferArray,searchNumber));
