/*------------------------------------------------------------------------
Задается массив вещественных чисел
Найти разницу между максимальным и минимальным элементом массива
--------------------------------------------------------------------------
*/

Console.Clear();
DateTime timePointInt = DateTime.Now;

//Заполняем массив
int[] FillingArray()

{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
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

//Находим разницу между максимальным и минимальным элементом массива
int DifferenceMinMax(int[] inputArray)
{
    int minimum = int.MaxValue;
    int maximum = int.MinValue;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] > maximum)
        {
            maximum = inputArray[i];
        }
        if (inputArray[i] < minimum)
        {
            minimum = inputArray[i];
        }
        i++;
    }
    Console.WriteLine("Максимальное значение в массиве: " + maximum);
    Console.WriteLine("Минимальное значение в массиве: " + minimum);
    return (maximum - minimum);
}


//Метод сортировки массива вставкой
int[] FirstMethodInsertion(int[] inputArray)
{
    int index = 0;
    int currentNumber = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        index = i;
        currentNumber = inputArray[i];
        while (index > 0 && currentNumber < inputArray[index - 1])
        {
            inputArray[index] = inputArray[index - 1];
            index--;
        }
        inputArray[index] = currentNumber;
    }
    return (inputArray);
}


//Метод сортировки массива подсчетом
int[] CountingSortMethod(int[] inputArray)
{
    //Объявляем выходной отсортированный массив
    int[] sortedArray = new int[inputArray.Length];

    //Создаем массив-счетчик
    int[] counts = new int[12];

    for (int i = 0; i < 12; i++)
    {
        counts[i] = 0;
    }

    for (int i = 0; i < counts.Length; i++)
    {
        ++counts[i];
    }
    for (int i = 1; i < 11; i++)
    {
        counts[i] += counts[i - 1];

    }
    for (int i = sortedArray.Length - 1; i >= 0; i--)
    {
        sortedArray[counts[i] - 1] = inputArray[i];
        counts[i]--;
    }

    for (int i = 0; i < sortedArray.Length; ++i)
        inputArray[i] = sortedArray[i];


    return (sortedArray);
}




//Вывод на экран заполненнного массива
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

//Вывод разницы между максимальным и минимальным элементом
int result = DifferenceMinMax(bufferArray);
Console.Write("Разница между максимальным и минимальным элементом: ");
Console.WriteLine();
Console.WriteLine(result);

Console.ForegroundColor = ConsoleColor.Yellow; 
timePointInt = DateTime.Now;
int[] insertionMethod = FirstMethodInsertion(bufferArray);
Console.WriteLine();
Console.WriteLine("Выводим отсортированный массив первым способом: ");
PrintIntArray(insertionMethod);
Console.WriteLine("Время работы алгоритма №1: " + (DateTime.Now - timePointInt));


Console.ForegroundColor = ConsoleColor.Red;
timePointInt = DateTime.Now;
int[] countSortMethod = CountingSortMethod(bufferArray); 
Console.WriteLine();
Console.WriteLine("Второй метод сортировки:");
PrintIntArray(countSortMethod);
Console.WriteLine("Время работы алгоритма №2: " + (DateTime.Now - timePointInt));