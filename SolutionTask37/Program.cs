/*---------------------------------------------------------------------------
Программа, которая задает массив заполненный случайными положительными числами,
показывает количество четных чисел в массиве и сортирует массив
методом пузырьковой сортировки
*/

Console.Clear();

//Заполняем массив
int[] FillingArray()
{
    int[] outArray = new int[20];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 20)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;

}

//Расчет количества четных чисел в массиве
int CalculateTask(int[] inputArray)
{
    int oddNumbers = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] % 2 == 0)
        {
            oddNumbers++;

        }
        i++;
    }
    return (oddNumbers);
}

//Выводим массив
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

//Сортируем массив
int[] SortedArray(int[] inputArray)
{
    //int[] resultArray = new int[inputArray.Length];
    int temp = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < inputArray.Length - i - 1; j++)
        {
            if (inputArray[j] > inputArray[j+1])
            {
                temp = inputArray[j];
                inputArray[j] = inputArray[j+1];
                inputArray[j+1] = temp;
            }
        }
    }

    return (inputArray);
}

//Выводим неотсортированный массив 
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

//Выводим количество четных элементов
Console.Write("Количество четных элементов: ");
Console.WriteLine(CalculateTask(bufferArray));

//Выводим отсортированный массив методом пузырьковой сортировки
Console.WriteLine("Отсортированный массив: ");
int[] bubbleSort = SortedArray(bufferArray);
PrintIntArray(bubbleSort);